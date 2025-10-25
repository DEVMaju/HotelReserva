using System;
using System.Collections.Generic;
using HotelReserva.Models;

class Program
{
    static void Main()
    {
        // Criando hóspedes
        var hospede1 = new Pessoa("Maria", 28);
        var hospede2 = new Pessoa("João", 30);

        // Criando suíte
        var suite = new Suite("Luxo", 150, 2);

        // Criando reserva
        var reserva = new Reserva(12); // 12 dias
        reserva.Suite = suite;

        // Cadastrando hóspedes
        reserva.CadastrarHospedes(new List<Pessoa> { hospede1, hospede2 });

        // Exibindo informações
        Console.WriteLine($"Quantidade de hóspedes: {reserva.ObterQuantidadeHospedes()}");
        Console.WriteLine($"Valor total da reserva: R$ {reserva.CalcularValorReserva():F2}");
    }
}
