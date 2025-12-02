// Clase que modela un rectángulo y almacena sus medidas.
public class Rectangulo
{
    private double ancho;  // Valor del ancho
    private double alto;   // Valor del alto

    // Constructor: permite crear un rectángulo indicando sus dimensiones.
    public Rectangulo(double ancho, double alto)
    {
        this.ancho = ancho;
        this.alto = alto;
    }

    // Método para obtener el área del rectángulo.
    // La fórmula utilizada es: área = ancho × alto.
    public double CalcularArea()
    {
        return ancho * alto;
    }

    // Método que calcula el perímetro.
    // Fórmula: perímetro = 2 × (ancho + alto).
    public double CalcularPerimetro()
    {
        return 2 * (ancho + alto);
    }
}