using System;

class Program {
    static void Main(string[] args) {//inicio
        
        int n, a;
      
        Console.WriteLine("Digite um número:");
        n  = Convert.ToInt32(Console.ReadLine());

        a = n - 1;
      
        Console.WriteLine("O antecessor do número digitado é: " + a);

        Console.ReadKey();
      
    } //fim
}