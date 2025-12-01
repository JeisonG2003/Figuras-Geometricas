// Clase que representa un rectángulo y guarda su ancho y alto.
public class Rectangulo
{
    private double ancho; // Ancho del rectángulo
    private double alto;  // Alto del rectángulo

    // Constructor: recibe las medidas del rectángulo.
    public Rectangulo(double ancho, double alto)
    {
        this.ancho = ancho;
        this.alto = alto;
    }

    // Calcula el área multiplicando ancho por alto.
    public double CalcularArea()
    {
        return ancho * alto;
    }

    // Calcula el perímetro sumando todos los lados.
    public double CalcularPerimetro()
    {
        return 2 * (ancho + alto);
    }
}
