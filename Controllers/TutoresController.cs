using ClinicaVeterinariaAPI.Data;
using ClinicaVeterinariaAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClinicaVeterinariaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TutoresController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TutoresController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tutor>>> GetTutor()
        {
            return await _context.Tutores.ToListAsync();
        }

        [HttpPost]
        public async Task<IActionResult> CriarTutor(Tutor tutor)
        {
            _context.Tutores.Add(tutor);
            await _context.SaveChangesAsync();
            return Ok("Tutor adicionado com secesso!");
        }
    }
}
