using System;

class Program
{
    static void Main(string[] args)
    {
        Circulo c = new Circulo(5);
        Rectangulo r = new Rectangulo(4, 7);

        Console.WriteLine("Área del círculo: " + c.CalcularArea());
        Console.WriteLine("Perímetro del círculo: " + c.CalcularPerimetro());

        Console.WriteLine("Área del rectángulo: " + r.CalcularArea());
        Console.WriteLine("Perímetro del rectángulo: " + r.CalcularPerimetro());
    }
}
