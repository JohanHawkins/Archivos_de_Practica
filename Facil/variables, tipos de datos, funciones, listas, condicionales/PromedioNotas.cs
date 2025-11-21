using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        float[] notas = new float[3];

        Console.WriteLine("\n Ingrese 3 notas (valores entre 1.0 y 5.0). \n Use punto (.) como separador decimal.\n");

        for (int i = 0; i < notas.Length; i++)
        {
            notas[i] = LeerNotaValida(i + 1);
        }

        Console.WriteLine("\nNotas ingresadas:");
        foreach (float n in notas)
        {
            Console.WriteLine(n);
        }
    }

    // Función de validación
    static float LeerNotaValida(int numeroNota)
    {
        while (true)
        {
            Console.Write($"Nota #{numeroNota}: ");
            string input = Console.ReadLine();

            // Intentar convertir respetando el punto decimal
            if (float.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out float valor))
            {
                // Validar rango y no negativos
                if (valor < 0)
                {
                    Console.WriteLine("ERROR: No se permiten números negativos.");
                }
                else if (valor < 1 || valor > 5)
                {
                    Console.WriteLine("ERROR: La nota debe estar entre 1.0 y 5.0.");
                }
                else
                {
                    return valor; // válido
                }
            }
            else
            {
                Console.WriteLine("ERROR: Formato inválido. Use punto (.) para decimales. Ej: 3.5");
            }

            Console.WriteLine("Intente nuevamente.\n");
        }
    }
}
