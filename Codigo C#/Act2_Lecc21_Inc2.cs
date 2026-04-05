internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        Console.WriteLine("Presion una de las siguientes ocpciones: 1,2,3,4");
        num = Convert.ToInt32(Console.ReadLine());
        if (num == 1)
            Console.WriteLine("Bienvenido a ventas, Anacleto Ramirez, rana0987@gmail.com");
        else if (num == 2)
            Console.WriteLine("Bienvenido a recepción, Penélope Guzmán, carlaguzman@gmail.com");
        else if (num == 3)
            Console.WriteLine("Bienvenido a dirección Enrique Lobos, lobos0998@gmail.com");
        else if (num == 4)
            Console.WriteLine("Bienvenido a compras Carla Paniagua, capa1107@gmail.com");
    }
}