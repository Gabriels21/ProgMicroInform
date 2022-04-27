using System;

class Program {
    static void Main(string[] args) { //inicio

    string completo, nome, s, se, nm, t;

    Console.WriteLine("Digite seu nome completo");
    completo = Console.ReadLine();
      
    int  p = completo.IndexOf(" ");
    nome = completo.Substring(0, p);
    s = completo.Substring(p);
    se = s.Trim();
    nm = completo.Substring(5,10);
    t = completo.Replace("a", "o");

    Console.WriteLine("Seu nome é: " + nome);
    Console.WriteLine("Seu sobrenome é: " + se);
    Console.WriteLine("A parte quebrada do nome de 5 até o 10 é: " + nm);
    Console.WriteLine("Trocando o por a: " + t);

    Console.ReadKey();
      
    } //fim
}