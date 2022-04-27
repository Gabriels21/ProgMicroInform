using System;

class Program {
    static void Main(string[] args) {//inicio
        
        double n1, n2, adicao, sub, multi, divisao;
      
        Console.WriteLine("Digite o primeiro número:");
        n1  = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        n2  = Convert.ToDouble(Console.ReadLine());

        adicao = n1 + n2;
        sub = n1 - n2;
        multi = n1 * n2;
        divisao = n1 / n2;

        Console.WriteLine("O resultado da adição de " + n1 + " + " + n2 + " é: " + adicao);
        Console.WriteLine("O resultado da subtração de " + n1 + " - " + n2 + " é: " + sub);
        Console.WriteLine("O resultado da multiplicação de " + n1 + " * " + n2 + " é: " + multi);
        Console.WriteLine("O resultado da divisão de " + n1 + " / " + n2 + " é: " + divisao);

        Console.ReadKey();
      
    } //fim
}