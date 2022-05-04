// Exercício 1

 using System;

class Program {
  
    static void mold() {  

    int c;
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Blue;
    c = 2;
    Console.SetCursorPosition(5,c);
    
    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
      
    for(c = 3; c <= 17; c++){
      Console.SetCursorPosition(5,c);
      
      Console.WriteLine("▓                                                    ▓");
    }
    Console.SetCursorPosition(5,c);
    
    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
      
    } 

   static void mold2() {  

    int c;
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Blue;
    c = 2;
    Console.SetCursorPosition(5,c);
    
    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
      
    for(c = 3; c <= 11; c++){
      Console.SetCursorPosition(5,c);
      
      Console.WriteLine("▓                                                    ▓");
    }
    Console.SetCursorPosition(5,c);
    
    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
      
    } 
  
    static void mold3() {  

    int c;
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Blue;
    c = 2;
    Console.SetCursorPosition(5,c);
    
    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
      
    for(c = 3; c <= 8; c++){
      Console.SetCursorPosition(5,c);
      
      Console.WriteLine("▓                                                    ▓");
    }
    Console.SetCursorPosition(5,c);
    
    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
      
    } 
  
    static double adicao(double n1, double n2) {  

    double r = n1 + n2;
    return r;
    } 

    static double subtracao(double n1, double n2) {  

    double r = n1 - n2;
    return r;
    } 

    static double multiplicacao(double n1, double n2) {  

    double r = n1 * n2;
    return r;
    } 

    static double divisao(double n1, double n2) {  

    double r = n1 / n2;
    return r;
    } 


    static void Main(string[] args) {  //inicio

    mold();

    int op;
    double a, b, resultado;

    Console.ForegroundColor = ConsoleColor.White;

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

    mold2();
      
    Console.SetCursorPosition(7,5);
    Console.Write("Digite o primeiro número: ");
    a = Convert.ToDouble(Console.ReadLine());

    Console.SetCursorPosition(7,7);
    Console.Write("Digite o segundo número: ");
    b = Convert.ToDouble(Console.ReadLine());

    resultado = adicao(a, b);
      
    Console.SetCursorPosition(7,9);
    Console.WriteLine("O resultado da adição de " + a + " + " + b + " é: " + resultado);

      break;

    case 2:

    mold2();
      
    Console.SetCursorPosition(7,5);
    Console.Write("Digite o primeiro número: ");
    a = Convert.ToDouble(Console.ReadLine());

    Console.SetCursorPosition(7,7);
    Console.Write("Digite o segundo número: ");
    b = Convert.ToDouble(Console.ReadLine());

    resultado = subtracao(a, b);
      
    Console.SetCursorPosition(7,9);
    Console.WriteLine("O resultado da subtração de " + a + " - " + b + " é: " + resultado);

      break;

      case 3:

    mold2();
      
    Console.SetCursorPosition(7,5);
    Console.Write("Digite o primeiro número: ");
    a = Convert.ToDouble(Console.ReadLine());

    Console.SetCursorPosition(7,7);
    Console.Write("Digite o segundo número: ");
    b = Convert.ToDouble(Console.ReadLine());

    resultado = multiplicacao(a, b);
      
    Console.SetCursorPosition(7,9);
    Console.WriteLine("O resultado da multiplicação de " + a + " X " + b + " é: " + Math.Round(resultado,2));

      break;

      case 4:

    mold2();
      
    Console.SetCursorPosition(7,5);
    Console.Write("Digite o primeiro número: ");
    a = Convert.ToDouble(Console.ReadLine());

    Console.SetCursorPosition(7,7);
    Console.Write("Digite o segundo número: ");
    b = Convert.ToDouble(Console.ReadLine());

    resultado = divisao(a, b);
      
    Console.SetCursorPosition(7,9);
    Console.WriteLine("O resultado da divisão de " + a + " / " + b + " é: " + Math.Round(resultado,2));

      break;

      default:

      mold3();

      Console.SetCursorPosition(24,5);
      Console.WriteLine("Opção inválida");

      break;

    }
    
    Console.ReadKey();
      
    } //fim
  
}