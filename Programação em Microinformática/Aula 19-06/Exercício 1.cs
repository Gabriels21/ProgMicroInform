using System;

class Program {
    static void Main(string[] args) { //inicio

    double r, r_q, area , diametro, perimetro;

    Console.WriteLine("Digite o raio do círculo");
    r = Convert.ToDouble(Console.ReadLine());

    r_q = Math.Pow(r, 2);
    area = Math.PI * r_q;
    diametro = 2 * r;
    perimetro = 2 * Math.PI * r;

    Console.WriteLine("A área do círculo é: " + Math.Round(area, 2));
    Console.WriteLine("O diâmetro do círculo é: " + diametro);
    Console.WriteLine("O perimêtro do círculo é: " + Math.Round(perimetro, 2));
      
    Console.ReadKey();
      
    } //fim
}