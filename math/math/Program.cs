using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el valor de n:");
        int n = Convert.ToInt32(Console.ReadLine());

        MostrarTablaCompleta(n);
    }

    static void MostrarTablaCompleta(int n)
    {
        Console.WriteLine("c   x   Valor   i   j");
        Console.WriteLine("----------------------");

        for (int i = 1; i <= n; i++)
        {
            int[,] tabla = jemenan(i);

            for (int j = 0; j < i; j++)
            {
                Console.WriteLine($"{tabla[j, 0]}   {tabla[j, 1]}   {tabla[j, 2]}   {i}   {j + 1}");
            }
        }
    }

    static int[,] jemenan(int n)
    {
        int[,] tabla = new int[n, 3];
        int potencia = (int)Math.Pow(2, n);
        int c = 2;
        int x = 1;
        int valor = 1;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < potencia / c; j++)
            {
                tabla[j, 0] = c;
                tabla[j, 1] = x;
                tabla[j, 2] = valor;
            }

            valor = (valor == 1) ? 0 : 1;
            x++;
            c *= 2;
        }

        return tabla;
    }
}


