using System;
using Linked = FuncionCalculo.FuncionCalculo;
using AverageLinked = EjercicioPromedio.EjercicioPromedio;

class Program
{
    static void Main(string[] args)
    {
        // --- Uso de FuncionCalculo ---
        Console.WriteLine("=== Ejemplo con FuncionCalculo ===");
        Linked list1 = new Linked();
        list1.Add(10);
        list1.Add(20);
        list1.Add(30);
        Console.WriteLine("Número de elementos en FuncionCalculo:");
        Console.WriteLine(list1.Count());

        // --- Uso de EjercicioPromediot ---
        Console.WriteLine("\n=== Ejemplo con EjercicioPromedio ===");
        AverageLinked list2 = new AverageLinked();
        list2.Add(5);
        list2.Add(15);
        list2.Add(25);
        Console.WriteLine("Elementos en EjercicioPromedio:");
        list2.PrintList();
        Console.WriteLine("Promedio de los elementos en EjercicioPromedio:");
        Console.WriteLine(list2.CalculateAverage());
    }
}
