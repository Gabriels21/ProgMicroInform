using System;

class Program {
    static void Main(string[] args) { //inicio

    int c, s;
      
    Console.WriteLine("Digite dez números");
    s = 0;

    for(c=1; c<=10; c++){

    int n;

    n = Convert.ToInt32(Console.ReadLine());

    if(n > 10) {

    s = s + n;
      
    }
   
     }

    Console.WriteLine("O resultado da soma dos números maiores que 10 digitados é: " + s);

    Console.ReadKey();
    
    } //fim
}