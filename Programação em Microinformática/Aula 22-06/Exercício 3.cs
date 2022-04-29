using System;

class Program {
    static void Main(string[] args) {  //inicio

    double f, formula;

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
    Console.WriteLine("Digite uma temperatura em graus °F:");
    Console.SetCursorPosition(48,5);
    f = Convert.ToDouble(Console.ReadLine());

    formula = ((f - 32) * 5) /9;

    if(formula >= 10) {
    Console.SetCursorPosition(4,7);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("A temperatura digitada corresponde a " + Math.Round(formula,2) + " graus Celsius");
    }

    else {
    Console.SetCursorPosition(4,7);
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("A temperatura digitada corresponde a " + Math.Round(formula,2) + " graus Celsius" );
    }
      
    Console.ReadKey();
      
    }  //fim
}