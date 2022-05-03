using System;

class Program {
    static void Main(string[] args) {

    int c, n;

    n = 1;

    while(n <=10){
      Console.Write(n + ", ");
      c = 1;
    
    while(c <= 10){

    Console.Write(" " + c);
    c++;
      
    } 

    Console.WriteLine("");
    n++;
      
    }

    Console.ReadKey();

    }