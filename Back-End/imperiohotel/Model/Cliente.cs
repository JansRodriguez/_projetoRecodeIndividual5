namespace imperiohotel.Model
{
    [Table("clientes")]
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

        public string Nome { get; set; }

        public string cpf { get; set; }
        
        public string Email { get; set; }
    }
}