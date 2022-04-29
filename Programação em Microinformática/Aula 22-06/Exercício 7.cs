using System;

class Program {
    static void Main(string[] args) { //inicio

    double s, e, r;

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
    Console.WriteLine("║                                                          ║");

    Console.SetCursorPosition(2,11);
    Console.WriteLine("║                                                          ║");
      
    Console.SetCursorPosition(2,12);
    Console.WriteLine("╚══════════════════════════════════════════════════════════╝");

    Console.SetCursorPosition(7,5);
    Console.WriteLine("Digite o valor do seu salário R$:");
    Console.SetCursorPosition(41,5);
    s = Convert.ToDouble(Console.ReadLine());

    Console.SetCursorPosition(7,7);
    Console.WriteLine("Digite o valor do empréstimo pretendido R$:");
    Console.SetCursorPosition(51,7);
    e = Convert.ToDouble(Console.ReadLine());

    r = (s / 100) * 30;

    Console.SetCursorPosition(17,9);
    Console.ForegroundColor = ConsoleColor.Green;
    if(r >= e) {
     Console.WriteLine("Pedido de empréstimo aceito");
    }

    else {
     Console.ForegroundColor = ConsoleColor.Red;
     Console.WriteLine("Pedido de empréstimo não aceito");
    }
      
    Console.ReadKey();
      
    } //fim
}