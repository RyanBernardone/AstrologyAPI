using Microsoft.AspNetCore.Mvc;
using AstrologyAPI.Data;
using AstrologyAPI.Models;

namespace AstrologyAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class AstrologyController : ControllerBase
{
    private readonly AstrologyDbContext _context;

    public AstrologyController(AstrologyDbContext context)
    {
        _context = context;
    }

    [HttpPost("register")]
    public IActionResult Register(User user)
    {
        if (_context.Users.Any(u => u.Nickname == user.Nickname))
            return BadRequest("Usuário já existente.");

        _context.Users.Add(user);
        _context.SaveChanges();
        return Ok("Usuário registrado com sucesso.");
    }

    [HttpGet("horoscope")]
    public IActionResult GetHoroscope(string nickname)
    {
        var user = _context.Users.FirstOrDefault(u => u.Nickname == nickname);
        if (user == null)
            return NotFound("User not found.");

        var basicMessage = $"Olá {user.Nickname}, hoje será um grande dia para {user.Signo}!";
        if (user.Plano == "básico")
            return Ok(new { mensagem = basicMessage });

        var luckyNumber = new Random().Next(1, 100);
        return Ok(new { mensagem = basicMessage, numero_da_sorte = luckyNumber });
    }
}
