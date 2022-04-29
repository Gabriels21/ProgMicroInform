using System;

class Program {
    static void Main(string[] args) { //inicio

    double s, sm, t;

    Console.BackgroundColor = ConsoleColor.Blue;
    Console.Clear();

    Console.ForegroundColor = ConsoleColor.White;

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

    Console.SetCursorPosition(9,5);
    Console.WriteLine("Digite o valor do salário mínimo R$: ");
    Console.SetCursorPosition(46,5);
    sm = Convert.ToDouble(Console.ReadLine());
      
    Console.SetCursorPosition(9,7);
    Console.WriteLine("Digite o valor do seu salário R$: ");
    Console.SetCursorPosition(43,7);
    s = Convert.ToDouble(Console.ReadLine());

    t = s/sm;

    Console.SetCursorPosition(9,9);
    if(t == 1) {
     Console.WriteLine("Você ganha o equivalente a " + t + " salário minímo");
    }

    else {
      Console.WriteLine("Você ganha o equivalente a " + Math.Round(t,2) + " salários minímos");
    }
      
    Console.ReadKey();
      
    } //fim
}