using System;

class Program {
    static void Main(string[] args) { //inicio

    double n;

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

    Console.SetCursorPosition(12,7);
    if(n > 0) {
     Console.SetCursorPosition(12,7);
     Console.WriteLine("O número que foi digitado é ");
     Console.SetCursorPosition(40,7);
     Console.ForegroundColor = ConsoleColor.Green;
     Console.WriteLine("positivo");
     
    }

    else if(n < 0) {
     Console.SetCursorPosition(12,7);
     Console.WriteLine("O número que foi digitado é ");
     Console.SetCursorPosition(40,7);
     Console.ForegroundColor = ConsoleColor.Red;
     Console.WriteLine("negativo");
    
    }

    else {
     Console.SetCursorPosition(13,7);
     Console.WriteLine("O número que foi digitado é ");
     Console.SetCursorPosition(41,7);
     Console.ForegroundColor = ConsoleColor.Cyan;
     Console.WriteLine("zero");
    }
      
    Console.ReadKey();
      
    } //fim
}