using System;

class Program {
    static void Main(string[] args) { //inicio

    double v;

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

    Console.SetCursorPosition(5,5);
    Console.WriteLine("Digite o valor das suas vendas neste mês R$: ");
    Console.SetCursorPosition(50,5);
    v = Convert.ToDouble(Console.ReadLine());
      
    Console.SetCursorPosition(5,7);
    if(v < 1000) {
     Console.WriteLine("Você não ganhou nenhum prêmio, pois não atingiu a meta");
    }

    else if((v >= 1000) && (v < 3000)){
      Console.WriteLine("Você ganhou um prêmio de R$ 150,00 por atingir a meta");
    }

    else {
      Console.WriteLine("Você ganhou um prêmio de R$ 300,00 por atingir a meta");
    }
      
    Console.ReadKey();
      
    } //fim
}