using System;

class Program {
    static void Main(string[] args) {//inicio
        
        double n1, n2, n3, m;
      
        Console.WriteLine("Digite o primeiro número:");
        n1  = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        n2  = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o terceiro número:");
        n3  = Convert.ToDouble(Console.ReadLine());

        m = (n1 + n2 + n3) / 3;
      
        Console.WriteLine("A média aritmética dos três números digitados é: " + m);

        Console.ReadKey();
      
    } //fim
}