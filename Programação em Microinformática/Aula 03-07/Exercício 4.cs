using System;

class Program {
    static void Main(string[] args) {  //inicio

    double s, n;

    s = 0;

    do {

    Console.WriteLine("Digite um número:");
    n = Convert.ToDouble(Console.ReadLine());
    s = s + n;

    } while (n != 0);

    Console.WriteLine("A soma dos números digitados é " + s);

    Console.ReadKey();
      
    } //fim
}