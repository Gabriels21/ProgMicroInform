using System;

class Program {
    static void Main(string[] args) {

    int i, f;

    Console.Write("Digite o número inicial: ");
    i = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite o número final: ");
    f = Convert.ToInt32(Console.ReadLine());

    if(i < f){
      
    while(i <= f){

    Console.WriteLine(i);
    i++;
      
    }

     }

    else{
      Console.WriteLine("O número inicial tem que ser menor que o número final");
    }

    Console.ReadKey();

    }
}