using Microsoft.AspNetCore.Mvc;
using TaskMaster.Models;
using Microsoft.EntityFrameworkCore; // Adicione isso para o ToListAsync

namespace TaskMaster.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoasController : ControllerBase
    {
        private readonly TaskMasterContext _context;

        public PessoasController(TaskMasterContext context)
        {
            _context = context;
        }

        // POST: api/pessoas
        [HttpPost]
        public async Task<ActionResult<Pessoa>> PostPessoa(Pessoa pessoa)
        {
            // Verifica se já existe uma pessoa com o mesmo e-mail (ou outro campo único)
            if (_context.Pessoas.Any(p => p.Email == pessoa.Email))
            {
                return Conflict("Já existe uma pessoa com este e-mail."); // Retorna 409 Conflict
            }

            _context.Pessoas.Add(pessoa);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPessoa), new { id = pessoa.Id }, pessoa);
        }

        // GET: api/pessoas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pessoa>>> GetPessoas()
        {
            return await _context.Pessoas.ToListAsync();
        }

        // GET: api/pessoas/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Pessoa>> GetPessoa(int id)
        {
            var pessoa = await _context.Pessoas.FindAsync(id);

            if (pessoa == null)
            {
                return NotFound();
            }

            return pessoa;
        }
    }
}
