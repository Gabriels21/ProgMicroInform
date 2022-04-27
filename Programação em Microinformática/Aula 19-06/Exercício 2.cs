using System;

class Program { 
    static void Main(string[] args) {  //inicio

    double a, b, b_q, c, delta, r_d, x1, x2;

    Console.WriteLine("Digite o primeiro número");
    a = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Digite o segundo número");
    b = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Digite o terceiro número");
    c = Convert.ToDouble(Console.ReadLine());

    b_q = Math.Pow(b,2);
    delta = b_q - 4 * a * c;
    r_d = Math.Sqrt(delta);
    x1 = (-b - r_d) / (2*a);
    x2 = (-b + r_d) / (2*a);

    Console.WriteLine("O resultado de x1 é: " + x1);
    Console.WriteLine("O resultado de x2 é: " + x2);

    Console.ReadKey();
      
    }  //fim
}