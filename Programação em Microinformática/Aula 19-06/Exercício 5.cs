using System;

class Program {
    static void Main(string[] args) { //inicio

    string completo, nome, s, se, email;

    int p, p2;

    Console.WriteLine("Digite seu nome completo");
    completo = Console.ReadLine();
      
    p = completo.IndexOf(" ");
    p2 = completo.LastIndexOf(" ");
    nome = completo.Substring(0, p);
    s = completo.Substring(p2);
    se = s.Trim();
    email = nome + "." + se + "@fatec.sp.gov.br";

    Console.WriteLine("Seu Email é: " + email);

    Console.ReadKey();

    }  //fim
}