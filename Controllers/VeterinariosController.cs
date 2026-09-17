using ClinicaVeterinariaAPI.Data;
using ClinicaVeterinariaAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClinicaVeterinariaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeterinariosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public VeterinariosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Veterinario>>> GetVeterinario()
        {
            return await _context.Veterinarios.ToListAsync();
        }

        [HttpPost]
        public async Task<IActionResult> CriarVeterinario(Veterinario veterinario)
        {
            _context.Veterinarios.Add(veterinario);
            await _context.SaveChangesAsync();
            return Ok("Veterinário adicionado com secesso!");
        }
    }
}
