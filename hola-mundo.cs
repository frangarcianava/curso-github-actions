using System;

class Program
{
    static void Main()
    {
        string nombre = Environment.GetEnvironmentVariable("USERNAME");
        Console.WriteLine($"¡Hola, {nombre} desde GitHub!");
    }
}
