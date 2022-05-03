using System;

class Program {
    static void Main(string[] args) {  //inicio

    double n;

    do {

    Console.WriteLine("Digite um número par:");
    n = Convert.ToDouble(Console.ReadLine());

    } while (n % 2 != 0);

    Console.WriteLine(n + " é par");

    Console.ReadKey();
      
    } //fim
}
