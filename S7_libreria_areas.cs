public class S7_libreria_areas
{
    public static double AreaCirculo(double radio)
    {
        return Math.PI * Math.Pow(radio, 2);
    }

    public static double AreaRectangulo(double baseRectangulo, double altura)
    {
        return baseRectangulo * altura;
    }

    public static double AreaTriangulo(double baseTriangulo, double altura)
    {
        return (baseTriangulo * altura) / 2;
    }
}