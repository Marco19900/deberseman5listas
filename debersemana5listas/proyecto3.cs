using System;
using System.Collections.Generic;

namespace PilasYHanoi
{
    class Program
    {
        // Método para verificar si una fórmula matemática está balanceada
        static bool EsFormulaBalanceada(string formula)
        {
            // Pila para almacenar los caracteres de apertura
            Stack<char> pila = new Stack<char>();

            // Recorrer cada carácter en la fórmula
            foreach (char c in formula)
            {
                // Si es un carácter de apertura, agregarlo a la pila
                if (c == '{' || c == '[' || c == '(')
                {
                    pila.Push(c);
                }
                // Si es un carácter de cierre, verificar balanceo
                else if (c == '}' || c == ']' || c == ')')
                {
                    // Si la pila está vacía, no está balanceado
                    if (pila.Count == 0)
                        return false;

                    // Obtener el último carácter de apertura
                    char ultimo = pila.Pop();

                    // Verificar si el carácter de apertura corresponde al de cierre
                    if ((c == '}' && ultimo != '{') ||
                        (c == ']' && ultimo != '[') ||
                        (c == ')' && ultimo != '('))
                        return false;
                }
            }

            // Si la pila está vacía, la fórmula está balanceada
            return pila.Count == 0;
        }

        // Método recursivo para resolver las Torres de Hanoi
        static void TorresDeHanoi(int discos, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar, string nombreOrigen, string nombreDestino, string nombreAuxiliar)
        {
            if (discos == 1)
            {
                // Mover un solo disco directamente de origen a destino
                destino.Push(origen.Pop());
                Console.WriteLine($"Mover disco de {nombreOrigen} a {nombreDestino}");
                return;
            }

            // Mover n-1 discos del origen al auxiliar
            TorresDeHanoi(discos - 1, origen, auxiliar, destino, nombreOrigen, nombreAuxiliar, nombreDestino);

            // Mover el disco restante del origen al destino
            destino.Push(origen.Pop());
            Console.WriteLine($"Mover disco de {nombreOrigen} a {nombreDestino}");

            // Mover los n-1 discos del auxiliar al destino
            TorresDeHanoi(discos - 1, auxiliar, destino, origen, nombreAuxiliar, nombreDestino, nombreOrigen);
        }

        static void Main(string[] args)
        {
            // Ejemplo 1: Verificar fórmula balanceada
            string formula = "{7+(8*5)-[(9-7)+(4+1)]}";
            bool balanceada = EsFormulaBalanceada(formula);
            Console.WriteLine($"La fórmula \"{formula}\" está balanceada: {balanceada}");

            // Ejemplo 2: Resolver las Torres de Hanoi
            int numDiscos = 3;
            Stack<int> torreOrigen = new Stack<int>();
            Stack<int> torreDestino = new Stack<int>();
            Stack<int> torreAuxiliar = new Stack<int>();

            // Inicializar la torre de origen con los discos
            for (int i = numDiscos; i >= 1; i--)
            {
                torreOrigen.Push(i);
            }

            Console.WriteLine("\nResolviendo Torres de Hanoi:");
            TorresDeHanoi(numDiscos, torreOrigen, torreDestino, torreAuxiliar, "Origen", "Destino", "Auxiliar");
        }
    }
}