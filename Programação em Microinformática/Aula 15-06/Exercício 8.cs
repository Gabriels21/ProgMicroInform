using System;

class Program {
    static void Main(string[] args) { //inicio

        string nome;
        double n1, n2, n3, media;

        Console.WriteLine("Digite o nome do aluno(a):");
        nome = Console.ReadLine();
      
        Console.WriteLine("Digite a primeria nota de " + nome + ":");
        n1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a segunda nota de " + nome + ":");
        n2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a terceira nota de " + nome + ":");
        n3 = Convert.ToDouble(Console.ReadLine());
  
        media = ((n1 * 2) + (n2 * 3) + (n3 * 5)) / 10;

        Console.WriteLine("A média das notas de " + nome + " foi: "  + media);
       
        Console.ReadKey();

    } //fim
}