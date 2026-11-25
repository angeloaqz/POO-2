namespace BibliotecaCalculo;

public class CalculadoraGeometria
{
    public double AreaRetangulo(double base_, double altura)
    {
        return base_ * altura;
    }

    public double AreaCirculo(double raio)
    {
        return Math.PI * raio * raio;
    }

    public double AreaTriangulo(double base_, double altura)
    {
        return base_ * altura / 2;
    }
}
