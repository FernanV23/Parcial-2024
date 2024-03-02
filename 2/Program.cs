using System;

class Program
{
    static void Main()
    {
        int numero;

        do
        {
            Console.Write("Ingrese un número entero positivo (o ingrese 0 para salir): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out numero))
            {
                if (numero < 0)
                {
                    Console.WriteLine("Por favor, ingrese un número entero positivo.");
                    continue;
                }

                MostrarMenu();

                int opcion;
                Console.Write("Seleccione una opción: ");
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            CalcularFactorial(numero);
                            break;

                        case 2:
                            CalcularRaizCuadrada(numero);
                            break;

                        case 3:
                            Console.WriteLine("Saliendo del programa...");
                            break;

                        default:
                            Console.WriteLine("Opción no válida. Intente de nuevo.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
            }

        } while (numero != 0);
    }

    static void MostrarMenu()
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Calcular el factorial del número.");
        Console.WriteLine("2. Calcular la raíz cuadrada del número.");
        Console.WriteLine("3. Salir del programa.");
    }

    static void CalcularFactorial(int n)
    {
        int factorial = 1;
        for (int i = 2; i <= n; ++i)
        {
            factorial *= i;
        }
        Console.WriteLine($"El factorial de {n} es: {factorial}");
    }

    static void CalcularRaizCuadrada(int n)
    {
        Console.WriteLine($"La raíz cuadrada de {n} es: {Math.Sqrt(n)}");
    }
}
