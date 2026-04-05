using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        int edad;
        Console.WriteLine("Ingrese tu edad: ");
        edad = Convert.ToInt32(Console.ReadLine());
        if (edad >= 18)
        {
            Console.WriteLine("Eres mayor de edad");
        }
        else
        {
            Console.WriteLine("Eres menor de edad");
        }
    }
}