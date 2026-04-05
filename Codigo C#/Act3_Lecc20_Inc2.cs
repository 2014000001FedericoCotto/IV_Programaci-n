internal class Program
{
    private static void Main(string[] args)
    {
        double nota;
        Console.WriteLine("Ingrse su nota: ");
        nota = double.Parse(Console.ReadLine());
        if (nota >= 70)
            Console.WriteLine("aprobado");
        else
            Console.WriteLine("reprobado");
    }
}