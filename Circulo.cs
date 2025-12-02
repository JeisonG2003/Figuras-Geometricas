// Clase que modela un círculo y guarda su radio.
public class Circulo
{
    private double radio;  // Valor del radio del círculo

    // Constructor: recibe el radio y lo asigna al objeto.
    public Circulo(double radio)
    {
        this.radio = radio;
    }

    // Método que calcula el área aplicando la expresión: π × radio².
    public double CalcularArea()
    {
        return Math.PI * Math.Pow(radio, 2);
    }

    // Método para obtener el perímetro o circunferencia.
    // Fórmula: perímetro = 2 × π × radio.
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}
