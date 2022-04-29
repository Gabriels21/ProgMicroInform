using System;

class Program {
    static void Main(string[] args) { //inicio

    string nome;
    double quant, p, desc, total1, total2;

    Console.BackgroundColor = ConsoleColor.Blue;
    Console.Clear();

    Console.ForegroundColor = ConsoleColor.White;

    Console.SetCursorPosition(2,2);
    Console.WriteLine("╔═══════════════════════════════════════════════════════════╗  ");

    Console.SetCursorPosition(2,3);
    Console.WriteLine("║                                                           ║");

    Console.SetCursorPosition(2,4);
    Console.WriteLine("║                                                           ║");

    Console.SetCursorPosition(2,5);
    Console.WriteLine("║                                                           ║");

    Console.SetCursorPosition(2,6);
    Console.WriteLine("║                                                           ║");

    Console.SetCursorPosition(2,7);
    Console.WriteLine("║                                                           ║");

    Console.SetCursorPosition(2,8);
    Console.WriteLine("║                                                           ║");

    Console.SetCursorPosition(2,9);
    Console.WriteLine("║                                                           ║");

    Console.SetCursorPosition(2,10);
    Console.WriteLine("║                                                           ║");

    Console.SetCursorPosition(2,11);
    Console.WriteLine("║                                                           ║");

    Console.SetCursorPosition(2,12);
    Console.WriteLine("║                                                           ║");

    Console.SetCursorPosition(2,13);
    Console.WriteLine("║                                                           ║");

    Console.SetCursorPosition(2,14);
    Console.WriteLine("║                                                           ║");

    Console.SetCursorPosition(2,15);
    Console.WriteLine("║                                                           ║");

    Console.SetCursorPosition(2,16);
    Console.WriteLine("║                                                           ║");

    Console.SetCursorPosition(2,17);
    Console.WriteLine("║                                                           ║");

    Console.SetCursorPosition(2,18);
    Console.WriteLine("║                                                           ║");
    
    Console.SetCursorPosition(2,19);
    Console.WriteLine("╚═══════════════════════════════════════════════════════════╝");

    Console.SetCursorPosition(9,5);
    Console.WriteLine("Digite o nome do produto:");
    Console.SetCursorPosition(35,5);
    nome =Console.ReadLine();

    Console.SetCursorPosition(9,7);
    Console.WriteLine("Digite a quantidade adquirida:");
    Console.SetCursorPosition(40,7);
    quant = Convert.ToDouble(Console.ReadLine());

    Console.SetCursorPosition(9,9);
    Console.WriteLine("Digite o valor unitário do(a) " + nome + " R$:" );
    Console.SetCursorPosition(49,9);
    p = Convert.ToDouble(Console.ReadLine());

    if (quant <= 5){
      total1 = quant * p;
      desc = (total1 / 100) * 2;
      total2 = total1 - desc;
      Console.SetCursorPosition(5,12);
      Console.WriteLine("O valor total da compra sem desconto é R$: " + total1 );
      Console.SetCursorPosition(5,14);
      Console.WriteLine("O valor de desconto dessa compra é de 2%");
      Console.SetCursorPosition(5,16);
      Console.WriteLine("O valor total da compra com o desconto de 2% é R$: " + total2 );
    }
     
     else if ((quant > 5) && (quant <= 10)){
      total1 = quant * p;
      desc = (total1 / 100) * 3;
      total2 = total1 - desc;
      Console.SetCursorPosition(4,12);
      Console.WriteLine("O valor total da compra sem desconto é R$: " + total1 );
      Console.SetCursorPosition(4,14);
      Console.WriteLine("O valor de desconto dessa compra é de 3%");
      Console.SetCursorPosition(4,16);
      Console.WriteLine("O valor total da compra com o desconto de 3% é R$: " + total2 );
    }

    else {
      total1 = quant * p;
      desc = (total1 / 100) * 5;
      total2 = total1 - desc;
      Console.SetCursorPosition(4,12);
      Console.WriteLine("O valor total da compra sem desconto é R$: " + total1 );
      Console.SetCursorPosition(4,14);
      Console.WriteLine("O valor de desconto dessa compra é de 5%");
      Console.SetCursorPosition(4,16);
      Console.WriteLine("O valor total da compra com o desconto de 5% é R$: " + total2 );
    }
      
    Console.ReadKey();
      
    } //fim
}