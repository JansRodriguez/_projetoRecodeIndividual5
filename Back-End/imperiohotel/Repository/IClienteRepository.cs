using imperiohotel.Model;

namespace imperiohotel.Repository
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Cliente>> GetClientes();
        Task<Cliente> GetClienteById(int idCliente);
        void AddCliente(Cliente clientes);
        void AtualizarCliente(Cliente clientes);
        void DeletarCliente(Cliente clientes);
        Task<bool> SaveChangesAsync();
        
    }
}