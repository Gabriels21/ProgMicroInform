using System;

class Program {
    static void Main(string[] args) {  //inicio

    double n1, n2, n3, n4, m;
    string op;

    do{
      Console.Clear();
    do {

    Console.WriteLine("Digite a primeira nota");
    n1 = Convert.ToInt32(Console.ReadLine());

    } while (n1 < 0 || n1 > 10);
    Console.WriteLine("Primeira nota: " + n1);

    do {

    Console.WriteLine("Digite a segunda nota");
    n2 = Convert.ToInt32(Console.ReadLine());

    } while (n2 < 0 || n2 > 10);
    Console.WriteLine("Segunda nota: " + n2);

    do {

    Console.WriteLine("Digite a terceira nota");
    n3 = Convert.ToInt32(Console.ReadLine());

    } while (n3 < 0 || n3 > 10);
    Console.WriteLine("Terceira nota: " + n3);

    do {

    Console.WriteLine("Digite a quarta nota");
    n4 = Convert.ToInt32(Console.ReadLine());

    } while (n4 < 0 || n4 > 10);
    Console.WriteLine("Quarta nota: " + n4);

    m = (n1 + n2 + n3 + n4) / 4;
      
    Console.WriteLine("A média das notas é: " + m);

    Console.WriteLine("Digite 'sim' para continuar");
    op = Console.ReadLine();

    op = op.ToLower();
      
    } while(op == "sim");

    Console.ReadKey();
      
    } //fim
}