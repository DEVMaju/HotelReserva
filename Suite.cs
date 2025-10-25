namespace HotelReserva.Models
{
    public class Suite
    {
        public string Tipo { get; set; }
        public decimal ValorDiaria { get; set; }
        public int Capacidade { get; set; }

        public Suite(string tipo, decimal valorDiaria, int capacidade)
        {
            Tipo = tipo;
            ValorDiaria = valorDiaria;
            Capacidade = capacidade;
        }
    }
}
