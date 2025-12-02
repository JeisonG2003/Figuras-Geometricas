// Ejecución y ejemplo de uso de las clases.
class Program
{
    static void Main(string[] args)
    {
        Rectangulo rect = new Rectangulo(4.0, 6.0);
        Circulo circ = new Circulo(5.0);

        Console.WriteLine("Área del rectángulo: " + rect.CalcularArea());
        Console.WriteLine("Perímetro del rectángulo: " + rect.CalcularPerimetro());

        Console.WriteLine("Área del círculo: " + circ.CalcularArea());
        Console.WriteLine("Perímetro del círculo: " + circ.CalcularPerimetro());
    }
}