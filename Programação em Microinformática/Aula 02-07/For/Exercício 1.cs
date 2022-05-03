using System;

class Program {
    static void Main(string[] args) { //inicio

    int n, c;

    Console.WriteLine("Digite um número");
    n = Convert.ToInt32(Console.ReadLine());
      
    Console.Clear();

    Console.WriteLine("Tabuada do " + n);

    for(c = 0; c <= 10; c++){

    Console.WriteLine(n + " X " + c + " = " + n*c);
      
    }

    Console.ReadKey();
    
    } //fim
}