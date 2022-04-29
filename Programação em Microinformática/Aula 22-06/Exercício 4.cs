using System;

class Program {
    static void Main(string[] args) {  //inicio

    double p, peso_g, porcentagem, pa;

    Console.BackgroundColor = ConsoleColor.Blue;
    Console.Clear();

    Console.ForegroundColor = ConsoleColor.White;

    Console.SetCursorPosition(1,2);
    Console.WriteLine("╔═══════════════════════════════════════════════════════════╗");

    Console.SetCursorPosition(1,3);
    Console.WriteLine("║                                                           ║");

    Console.SetCursorPosition(1,4);
    Console.WriteLine("║                                                           ║");

    Console.SetCursorPosition(1,5);
    Console.WriteLine("║                                                           ║");

    Console.SetCursorPosition(1,6);
    Console.WriteLine("║                                                           ║");

    Console.SetCursorPosition(1,7);
    Console.WriteLine("║                                                           ║");

    Console.SetCursorPosition(1,8);
    Console.WriteLine("║                                                           ║");

    Console.SetCursorPosition(1,9);
    Console.WriteLine("║                                                           ║");

    Console.SetCursorPosition(1,10);
    Console.WriteLine("║                                                           ║");

    Console.SetCursorPosition(1,11);
    Console.WriteLine("║                                                           ║");
      
    Console.SetCursorPosition(1,12);
    Console.WriteLine("╚═══════════════════════════════════════════════════════════╝");

    Console.SetCursorPosition(15,5);
    Console.WriteLine("Digite seu peso em quilos:");
    Console.SetCursorPosition(42,5);
    p = Convert.ToDouble(Console.ReadLine());

    peso_g = p * 1000;
    porcentagem = (p / 100) * 10;
    pa = p + porcentagem;

    Console.SetCursorPosition(19,7);
    Console.WriteLine("Você pesa " + peso_g + " gramas");

    Console.SetCursorPosition(8,9);
    Console.WriteLine("Seu peso com um acréscimo de 10% é: " + Math.Round(pa,2) + " quilos");
      
    Console.ReadKey();
      
    }  //fim
}