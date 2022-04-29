using System;

class Program {
    static void Main(string[] args) { //inicio

    int op;
    double reajuste;

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
    Console.WriteLine("╚══════════════════════════════════════════════════════════╝");
      
    Console.SetCursorPosition(10,5);
    Console.WriteLine("Escolha uma das opções de cargo abaixo:");

    Console.SetCursorPosition(10,7);
    Console.WriteLine("1-Gerente  10% de aumento");
    Console.SetCursorPosition(10,9);
    Console.WriteLine("2-Analista  20% de aumento");
    Console.SetCursorPosition(10,11);
    Console.WriteLine("3-Técnico  30% de aumento");

    Console.SetCursorPosition(10,13);
    Console.Write("Digite a opção que você escolheu [ ]");

    Console.SetCursorPosition(44,13);
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
    Console.WriteLine("║                                                          ║");
        
    Console.SetCursorPosition(2,14);
    Console.WriteLine("╚══════════════════════════════════════════════════════════╝");

    double salario, sl, salarion;

    Console.SetCursorPosition(12,5);
    Console.WriteLine("Digite o seu salário:");
    Console.SetCursorPosition(34,5);
    salario = Convert.ToDouble(Console.ReadLine());

    sl = (salario / 100) * 10;
    salarion = salario + sl;
    reajuste = salarion - salario;

    Console.SetCursorPosition(12,7);
    Console.WriteLine("Seu salário antigo era R$: " + salario);
    Console.SetCursorPosition(12,9);
    Console.WriteLine("Seu novo salário é R$: " + salarion);
    Console.SetCursorPosition(12,11);
    Console.WriteLine("Você está ganhando R$ " + reajuste + " a mais que antes");
        
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
    Console.WriteLine("║                                                          ║");
        
    Console.SetCursorPosition(2,14);
    Console.WriteLine("╚══════════════════════════════════════════════════════════╝");

    double salario2, sl2, salarion2;
        
    Console.SetCursorPosition(12,5);
    Console.WriteLine("Digite o seu salário:");
    Console.SetCursorPosition(34,5);
    salario2 = Convert.ToDouble(Console.ReadLine());

    sl2 = (salario2 / 100) * 20;
    salarion2 = salario2 + sl2;
    reajuste = salarion2 - salario2;

    Console.SetCursorPosition(12,7);
    Console.WriteLine("Seu salário antigo era R$: " + salario2);
    Console.SetCursorPosition(12,9);
    Console.WriteLine("Seu novo salário é R$: " + salarion2);
    Console.SetCursorPosition(12,11);
    Console.WriteLine("Você está ganhando R$ " + reajuste + " a mais que antes");

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
    Console.WriteLine("║                                                          ║");
        
    Console.SetCursorPosition(2,14);
    Console.WriteLine("╚══════════════════════════════════════════════════════════╝");
        
    double salario3, sl3, salarion3;
        
    Console.SetCursorPosition(12,5);
    Console.WriteLine("Digite o seu salário:");
    Console.SetCursorPosition(34,5);
    salario3 = Convert.ToDouble(Console.ReadLine());

    sl3 = (salario3 / 100) * 30;
    salarion3 = salario3 + sl3;
    reajuste = salarion3 - salario3;
    
    Console.SetCursorPosition(12,7);
    Console.WriteLine("Seu salário antigo era R$: " + salario3);
    Console.SetCursorPosition(12,9);
    Console.WriteLine("Seu novo salário é R$: " + salarion3);
    Console.SetCursorPosition(12,11);
    Console.WriteLine("Você está ganhando R$ " + reajuste + " a mais que antes");

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
    Console.WriteLine("║                                                          ║");

    Console.SetCursorPosition(2,13);
    Console.WriteLine("║                                                          ║");
        
    Console.SetCursorPosition(2,14);
    Console.WriteLine("╚══════════════════════════════════════════════════════════╝");

    double salario4, sl4, salarion4;
        
    Console.SetCursorPosition(12,5);
    Console.WriteLine("Digite o seu salário:");
    Console.SetCursorPosition(34,5);
    salario4 = Convert.ToDouble(Console.ReadLine());

    sl4 = (salario4 / 100) * 40;
    salarion4 = salario4 + sl4;
    reajuste = salarion4 - salario4;

    Console.SetCursorPosition(12,7);
    Console.WriteLine("Seu salário antigo era R$: " + salario4);
    Console.SetCursorPosition(12,9);
    Console.WriteLine("Seu novo salário é R$: " + salarion4);
    Console.SetCursorPosition(12,11);
    Console.WriteLine("Você está ganhando R$ " + reajuste + " a mais que antes");

      break;

    }

    Console.ReadKey();
      
    } //fim
}