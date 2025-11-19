// Procedimiento realizado usando IA assistance

using System;

class Program
{
    static void Main(string[] args)
    {
        // array de longitud 3 {0,1,2}
        float[] datos = new float[3];

        Console.WriteLine("Ingrese 3 valores tipo float:");

        for (int i = 0; i < datos.Length; i++)
        {
            Console.Write($"Dato #{i + 1}: ");
            datos[i] = float.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nLos datos ingresados son:");
        foreach (float valor in datos)
        {
            Console.WriteLine(valor);
        }
    }
}
