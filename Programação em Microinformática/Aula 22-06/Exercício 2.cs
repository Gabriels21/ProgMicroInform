using System;

class Program {
    static void Main(string[] args) { //inicio

    double c, formula;

    Console.BackgroundColor = ConsoleColor.Blue;
    Console.Clear();

    Console.ForegroundColor = ConsoleColor.White;

    Console.SetCursorPosition(1,2);
    Console.WriteLine("╔════════════════════════════════════════════════════════════╗");

    Console.SetCursorPosition(1,3);
    Console.WriteLine("║                                                            ║");

    Console.SetCursorPosition(1,4);
    Console.WriteLine("║                                                            ║");

    Console.SetCursorPosition(1,5);
    Console.WriteLine("║                                                            ║");

    Console.SetCursorPosition(1,6);
    Console.WriteLine("║                                                            ║");

    Console.SetCursorPosition(1,7);
    Console.WriteLine("║                                                            ║");

    Console.SetCursorPosition(1,8);
    Console.WriteLine("║                                                            ║");

    Console.SetCursorPosition(1,9);
    Console.WriteLine("║                                                            ║");
      
    Console.SetCursorPosition(1,10);
    Console.WriteLine("╚════════════════════════════════════════════════════════════╝");

    Console.SetCursorPosition(12,5);
    Console.WriteLine("Digite uma temperatura em graus °C:");
    Console.SetCursorPosition(48,5);
    c = Convert.ToDouble(Console.ReadLine());

    formula = c + 273.15;

    if(formula >= 283.5) {
    Console.SetCursorPosition(4,7);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("A temperatura digitada corresponde a " + formula + " graus Kelvin");
    }

    else {
    Console.SetCursorPosition(4,7);
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("A temperatura digitada corresponde a " + + formula + " graus Kelvin");
    }
      
    Console.ReadKey();
      
    } //fim
}