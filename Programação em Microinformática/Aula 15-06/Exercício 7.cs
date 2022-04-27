using System;

class Program {
    static void Main(string[] args) { //inicio

    int dias, i, m, i_d;

    Console.WriteLine("Digite sua idade:");
    i = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite o mês:");
    m = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite os dias:");
    dias = Convert.ToInt32(Console.ReadLine());

    i_d = (i * 365) + (m * 30) + dias;

    Console.WriteLine("Sua idade em dias é: "  + i_d);

    Console.ReadKey();
      
    } //fim
}