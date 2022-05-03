using System;

class Program {
    static void Main(string[] args) { //inicio

    int n, c;

    Console.WriteLine("Digite um número");
    n = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    if(n>0){

    for(c = 1; c <= n; c++){

    Console.WriteLine(c);
      
    }

      }

    else{
      Console.WriteLine("O número digitado precisa ser maior que 0");
    }

    Console.ReadKey();
    
    } //fim
}