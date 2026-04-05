internal class Program
{
    private static void Main(string[] args)
    {
        string contra;
        Console.WriteLine("Ingrese la contraseña");
        contra = Console.ReadLine();
        if (contra == "Password123")
        { Console.WriteLine("Bienvenido"); }
        else
        { Console.WriteLine("Prohibido el ingreso"); }
    }
}