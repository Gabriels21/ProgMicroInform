using System;

class Program {
    static void Main(string[] args) { //inicio

    double ap, tp, p, m;

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
    Console.WriteLine("║                                                          ║");

    Console.SetCursorPosition(2,11);
    Console.WriteLine("║                                                          ║");

    Console.SetCursorPosition(2,12);
    Console.WriteLine("║                                                          ║");

    Console.SetCursorPosition(2,13);
    Console.WriteLine("║                                                          ║");

    Console.SetCursorPosition(2,14);
    Console.WriteLine("║                                                          ║");
      
    Console.SetCursorPosition(2,15);
    Console.WriteLine("╚══════════════════════════════════════════════════════════╝");

    Console.SetCursorPosition(12,5);
    Console.WriteLine("Digite a nota de apresentação:");
    Console.SetCursorPosition(43,5);
    ap = Convert.ToDouble(Console.ReadLine());

    Console.SetCursorPosition(12,7);
    Console.WriteLine("Digite a nota do trabalho prático:");
    Console.SetCursorPosition(47,7);
    tp = Convert.ToDouble(Console.ReadLine());

    Console.SetCursorPosition(12,9);
    Console.WriteLine("Digite a nota da prova:");
    Console.SetCursorPosition(36,9);
    p = Convert.ToDouble(Console.ReadLine());

    m = (ap * 0.25) + (tp * 0.25) + (p * 0.50);
      
    Console.SetCursorPosition(14,12);
    if(m >= 9) {
     Console.WriteLine("Média das notas: " + Math.Round(m,2) + " , Conceito A");
    }

    else if((m >= 7.5) && (m < 9)){
      Console.WriteLine("Média das notas: " + Math.Round(m,2) + " , Conceito B");
    }

    else if((m >= 6) && (m < 7.5)){
      Console.WriteLine("Média das notas: " + Math.Round(m,2) + " , Conceito C");
    }

    else {
      Console.WriteLine("Média das notas: " + Math.Round(m,2) + " , Conceito D");
    }
      
    Console.ReadKey();
      
    } //fim
}