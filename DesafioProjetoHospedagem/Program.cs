using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Nathan");
Pessoa p2 = new Pessoa(nome: "Nicolas");

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 120);

Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine("Resumo da reserva:");
Console.WriteLine("----------------------------------------");

Console.WriteLine("Hóspedes cadastrados:");
Console.WriteLine($"{p1.Nome}");
Console.WriteLine($"{p2.Nome}");
Console.WriteLine($"Qtd de hóspedes cadastrados: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Capacidade da suíte: {suite.Capacidade}");
Console.WriteLine("----------------------------------------");

Console.WriteLine($"Tipo da suíte: {suite.TipoSuite}");
Console.WriteLine($"Qtd de dias reservados: {reserva.DiasReservados}");
Console.WriteLine($"Valor da diária: {suite.ValorDiaria:F2}");
Console.WriteLine($"Valor total à pagar: {reserva.CalcularValorDiaria():F2}");
Console.WriteLine("----------------------------------------");
