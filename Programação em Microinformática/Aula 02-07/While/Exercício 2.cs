using System;

class Program {
    static void Main(string[] args) {

    int c, i, t;

    Console.WriteLine("Digite dez idades:");

    c = 1;
    t = 0;
    
    while(c <= 10){

    i = Convert.ToInt32(Console.ReadLine());

    if(i > 18){
     t = t + 1;
    }

    c++;
      
    } 

    Console.WriteLine("O total de pessoas com idade superior a 18 anos é: " + t);

    Console.ReadKey();

    }
}