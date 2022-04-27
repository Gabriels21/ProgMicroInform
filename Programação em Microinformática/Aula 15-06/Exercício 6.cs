using System;

class Program {
    static void Main(string[] args) { //inicio

        double a, area, b;
      
        Console.WriteLine("Digite a base do retângulo:");
        b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a altura do retângulo:");
        a = Convert.ToDouble(Console.ReadLine());

        area = b * a;

        Console.WriteLine("A área do retângulo é: " + area);

        Console.ReadKey();
      
    } //fim
}