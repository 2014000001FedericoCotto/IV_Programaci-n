internal class Program
{
    private static void Main(string[] args)
    {
        int número;
        Console.WriteLine("Opciones: 1,2,3,4 ");
        número = Convert.ToInt32(Console.ReadLine());
        if (número == 1)
        { Console.WriteLine("Eligio la primera opción"); }
        if (número == 2)
        { Console.WriteLine("Eligio la segunda opción"); }
        if (número == 3)
        { Console.WriteLine("Eligio la tercera opción"); }
        if (número == 4)
        { Console.WriteLine("Eligio la cuarta opción"); }
    }

}