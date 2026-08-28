Console.Write (
    "Dame un numero"
);
double numero1 = double.Parse (Console.ReadLine());

Console.Write (
    "Dame un numero"
);
double numero2 = double.Parse (Console.ReadLine());

Calculadora calculadora = new Calculadora();

Console.WriteLine("1. Suma");
Console.WriteLine("2. Restar");
Console.WriteLine("3. Multiplicar");
Console.WriteLine("4. Dividir");
Console.Write ("Selecciona una operacion: ");
int opcion = int.Parse (Console.ReadLine());

switch (opcion)
{
    case 1:
    Console.WriteLine ($"Resultado: {calculadora.Sumar (numero1, numero2)}");
    break;
    case 2:
    Console.WriteLine ($"Resultado: {calculadora.Restar (numero1, numero2)}");
    break;
    case 3:
    Console.WriteLine ($"Resultado: {calculadora.Multiplicar (numero1, numero2)}");
    break;
    case 4:
    Console.WriteLine ($"Resultado: {calculadora.Dividir (numero1, numero2)}");
    break;    
    default:
    Console.WriteLine ("Opcion no validad. ");
    break;
}
class Calculadora
{
    public double Sumar(double a, double b)
    {
        return a + b;
    }

    public double Restar(double a, double b)
    {
        return a - b;
    }

    public double Multiplicar(double a, double b)
    {
        return a * b;
    }

    public double Dividir(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException();
        }

        return a / b;
    }
}