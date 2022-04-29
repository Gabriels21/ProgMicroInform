using System;

class Program {
    static void Main(string[] args) { //inicio

    double n, nv, nf;

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

    Console.SetCursorPosition(21,5);
    Console.WriteLine("Digite um número:");
    Console.SetCursorPosition(39,5);
    n = Convert.ToDouble(Console.ReadLine());

    nv = n/2;
    nf = n * 2;

    if(n >= 20) {
     Console.SetCursorPosition(14,7);
     Console.WriteLine("A metade do número digitado é: " + nv);
    }

    else {
     Console.SetCursorPosition(15,7);
     Console.WriteLine("O dobro do número digitado é: " + nf);
    }
      
    Console.ReadKey();
      
    } //fim
}