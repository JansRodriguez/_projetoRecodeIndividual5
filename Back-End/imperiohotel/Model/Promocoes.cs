namespace imperiohotel.Model
{
    [Table("promocoes")]
    public class Promocoes
    {
        [Key]
        public int IdSolicitacao { get; set; }

        public string nome { get; set; }

        public string LocalDesejado { get; set; }

        public string Email { get; set; }
    }
}