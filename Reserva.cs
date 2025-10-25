using System;
using System.Collections.Generic;

namespace HotelReserva.Models
{
    public class Reserva
    {
        public Suite Suite { get; set; }
        public List<Pessoa> Hospedes { get; set; } = new List<Pessoa>();
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count > Suite.Capacidade)
                throw new Exception("Número de hóspedes maior que a capacidade da suíte.");

            Hospedes = hospedes;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorReserva()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;
            if (DiasReservados > 10)
                valor *= 0.9m; // desconto de 10%
            return valor;
        }
    }
}
