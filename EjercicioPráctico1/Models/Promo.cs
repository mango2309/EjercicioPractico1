namespace EjercicioPráctico1.Models
{
    public class Promo
    {
        public int PromoID { get; set; }

        public string? Descripcion { get; set; }

        public DateTime FechaPromo { get; set; }

        public int BurgerID { get; set; }
        public Burger? Burger { get; set; }
    }
}
