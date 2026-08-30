bool continuar = true;
while (continuar)
{
   
Console.WriteLine("CALCULADORA");

Console.WriteLine("0. Salir"); 
Console.WriteLine("1. Suma");
Console.WriteLine("2. Restar");
Console.WriteLine("3. Multiplicar");
Console.WriteLine("4. Dividir");
Console.WriteLine("5. Potencia");
Console.WriteLine("6. Raiz cuadrada");
Console.WriteLine("7. Factorial");
Console.WriteLine("8. Logaritmo");
Console.WriteLine("9. Seno");
Console.WriteLine("10. Coseno");
Console.WriteLine("11. Tangente");

Console.Write("Selecciona una operacion: ");
int opcion = int.Parse(Console.ReadLine());

Calculadora calculadora = new Calculadora();

switch (opcion)
{
    case 0:
        continuar = false;
    break;

    case 1:
        Console.Write("Dame el primer numero: ");
        double numero1 = double.Parse(Console.ReadLine());

        Console.Write("Dame el segundo numero: ");
        double numero2 = double.Parse(Console.ReadLine());

        Console.WriteLine(
            $"Resultado: {calculadora.Sumar(numero1, numero2)}"
        );
        break;

    case 2:
        Console.Write("Dame el primer numero: ");
        numero1 = double.Parse(Console.ReadLine());

        Console.Write("Dame el segundo numero: ");
        numero2 = double.Parse(Console.ReadLine());

        Console.WriteLine(
            $"Resultado: {calculadora.Restar(numero1, numero2)}"
        );
        break;

    case 3:
        Console.Write("Dame el primer numero: ");
        numero1 = double.Parse(Console.ReadLine());

        Console.Write("Dame el segundo numero: ");
        numero2 = double.Parse(Console.ReadLine());

        Console.WriteLine(
            $"Resultado: {calculadora.Multiplicar(numero1, numero2)}"
        );
        break;

    case 4:
        Console.Write("Dame el primer numero: ");
        numero1 = double.Parse(Console.ReadLine());

        Console.Write("Dame el segundo numero: ");
        numero2 = double.Parse(Console.ReadLine());

        Console.WriteLine(
            $"Resultado: {calculadora.Dividir(numero1, numero2)}"
        );
        break;

    case 5:
        Console.Write("Dame la base: ");
        numero1 = double.Parse(Console.ReadLine());

        Console.Write("Dame el exponete: ");
        numero2 = double.Parse(Console.ReadLine());

        Console.WriteLine(
            $"Resultado: {calculadora.Potencia(numero1, numero2)}"
        );
        break;

    case 6:
        Console.Write("Dame un numero: ");
        numero1 = double.Parse(Console.ReadLine());

        Console.WriteLine(
            $"Resultado: {calculadora.Raizcuadrada(numero1)}"
        );
        break;

    case 7:
    Console.Write("Dame un numero: ");
    int numeroFactorial = int.Parse(Console.ReadLine());

    Console.WriteLine(
        $"Resultado: {calculadora.Factorial(numeroFactorial)}"
    );
        break;

    case 8:
        Console.Write("Dame un numero: ");
        double numeroLogaritmo = double.Parse(Console.ReadLine());

        Console.WriteLine(
            $"Resultado: {calculadora.Logaritmo(numeroLogaritmo)}"
        );
        break;

    case 9:
        Console.Write("Dame un numero: ");
        double radianes = double.Parse(Console.ReadLine());

        Console.WriteLine(
            $"Resultado: {calculadora.Seno(radianes)}"
        );
        break;

    case 10:
        Console.Write("Dame un numero: ");
        double radianes1 = double.Parse(Console.ReadLine());

        Console.WriteLine(
            $"Resultado: {calculadora.Coseno(radianes1)}"
        );
        break;     

    case 11:
        Console.Write("Dame un numero: ");
        double radianes2 = double.Parse(Console.ReadLine());

        Console.WriteLine(
            $"Resultado: {calculadora.Tangente(radianes2)}"
        );
        break;           

    default:
        Console.WriteLine("Opcion no valida.");
        break;
}
if(continuar)
{
Console.Write("¿Deseas continuar? " + "(si/no): ");
string respuesta = Console.ReadLine();


if (respuesta == "no")
    {
        continuar = false;
    }
}
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

//Potencia    

    public double Potencia(double a, double b)
    {
        return Math.Pow(a, b);
    }

//Raiz cuadrada
    public double Raizcuadrada(double a)
    {
        if (a < 0)
        {
            throw new Exception("No existe raiz de numero negativo");
        }

        return Math.Sqrt(a);
    }

//Factorial    
    public long Factorial (int a)
    {
        if (a < 0)
        {
        throw new Exception("No existe Factorial negativo");
        }
        long resultado = 1;
        for (int i = 1; i <= a; i++)
        {
            resultado = resultado * i;
        }
       return resultado;
    }

//logaritmo
    public double Logaritmo (double a)
    {
        if (a <= 0)
        {
            throw new Exception ("No existe el numero negativo");
        }
        return Math.Log10 (a);
    }

//Trigonometria
    public double Seno (double grados)
    {
        double radianes = grados * Math.PI / 180;
        return Math.Sin(radianes);
    }
        public double Coseno (double grados)
    {
        double radianes = grados * Math.PI / 180;
        return Math.Cos(radianes);
    }
        public double Tangente (double grados)
    {
        double radianes = grados * Math.PI / 180;
        return Math.Tan(radianes);
    } 


}