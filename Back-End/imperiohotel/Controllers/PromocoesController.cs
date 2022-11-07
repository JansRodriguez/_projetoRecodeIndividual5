using Microsoft.AspNetCore.Mvc;
using imperiohotel.Model;
using imperiohotel.Repository;

namespace imperiohotel.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PromocoesController : ControllerBase
    {
        //injetar dependencia do repositorio
        private readonly IPromocoesRepository _repository;

        public UsuarioController(IClienteRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var clientes = await _repository.GetCliente();
            return clientes.Any() ? Ok(clientes) : NoContent();
        }

        [HttpGet("{idCliente}")]
        public async Task<IActionResult> GetById(int idCliente)
        {
            var clientes = await _repository.GetUsuarioById(idCliente);
            return clientes != null
            ? Ok(clientes) : NotFound("Não achamos esse cliente.");
        }

        [HttpPost]
        public async Task<IActionResult> Post(Cliente cliente)
        {
            _repository.AddCliente(cliente);
            return await _repository.SaveChangesAsync()
            ? Ok("Cliente adicionado com sucesso") : BadRequest("Algo infelizmente deu errado.");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Atualizar(int id, Cliente cliente)
        {
            var clienteExiste = await _repository.GetUsuarioById(idCliente);
            if (clienteExiste == null) return NotFound("Ops, cliente não encontrado");

            clienteExiste.Nome = usuario.Nome ?? clienteExiste.Nome;
            clienteExiste.cpf = cliente.cpf != new DateTime()
            ? cliente.cpf : usuarioExiste.cpf;

            _repository.AtualizarUsuario(clienteExiste);

            return await _repository.SaveChangesAsync()
            ? Ok("Cliente atualizado.") : BadRequest("Infelizmente algo deu errado.");
        }

        [HttpDelete("{idCliente}")]
        public async Task<IActionResult> Delete(int idCliente)
        {
            var clienteExiste = await _repository.GetUsuarioById(idCliente);
            if (clienteExiste == null)
                return NotFound("Desculpe, cliente não encontrado");

            _repository.DeletarUsuario(clienteExiste);

            return await _repository.SaveChangesAsync()
            ? Ok("Cliente deletado.") : BadRequest("Infelizmente, algo deu errado.");
        }

    }
}