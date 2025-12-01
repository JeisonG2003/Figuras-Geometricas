// Clase que representa un círculo y guarda su radio.
public class Circulo
{
    private double radio; // Valor del radio del círculo

    // Constructor: crea un círculo indicando su radio.
    public Circulo(double radio)
    {
        this.radio = radio;
    }

    // Calcula el área usando π * radio²
    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    // Calcula el perímetro usando 2 * π * radio
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}
