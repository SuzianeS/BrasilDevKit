namespace BrasilDevKit.Ferramentas.Matematica.Area;

public class Circulo(double raio) : IFormaGeometrica
{
    public double Raio { get; } = raio;

    public double CalcularArea()
    {
        return Math.PI * Math.Pow(Raio, 2);
    }

    public double CalcularPerimetro()
    {
        return 2 * Math.PI * Raio;
    }
}
