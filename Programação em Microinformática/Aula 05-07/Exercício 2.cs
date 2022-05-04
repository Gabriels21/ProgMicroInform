// Exercício 2

 using System;

class Program {
  
    static void mold() {  

    int c;
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Blue;
    c = 2;
    Console.SetCursorPosition(5,c);
    
    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
      
    for(c = 3; c <= 13; c++){
      Console.SetCursorPosition(5,c);
      
      Console.WriteLine("▓                                                    ▓");
    }
    Console.SetCursorPosition(5,c);
    
    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
      
    } 

    static double conta1(double l1, double l2) {  
    double r = l1 + l2;
    return r;
    } 

    static double conta2(double l2, double l3) {  
    double r = l2 + l3;
    return r;
    } 

    static double conta3(double l1, double l3) {  
    double r = l1 + l3;
    return r;
    } 

    static void Main(string[] args) {  //inicio

    mold();

    double a, b, c, resultado1, resultado2, resultado3;

    Console.ForegroundColor = ConsoleColor.White;
      
    Console.SetCursorPosition(7,5);
    Console.Write("Digite o primeiro lado do triângulo: ");
    a = Convert.ToDouble(Console.ReadLine());

    Console.SetCursorPosition(7,7);
    Console.Write("Digite o segundo lado do triângulo: ");
    b = Convert.ToDouble(Console.ReadLine());

    Console.SetCursorPosition(7,9);
    Console.Write("Digite o terceiro lado do triângulo: ");
    c = Convert.ToDouble(Console.ReadLine());

    resultado1 = conta1(a,b);

    resultado2 = conta2(b,c);

    resultado3 = conta3(a,c);

    if((resultado1 > c) && (resultado2 > a) && (resultado3 > b)) {
      Console.SetCursorPosition(7,11);
      Console.WriteLine("É um triângulo");
    }else{
      Console.SetCursorPosition(7,11);
      Console.WriteLine("Não é um triângulo");
    }
      
  
    Console.ReadKey();
      
    } //fim
  
}