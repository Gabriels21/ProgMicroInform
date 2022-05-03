using System;

class Program {
    static void Main(string[] args) {  //inicio

    double n;

    do {

    Console.WriteLine("Digite um número:");
    n = Convert.ToDouble(Console.ReadLine());

    } while (n > 1);

    Console.WriteLine("O último número que foi digitado é igual ou menor que 1");

    Console.ReadKey();
      
    } //fim
}