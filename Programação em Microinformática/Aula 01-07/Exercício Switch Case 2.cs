using System;

class Program {
    static void Main(string[] args) { //inicio

    int op;
    double n1, n2, adicao, sub, multi, divisao;

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
    Console.WriteLine("║                                                          ║");

    Console.SetCursorPosition(2,13);
    Console.WriteLine("║                                                          ║");

    Console.SetCursorPosition(2,14);
    Console.WriteLine("║                                                          ║");

    Console.SetCursorPosition(2,15);
    Console.WriteLine("║                                                          ║");

    Console.SetCursorPosition(2,16);
    Console.WriteLine("║                                                          ║");

    Console.SetCursorPosition(2,17);
    Console.WriteLine("║                                                          ║");
  
    Console.SetCursorPosition(2,18);
    Console.WriteLine("╚══════════════════════════════════════════════════════════╝");
     
    Console.SetCursorPosition(10,5);
    Console.WriteLine("Escolha uma das operações abaixo:");

    Console.SetCursorPosition(10,7);
    Console.WriteLine("1-Adição");
    Console.SetCursorPosition(10,9);
    Console.WriteLine("2-Subtração");
    Console.SetCursorPosition(10,11);
    Console.WriteLine("3-Multiplicação");
    Console.SetCursorPosition(10,13);
    Console.WriteLine("4-Divisão");

    Console.SetCursorPosition(10,15);
    Console.Write("Digite a opção que você escolheu [ ]");

    Console.SetCursorPosition(44,15);
    op = Convert.ToInt32(Console.ReadLine());

    Console.Clear();

    switch(op) {

      case 1:

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
    Console.WriteLine("║                                                          ║");
        
    Console.SetCursorPosition(2,13);
    Console.WriteLine("╚══════════════════════════════════════════════════════════╝");

    Console.SetCursorPosition(12,5);
    Console.WriteLine("Digite o primeiro número:");
    Console.SetCursorPosition(38,5);
    n1 = Convert.ToDouble(Console.ReadLine());

    Console.SetCursorPosition(12,7);
    Console.WriteLine("Digite o segundo número:");
    Console.SetCursorPosition(37,7);
    n2 = Convert.ToDouble(Console.ReadLine());

    adicao = n1 + n2;

    Console.SetCursorPosition(12,10);
    Console.WriteLine("O resultado da adição de " + n1 + " + " + n2 + " é: " + adicao);
        
       break;

      case 2:

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
    Console.WriteLine("║                                                          ║");

    Console.SetCursorPosition(2,13);
    Console.WriteLine("╚══════════════════════════════════════════════════════════╝");

    Console.SetCursorPosition(12,5);
    Console.WriteLine("Digite o primeiro número:");
    Console.SetCursorPosition(38,5);
    n1 = Convert.ToDouble(Console.ReadLine());

    Console.SetCursorPosition(12,7);
    Console.WriteLine("Digite o segundo número:");
    Console.SetCursorPosition(37,7);
    n2 = Convert.ToDouble(Console.ReadLine());

    sub = n1 - n2;

    Console.SetCursorPosition(12,10);
    Console.WriteLine("O resultado da subtração de " + n1 + " - " + n2 + " é: " + sub);

      break;

      case 3:

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
    Console.WriteLine("║                                                          ║");
      
    Console.SetCursorPosition(2,13);
    Console.WriteLine("╚══════════════════════════════════════════════════════════╝");

    Console.SetCursorPosition(12,5);
    Console.WriteLine("Digite o primeiro número:");
    Console.SetCursorPosition(38,5);
    n1 = Convert.ToDouble(Console.ReadLine());

    Console.SetCursorPosition(12,7);
    Console.WriteLine("Digite o segundo número:");
    Console.SetCursorPosition(37,7);
    n2 = Convert.ToDouble(Console.ReadLine());

    multi = n1 * n2;

    Console.SetCursorPosition(12,10);
    Console.WriteLine("O resultado da multiplicação de " + n1 + " * " + n2 + " é: " + multi);

      break;

      case 4:

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
    Console.WriteLine("║                                                          ║");
      
    Console.SetCursorPosition(2,13);
    Console.WriteLine("╚══════════════════════════════════════════════════════════╝");

    Console.SetCursorPosition(12,5);
    Console.WriteLine("Digite o primeiro número:");
    Console.SetCursorPosition(38,5);
    n1 = Convert.ToDouble(Console.ReadLine());

    Console.SetCursorPosition(12,7);
    Console.WriteLine("Digite o segundo número:");
    Console.SetCursorPosition(37,7);
    n2 = Convert.ToDouble(Console.ReadLine());

    divisao = n1 / n2;

    Console.SetCursorPosition(12,10);
    Console.WriteLine("O resultado da divisão de " + n1 + " / " + n2 + " é: " + divisao);

      break;

      default:
    
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

      Console.SetCursorPosition(25,7);
      Console.WriteLine("Opção inválida");

      break;

    }

    Console.ReadKey();
      
    } //fim
}