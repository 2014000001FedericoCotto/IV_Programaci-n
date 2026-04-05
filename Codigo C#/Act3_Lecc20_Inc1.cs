internal class Program
{
    private static void Main(string[] args)
    {
        int dia;
        Console.WriteLine("Escriba la fecha de hoy (solo el dia) ");
        dia = Convert.ToInt32(Console.ReadLine());
        if (dia == 1)
            Console.WriteLine("entre semana");
        if (dia == 2)
            Console.WriteLine("entre semana");
        if (dia == 3)
            Console.WriteLine("entre semana");
        if (dia == 4)
            Console.WriteLine("entre semana");
        if (dia == 5)
            Console.WriteLine("entre semana");
        if (dia == 6)
            Console.WriteLine("fin de  semana");
        if (dia == 7)
            Console.WriteLine("fin de semana");
         
    }
}