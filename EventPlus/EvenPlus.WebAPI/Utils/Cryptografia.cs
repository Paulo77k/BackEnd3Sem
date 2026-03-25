using System.Reflection.Metadata.Ecma335;

namespace EvenPlus.WebAPI.Utils;

public class Cryptografia
{
   public static string GerarHash(string senha)
    {
        return BCrypt.Net.BCrypt.HashPassword(senha);
    }
    public static bool compararHash(string senhaInformada, string senhaBanco)
    {
        return BCrypt.Net.BCrypt.Verify(senhaInformada, senhaBanco);
    }
}

