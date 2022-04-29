using System;

class Program {
    static void Main(string[] args) { //inicio

    double n, r;

    Console.BackgroundColor = ConsoleColor.Black;
    Console.Clear();

    Console.ForegroundColor = ConsoleColor.Blue;

    Console.SetCursorPosition(2,2);
    Console.WriteLine("╔══════════════════════════════════════════════════════════╗");

    Console.SetCursorPosition(2,3);
    Console.WriteLine("║                                                          ║");

    Console.SetCursorPosition(2,4);
    Console.WriteLine("║                                                          ║");

    Console.SetCursorPosition(2,5);
    Console.WriteLine("║                                                          ║");

    Console.SetCursorPosition(2,6);
    Console.WriteLine("║                                                          ║");

    Console.SetCursorPosition(2,7);
    Console.WriteLine("║                                                          ║");

    Console.SetCursorPosition(2,8);
    Console.WriteLine("║                                                          ║");

    Console.SetCursorPosition(2,9);
    Console.WriteLine("║                                                          ║");
      
    Console.SetCursorPosition(2,10);
    Console.WriteLine("╚══════════════════════════════════════════════════════════╝");

    Console.SetCursorPosition(20,5);
    Console.WriteLine("Digite um número:");
    Console.SetCursorPosition(38,5);
    n = Convert.ToDouble(Console.ReadLine());

    r = n % 5;

    if(r == 0) {
     Console.SetCursorPosition(14,7);
     Console.WriteLine("O número digitado é multiplo de 5");
    }

    else {
     Console.SetCursorPosition(12,7);
     Console.WriteLine("O número digitado não é multiplo de 5");
    }
      
    Console.ReadKey();
      
    } //fim
}