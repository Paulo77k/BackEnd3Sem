using Azure;
using Azure.AI.ContentSafety;
using EvenPlus.WebAPI.DTO;
using EvenPlus.WebAPI.Interfaces;
using EvenPlus.WebAPI.Models;
using EventPlus.WebAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EvenPlus.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ComentarioEventoControllerr : ControllerBase
{
    private readonly ContentSafetyClient _contentSafetyClient;
    private readonly IComentarioEventoRepository _comentarioEventoRepository;
    public ComentarioEventoControllerr(ContentSafetyClient contentSafetyClient, IComentarioEventoRepository context)
    {
        _comentarioEventoRepository = _comentarioEventoRepository; 
        _contentSafetyClient = contentSafetyClient;
    }
    [HttpPost]
    public async Task<IActionResult> Post(ComentarioEventoDTO comentarioEvento)
    {
        try
        {
            if (string.IsNullOrEmpty(comentarioEvento.Descricao))
            {
                return BadRequest("O texto a ser moderado nao pode estar vazio");
            }
            var request = new AnalyzeTextOptions(comentarioEvento.Descricao);
            Response<AnalyzeTextResult> response = await _contentSafetyClient.AnalyzeTextAsync(request);

            bool temconteudoImproprio = response.Value.CategoriesAnalysis.Any(c => c.Severity > 0);
            var novoComentario = new ComentarioEvento
            {
                IdEvento = comentarioEvento.IdEvento,
                IdUsuario = comentarioEvento.IdUsuario,
                Descricao = comentarioEvento.Descricao,
                Exibe = !temconteudoImproprio,
                DataComentarioEvento = DateTime.Now,
            };

            _comentarioEventoRepository.Cadastrar(novoComentario);
            return StatusCode(201, novoComentario);


        }
        catch (Exception e)
        {

            return BadRequest(e.Message);
        }
    }
        
}
