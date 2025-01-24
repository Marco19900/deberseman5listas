using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // 1. Crear una lista para almacenar las asignaturas
        List<string> asignaturas = new List<string>
        {
            "Matemáticas", 
            "Física", 
            "Química", 
            "Historia", 
            "Lengua"
        };

        // 2. Crear una lista para almacenar las notas
        List<double> notas = new List<double>();

        // 3. Pedir al usuario la nota para cada asignatura
        foreach (string asignatura in asignaturas)
        {
            Console.Write($"¿Qué nota has sacado en {asignatura}? ");
            // Leer la nota introducida por el usuario
            double nota;
            while (!double.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 10)
            {
                // Validación: La nota debe ser un número entre 0 y 10
                Console.WriteLine("Por favor, ingresa una nota válida entre 0 y 10.");
                Console.Write($"¿Qué nota has sacado en {asignatura}? ");
            }
            notas.Add(nota);
        }

        // 4. Mostrar el mensaje "En <asignatura> has sacado <nota>"
        Console.WriteLine("\nResumen de tus notas:");
        for (int i = 0; i < asignaturas.Count; i++)
        {
            Console.WriteLine($"En {asignaturas[i]} has sacado {notas[i]}");
        }
    }
}
