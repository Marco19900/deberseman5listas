using System;
using System.Collections.Generic; // Necesario para trabajar con Listas

class Program
{
    static void Main(string[] args)
    {
        // 1. Crear una lista para almacenar las asignaturas
        List<string> asignaturas = new List<string>();

        // 2. Agregar las asignaturas a la lista
        asignaturas.Add("Matemáticas");
        asignaturas.Add("Física");
        asignaturas.Add("Química");
        asignaturas.Add("Historia");
        asignaturas.Add("Lengua");

        // 3. Recorrer la lista e imprimir "Yo estudio <asignatura>"
        foreach (string asignatura in asignaturas)
        {
            Console.WriteLine($"Yo estudio {asignatura}");
        }
    }
}
