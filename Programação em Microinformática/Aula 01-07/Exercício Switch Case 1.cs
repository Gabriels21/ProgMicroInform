using System;

class Program {
    static void Main(string[] args) { //inicio

    int op;

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
    Console.WriteLine("╚══════════════════════════════════════════════════════════╝");
      

    Console.SetCursorPosition(10,5);
    Console.WriteLine("Escolha uma das fórmulas abaixo:");

    Console.SetCursorPosition(10,7);
    Console.WriteLine("1-Bhaskara");
    Console.SetCursorPosition(10,9);
    Console.WriteLine("2-Força");
    Console.SetCursorPosition(10,11);
    Console.WriteLine("3-Velocidade");

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
    Console.WriteLine("║                                                          ║");

    Console.SetCursorPosition(2,15);
    Console.WriteLine("║                                                          ║");

    Console.SetCursorPosition(2,16);
    Console.WriteLine("║                                                          ║");
        
    Console.SetCursorPosition(2,17);
    Console.WriteLine("╚══════════════════════════════════════════════════════════╝");

    double a, b, b_q, c, delta, r_d, x1, x2;
    
    Console.SetCursorPosition(15,5);
    Console.WriteLine("Digite o primeiro número:");
    Console.SetCursorPosition(41,5);
    a = Convert.ToDouble(Console.ReadLine());

    Console.SetCursorPosition(15,7);
    Console.WriteLine("Digite o segundo número:");
    Console.SetCursorPosition(40,7);
    b = Convert.ToDouble(Console.ReadLine());

    Console.SetCursorPosition(15,9);
    Console.WriteLine("Digite o terceiro número:");
    Console.SetCursorPosition(41,9);
    c = Convert.ToDouble(Console.ReadLine());

    b_q = Math.Pow(b,2);
    delta = b_q - 4 * a * c;
    r_d = Math.Sqrt(delta);
    x1 = (-b - r_d) / (2*a);
    x2 = (-b + r_d) / (2*a);

    Console.SetCursorPosition(15,12);
    Console.WriteLine("O resultado de x1 é: " + x1);
    Console.SetCursorPosition(15,14);
    Console.WriteLine("O resultado de x2 é: " + x2);
        
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

    double f, m, acele;

    Console.SetCursorPosition(22,5);
    Console.WriteLine("Digite a massa:");
    Console.SetCursorPosition(38,5);
    m = Convert.ToDouble(Console.ReadLine());

    Console.SetCursorPosition(20,7);
    Console.WriteLine("Digite a aceleração:");
    Console.SetCursorPosition(41,7);
    acele = Convert.ToDouble(Console.ReadLine());

    f = m * acele;

    Console.SetCursorPosition(22,10);
    Console.WriteLine("Força igual a: " + f);

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
    Console.WriteLine("║                                                          ║");
      
    Console.SetCursorPosition(2,15);
    Console.WriteLine("╚══════════════════════════════════════════════════════════╝");

    double v, vo, aceleracao, t;

    Console.SetCursorPosition(12,5);
    Console.WriteLine("Digite a velocidade inicial:");
    Console.SetCursorPosition(41,5);
    vo = Convert.ToDouble(Console.ReadLine());

    Console.SetCursorPosition(12,7);
    Console.WriteLine("Digite a aceleração:");
    Console.SetCursorPosition(33,7);
    aceleracao = Convert.ToDouble(Console.ReadLine());

    Console.SetCursorPosition(12,9);
    Console.WriteLine("Digite o tempo:");
    Console.SetCursorPosition(28,9);
    t = Convert.ToDouble(Console.ReadLine()); 

    v = vo + aceleracao * t;

    Console.SetCursorPosition(22,12);
    Console.WriteLine("A velocidade é: " + v);

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