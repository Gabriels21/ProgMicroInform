using System;

class Program {
    static void Main(string[] args) { //inicio

    int c, maior, menor;
      
    Console.WriteLine("Digite vinte números");

    maior = 0;
    menor = 0;
    bool flag = false;
    
    for(c = 1; c <= 20; c++){

    int n;

    n = Convert.ToInt32(Console.ReadLine());

    if(flag == false){
      maior = n;
      menor = n;
      flag = true;
    }

    if(n > maior){
      maior = n;
    }

    if(n < menor){
      menor = n;
    }

     }
 
    Console.WriteLine("O maior número digitado foi: " + maior);
    Console.WriteLine("O menor número digitado foi: " + menor);

    Console.ReadKey();
    
    } //fim
}