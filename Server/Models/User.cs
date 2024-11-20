namespace AstrologyAPI.Models;

public class User
{
    public int Id { get; set; }
    public string Nickname { get; set; }
    public string Signo { get; set; }
    public string Plano { get; set; } // "básico" ou "avançado"
}
