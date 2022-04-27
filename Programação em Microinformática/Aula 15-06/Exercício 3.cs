using System;

class Program {
    static void Main(string[] args) {//inicio
        
        int a, n, i;
      
        Console.WriteLine("Digite o ano de seu nascimento:");
        n  = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o ano atual:");
        a  = Convert.ToInt32(Console.ReadLine());

        i = a - n;

        Console.WriteLine("Você tem " + i + " anos");

        Console.ReadKey();
      
    } //fim
}