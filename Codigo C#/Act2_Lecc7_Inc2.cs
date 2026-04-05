internal class Program
{ //Un algoritmo para leer una calificación y determinar si es deficiente, regular, bien, muy bien o excelente.
    private static void Main(string[] args)
    {
        int nota;
        Console.WriteLine("Ingrese su nota final");
        nota = Convert.ToInt32(Console.ReadLine());
        if (nota <= 69)
            Console.WriteLine("deficiente");
        if (70== nota && nota >= 71)
            Console.WriteLine( "regular");
        if ( 72== nota && nota >= 85 )
            Console.WriteLine("buena");
        if (86 ==nota && nota >=91 )
            Console.WriteLine("muy bueno");
        if (nota  ==100)
            Console.WriteLine("excelente");


    }
}