using System;

class Program
{
    static void Main()
    {
        // Ejercicio 1
        Console.Write("¿Cuál es tu edad? ");
        byte edad = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("No aparentas {0} años", edad);

        // Ejercicio 2
        Console.Write("Introduce un número de dos cifras: ");
        byte num1 = Convert.ToByte(Console.ReadLine());
        Console.Write("Introduce otro número de dos cifras: ");
        byte num2 = Convert.ToByte(Console.ReadLine());
        ushort resultado = (ushort)(num1 * num2);
        Console.WriteLine("El resultado de la multiplicación es: {0}", resultado);

        // Ejercicio 3
        Console.Write("Introduce un número entero largo: ");
        long num3 = Convert.ToInt64(Console.ReadLine());
        Console.Write("Introduce otro número entero largo: ");
        long num4 = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("La suma de {0} y {1} es: {2}", num3, num4, num3 + num4);
        Console.WriteLine("La resta de {0} y {1} es: {2}", num3, num4, num3 - num4);
        Console.WriteLine("El producto de {0} y {1} es: {2}", num3, num4, num3 * num4);
    }
}
