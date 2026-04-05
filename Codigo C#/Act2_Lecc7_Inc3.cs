internal class Program
{
    private static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Seleccione un numero del 1 al 12 >B) ");
        n = Convert.ToInt32(Console.ReadLine());
        if (n == 1) Console.WriteLine("enero");
        if (n == 2) Console.WriteLine("febrero");
        if (n == 3) Console.WriteLine("marzo");
        if (n == 4) Console.WriteLine("abril");
        if (n == 5) Console.WriteLine("mayo");
        if (n == 6) Console.WriteLine("junio");
        if (n == 7) Console.WriteLine("julio");
        if (n == 8) Console.WriteLine("agosto");
        if (n == 9) Console.WriteLine("septiembre");
        if (n == 10) Console.WriteLine("octubre");
        if (n == 11) Console.WriteLine("noviembre");
        if (n == 12) Console.WriteLine("diciembre");
    }
}