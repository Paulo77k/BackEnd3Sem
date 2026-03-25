using Filmes.WebAPI.DTO;
using Filmes.WebAPI.Interface;
using Filmes.WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Filmes.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LoginController : ControllerBase
{
    private readonly IUsuarioRepository _usuarioRepository;
    public LoginController(IUsuarioRepository usuarioRepository)
    {
        _usuarioRepository = usuarioRepository;
    }
    [HttpPost]
    public IActionResult Login(LoginDTO loginDTO)
    {
        try
        {
            TbUsuario usuarioBuscado =
                _usuarioRepository.BuscarPorEmailESenha
                (loginDTO.Email!, loginDTO.Senha);
            if(usuarioBuscado == null)
            {
                return NotFound("Email ou Senha invalidos");
            }
            //Caso encontre o usuario, prosseguie para a criacao do token
            // 1 definir as informacoes (claims) que serao fornecidas no token

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Jti,usuarioBuscado.Idusuario),
                new Claim(JwtRegisteredClaimNames.Email,usuarioBuscado.Email!)
            };

            //2 - Definir a chave de acesso ao token
            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("filmes-chave-autenticacao-webapi-dev"));
            //3 definir as credenciais do token (HEADER)
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            //4 Gerar Token
            var token = new JwtSecurityToken
                (
                     //emissor do token
                     issuer: "api_filmes",
                     audience: "api_filmes",
                     claims: claims,
                     expires: DateTime.Now.AddMinutes(5),
                     signingCredentials: creds
                );
            return Ok(new
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
            });
        }
        catch (Exception erro)
        {

            return BadRequest(erro.Message);
        }

       
    }
}
