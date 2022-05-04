using System;

class Program {
  
    static void mold() {  

    int c;
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.BackgroundColor = ConsoleColor.Black;
    c = 2;
    Console.SetCursorPosition(5,c);
    
    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
      
    for(c = 3; c <= 19; c++){
      Console.SetCursorPosition(5,c);
      
      Console.WriteLine("▓                                                    ▓");
    }
    Console.SetCursorPosition(5,c);
    
    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
      
    } 

   static void mold2() {  

    int c;
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.BackgroundColor = ConsoleColor.Black;
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
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.BackgroundColor = ConsoleColor.Black;
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
  
    static void mold4() {  

    int c;
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.BackgroundColor = ConsoleColor.Black;
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
  
    static void Main(string[] args) {  //inicio

    mold();

    int op;

    Console.ForegroundColor = ConsoleColor.Blue;

    Console.SetCursorPosition(10,5);
    Console.WriteLine("Gabriel dos Santos Santana 1° ADS");

    Console.SetCursorPosition(10,8);
    Console.WriteLine("Escolha uma das fórmulas abaixo:");

    Console.SetCursorPosition(10,10);
    Console.WriteLine("1-Resistência Elétrica");
    Console.SetCursorPosition(10,12);
    Console.WriteLine("2-Volume de um cilindro");
    Console.SetCursorPosition(10,14);
    Console.WriteLine("3-Resistência em paralelo");

    Console.SetCursorPosition(10,17);
    Console.Write("Digite a opção que você escolheu [ ]");

    Console.SetCursorPosition(44,17);
    op = Convert.ToInt32(Console.ReadLine());

    Console.Clear();
      
    switch(op) {

      case 1:

    double r, p, l, area;
        
    mold3();

    Console.SetCursorPosition(7,5);
    Console.Write("Digite a resistividade do condutor: ");
    p = Convert.ToDouble(Console.ReadLine());

    Console.SetCursorPosition(7,7);
    Console.Write("Digite o comprimento: ");
    l = Convert.ToDouble(Console.ReadLine());

    Console.SetCursorPosition(7,9);
    Console.Write("Digite a área: ");
    area = Convert.ToDouble(Console.ReadLine());

    r = (p * l) / area;

    Console.SetCursorPosition(7,11);
    Console.WriteLine("A resistência é: " + Math.Round(r,2 ) + " ohms");

      break;

    case 2:

    mold2();

    double v, raio, raioq, h;

    Console.SetCursorPosition(7,5);
    Console.Write("Digite o raio: ");
    raio = Convert.ToDouble(Console.ReadLine());

    Console.SetCursorPosition(7,7);
    Console.Write("Digite a altura: ");
    h = Convert.ToDouble(Console.ReadLine());

    raioq = Math.Pow(raio,2);
    v = Math.PI * raioq * h;

    Console.SetCursorPosition(7,9);
    Console.WriteLine("O volume do cilindro é igual a: " + Math.Round(v,2) + " m³");


      break;

      case 3:

    mold3();

    double req, r1, r2, r3; 

    Console.SetCursorPosition(7,5);
    Console.Write("Digite o primeiro resistor: ");
    r1 = Convert.ToDouble(Console.ReadLine());

    Console.SetCursorPosition(7,7);
    Console.Write("Digite o segundo resistor: ");
    r2 = Convert.ToDouble(Console.ReadLine());

    Console.SetCursorPosition(7,9);
    Console.Write("Digite o terceiro resistor: ");
    r3 = Convert.ToDouble(Console.ReadLine()); 

    req = ( 1 / (1 / r1 + 1 / r2 + 1 / r3) );

    Console.SetCursorPosition(7,11);
    Console.WriteLine("A resistência em paralelo é: " + Math.Round(req,2) + " ohms");

      break;

      default:

      mold4();

      Console.SetCursorPosition(24,5);
      Console.WriteLine("Opção inválida");

      break;

    }
    
    Console.ReadKey();
      
    } //fim
  
}