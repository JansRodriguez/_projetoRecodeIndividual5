using Microsoft.AspNetCore.Mvc;
using imperiohotel.Model;
using imperiohotel.Repository;

namespace imperiohotel.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PassagemController : ControllerBase
    {
        //injetar dependencia do repositorio
        private readonly IPassagemRepository _repository;

        public UsuarioController(IPassagemRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var passagens = await _repository.GetPassagem();
            return passagens.Any() ? Ok(passagens) : NoContent();
        }

        [HttpPost]
        public IActionResult CriarPassagem(Passagem item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            _context.Passagens.Add(item);
            _context.SaveChanges();
            return new ObjectResult(item);

        }

        // GET: api/Passagem - LISTA TODOS AS PASSAGENS 
        [HttpGet]
        public IEnumerable<Passagem> GetPassagems()
        {
            return _context.Passagens;
        }

        // GET: api/Passagem/id - LISTA PASSAGEM POR ID
        [HttpGet("{id}")]
        public IActionResult GetPassagemPorId(int idPassagem)
        {
            Passagem item = _context.Passagens.SingleOrDefault(modelo => modelo.PassagemId == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        
        [HttpPut("{idPassagem}")]
        public IActionResult AtualizaPassagem(int id, Passagem item)
        {
            if (idPassagem != item.PassagemId)
            {
                return BadRequest();
            }
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();

            return new NoContentResult();
        }

        //DELETE: DELETAR UMA PASSAGEM POR ID
        [HttpDelete("{idPassagem}")]
        public IActionResult DeletaPassagem(int id)
        {
            var item = _context.Passagens.SingleOrDefault(modelo => modelo.PassagemId == idPassagem);

            if (item == null)
            {
                return BadRequest();
            }

            _context.Passagens.Remove(item);
            _context.SaveChanges();
            return Ok(item);
        }
    }
}