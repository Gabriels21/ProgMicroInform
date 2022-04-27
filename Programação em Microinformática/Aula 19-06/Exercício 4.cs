using System;

class Program {
    static void Main(string[] args) { //inicio

    string completo, nome, email;

    int pos;

    Console.WriteLine("Digite seu nome completo");
    completo = Console.ReadLine();
      
    pos = completo.IndexOf(" ");
    nome = completo.Substring(0, pos);
    email = nome + "@fatec.sp.gov.br";

    Console.WriteLine("Seu Email é: " + email);

    Console.ReadKey();
      
    }  //fim
}