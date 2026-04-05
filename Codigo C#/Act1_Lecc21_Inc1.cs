internal class Program
{
    private static void Main(string[] args)
    {
        int dia;
        Console.WriteLine("Ingrese la fecha de hoy (solo el dia): ");
        dia = Convert.ToInt32(Console.ReadLine());
        if (dia == 1)
            Console.WriteLine("lunes");
        if (dia == 2)
            Console.WriteLine("martes");
        if (dia == 3)
            Console.WriteLine("miercoles");
        if (dia == 4)
            Console.WriteLine("jueves");
        if (dia == 5)
            Console.WriteLine("viernes");
        if (dia == 6)
            Console.WriteLine("sabado");
        if (dia == 7)
            Console.WriteLine("domingo");
    }
}