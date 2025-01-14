namespace BrasilDevKit.Ferramentas.Matematica.Area;

// Implementação de uma forma geométrica específica: Elipse
public class Elipse(double semiEixoMaior, double semiEixoMenor) : IFormaGeometrica
{
    public double SemiEixoMaior { get; } = semiEixoMaior;
    public double SemiEixoMenor { get; } = semiEixoMenor;

    public double CalcularArea()
    {
        return Math.PI * SemiEixoMaior * SemiEixoMenor;
    }

    /// <summary>
    /// Cálculo aproximado do perímetro de uma elipse.
    /// </summary>
    /// <remarks>
    /// Referência: <see href="https://www.omnicalculator.com/pt/matematica/calculadora-perimetro#formula-do-perimetro-de-uma-elipse"/> 
    /// </remarks>
    /// <returns></returns>
    public double CalcularPerimetro()
    {
        double a = SemiEixoMenor;
        double b = SemiEixoMaior;

        double h = Math.Pow(a - b, 2) / Math.Pow(a + b, 2);
        return Math.PI * (a + b) * ((1 + (3 * h)) / (10 + Math.Sqrt(4 - (3 * h))));
    }
}

