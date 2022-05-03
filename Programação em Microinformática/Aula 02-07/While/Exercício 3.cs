using System;

class Program {
    static void Main(string[] args) {

    int c, n, t;

    Console.WriteLine("Digite dez números:");

    c = 1;
    t = 0;
    
    while(c <= 10){

    n = Convert.ToInt32(Console.ReadLine());

    if(n < 0){
      t = t + 1;
    }

    c++;
      
    } 
  
    Console.WriteLine("O total de números negativos que foi digitado é: " + t);

    Console.ReadKey();

    }
}