using System;

class Cuadrado
{
    // Atributo privado para el lado del cuadrado
    private double lado;

    // Constructor para inicializar el lado
    public Cuadrado(double lado)
    {
        this.lado = lado;
    }

    // Propiedad para acceder y modificar el lado
    public double Lado
    {
        get { return lado; }
        set { lado = value; }
    }

    // Método para calcular el área del cuadrado
    public double CalcularArea()
    {
        return lado * lado;
    }

    // Método para calcular el perímetro del cuadrado
    public double CalcularPerimetro()
    {
        return 4 * lado;
    }
}

class Triangulo
{
    // Atributos privados para la base y la altura del triángulo
    private double baseTriangulo;
    private double altura;

    // Constructor para inicializar la base y la altura
    public Triangulo(double baseTriangulo, double altura)
    {
        this.baseTriangulo = baseTriangulo;
        this.altura = altura;
    }

    // Propiedades para acceder y modificar la base y la altura
    public double BaseTriangulo
    {
        get { return baseTriangulo; }
        set { baseTriangulo = value; }
    }

    public double Altura
    {
        get { return altura; }
        set { altura = value; }
    }

    // Método para calcular el área del triángulo
    public double CalcularArea()
    {
        return (baseTriangulo * altura) / 2;
    }

    // Método para calcular el perímetro del triángulo
    // Asumimos que es un triángulo equilátero para simplificación
    public double CalcularPerimetro()
    {
        return 3 * baseTriangulo; // Si es equilátero
    }
}

class Program
{
    static void Main()
    {
        // Crear un objeto de tipo Cuadrado
        Cuadrado cuadrado = new Cuadrado(5);
        Console.WriteLine("Área del Cuadrado: " + cuadrado.CalcularArea());
        Console.WriteLine("Perímetro del Cuadrado: " + cuadrado.CalcularPerimetro());

        // Crear un objeto de tipo Triángulo
        Triangulo triangulo = new Triangulo(6, 8);
        Console.WriteLine("Área del Triángulo: " + triangulo.CalcularArea());
        Console.WriteLine("Perímetro del Triángulo (equilátero): " + triangulo.CalcularPerimetro());
    }
}
