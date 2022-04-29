using System;

class Program {
    static void Main(string[] args) { //inicio

    double n, t, s;

    Console.BackgroundColor = ConsoleColor.Blue;
    Console.Clear();

    Console.ForegroundColor = ConsoleColor.White;

    Console.SetCursorPosition(2,2);
    Console.WriteLine("╔══════════════════════════════════════════════════════════╗  ");

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

    t = n % 3;

    s = n % 7;

    if((t == 0) && (s == 0)) {
     Console.SetCursorPosition(19,7);
     Console.WriteLine(n + " é multiplo de 3 e 7");
    }

    else {
      Console.SetCursorPosition(17,7);
      Console.WriteLine(n + " não é multiplo de 3 e 7");
    }
      
    Console.ReadKey();
      
    } //fim
}