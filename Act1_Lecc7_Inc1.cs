internal class Program
{
    private static void Main(string[] args)
    {
        //un algoritmo que determine si un estudiante ganó o perdió segun el promedio

        Console.WriteLine("Hello, World!");
        //variables
        string materia;
        int n1, n2, n3, n4, n5;
        double promedio;

        //enviar info al usuario
        Console.WriteLine("Digite una materia: ");
        materia = Console.ReadLine();
        Console.WriteLine("Ingrese sus notas: ");
        n1=Convert.ToInt32(Console.ReadLine());
        n2=Convert.ToInt32(Console.ReadLine());
        n3=Convert.ToInt32(Console.ReadLine());
        n4=Convert.ToInt32(Console.ReadLine());
        n5=Convert.ToInt32(Console.ReadLine());

        //Proceso
        promedio = (n1 + n2 + n3 + n4 + n5) / 5;

        //Evaluar si gano o perdio
        if (promedio >= 70)
            Console.WriteLine("Estudiante reprobado con: "+promedio);
        else
            Console.WriteLine("Estudiante reprobado con: " + promedio);
    }
}