namespace HerenciaEnPOO
{
  public abstract class Figura()
  {
    public abstract double CalcularArea();
    public abstract double CalcularPerimetro();
  }

  public class Circulo(double radio) : Figura
  {
    public double Radio { get; set; } = radio;

    public override double CalcularArea()
    {
      return Math.PI * Radio * Radio;
    }

    public override double CalcularPerimetro()
    {
      return 2 * Math.PI * Radio;
    }
  }

  public class Rectangulo(double baseRect, double altura) : Figura
  {
    public double Base { get; set; } = baseRect;
    public double Altura { get; set; } = altura;

    public override double CalcularArea()
    {
      return Base * Altura;
    }

    public override double CalcularPerimetro()
    {
      return 2 * (Base + Altura);
    }
  }

  public class TrianguloRectangulo(double baseTri, double altura) : Figura
  {
    public double Base { get; set; } = baseTri;
    public double Altura { get; set; } = altura;

    public override double CalcularArea()
    {
      return Base * Altura / 2;
    }

    public override double CalcularPerimetro()
    {
      double hipotenusa = Math.Sqrt((Base * Base) + (Altura * Altura));
      return Base + Altura + hipotenusa;
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      bool salir = false;

      while (!salir)
      {
        Console.WriteLine("");
        Console.WriteLine("===== MENÚ =====");
        Console.WriteLine("1. Círculo");
        Console.WriteLine("2. Rectángulo");
        Console.WriteLine("3. Triángulo Rectángulo");
        Console.WriteLine("4. Salir");
        Console.Write("Seleccione una opción: ");

        string opcion = Console.ReadLine();

        switch (opcion)
        {
          case "1":
            Console.Write("Ingrese el radio: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            Circulo circulo = new(radio);

            Console.WriteLine($"Área: {circulo.CalcularArea():F2}");
            Console.WriteLine($"Perímetro: {circulo.CalcularPerimetro():F2}");
            break;

          case "2":
            Console.Write("Ingrese la base: ");
            double baseRect = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la altura: ");
            double alturaRect = Convert.ToDouble(Console.ReadLine());

            Rectangulo rect = new(baseRect, alturaRect);

            Console.WriteLine($"Área: {rect.CalcularArea():F2}");
            Console.WriteLine($"Perímetro: {rect.CalcularPerimetro():F2}");
            break;

          case "3":
            Console.Write("Ingrese la base: ");
            double baseTri = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la altura: ");
            double alturaTri = Convert.ToDouble(Console.ReadLine());

            TrianguloRectangulo tri = new(baseTri, alturaTri);

            Console.WriteLine($"Área: {tri.CalcularArea():F2}");
            Console.WriteLine($"Perímetro: {tri.CalcularPerimetro():F2}");
            break;

          case "4":
            salir = true;
            break;

          default:
            Console.WriteLine("Opción inválida.");
            break;
        }
      }
    }
  }

}