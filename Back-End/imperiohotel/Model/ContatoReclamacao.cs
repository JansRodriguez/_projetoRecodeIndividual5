namespace imperiohotel.Model
{
    [Table("contatos")]
    public class ContatoReclamacao
    {
        [Key]
        public int IdContato { get; set; }

        public string email { get; set; }

        public string nome { get; set; }

        public string assunto { get; set; }
    }
}