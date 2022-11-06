namespace imperiohotel.Model
{
    [Table("passagens")]
    public class Passagem
    {
        [Key]
        public int IdDestino { get; set; }

        public Date dataViagem { get; set; }

        public Date dataRetorno { get; set; }

        public string localOrigem { get; set; }

        public string localRetorno { get; set; }

        public double valorPassagem { get; set; }
    }
}