namespace ejercicio_uno_menu
{
    internal class Program
    {
        static int acumulador = 0;
        static int contador = 0;
        static int maximo = 0;
        static int minimo = 0;
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                opcion = MostrarPantallaSolicitarOpcionMenu();
                switch (opcion)
                {
                    case 1:
                        MostrarPantallaSolicitarNumero();
                        break;
                    case 2:
                        MostrarPantallaSolicitarVariosNumeros();
                        break;
                    case 3:
                        MostrarPantallaMaximoYMinimo();
                        break;
                    case 4:
                        MostrarPantallaCalcularYMostrarPromedio();
                        break;
                    case 5:
                        MostrarPantallaCantidad();
                        break;
                    case 6:
                        MostrarIniciarVariables();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, elige una opción del menú.");
                        break;
                }
            }
            while (opcion != 0);
        }

        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.WriteLine("======Menu======");
            Console.WriteLine("1- Procesar un número");
            Console.WriteLine("2- Procesar varios números");
            Console.WriteLine("3- Mostrar máximo y mínimo");
            Console.WriteLine("4- Calcular y mostrar promedio");
            Console.WriteLine("5- Mostrar cantidad de números procesados");
            Console.WriteLine("6- Reiniciar variables");
            Console.WriteLine("0- Salir del programa");
            Console.Write("Elige una opción: ");
            return int.Parse(Console.ReadLine());
        }

        static void MostrarIniciarVariables()
        {
            acumulador = 0;
            contador = 0;
            maximo = 0;
            minimo = 0;
            Console.WriteLine("Variables reiniciadas.");
        }

        static void MostrarPantallaSolicitarNumero()
        {
            Console.Write("Introduce un número: ");
            int valor = int.Parse(Console.ReadLine());
            RegistrarValor(valor);
        }

        static void MostrarPantallaSolicitarVariosNumeros()
        {
            Console.WriteLine("¿Cuántos números quieres procesar?");
            int cantidad = int.Parse(Console.ReadLine());
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"Introduce el número {i + 1}: ");
                int valor = int.Parse(Console.ReadLine());
                RegistrarValor(valor);
            }
        }

        static void RegistrarValor(int valor)
        {
            acumulador += valor;
            contador++;
            if (contador == 1)
            {
                maximo = valor;
                minimo = valor;
            }
            else
            {
                if (valor > maximo)
                {
                    maximo = valor;
                }
                if (valor < minimo)
                {
                    minimo = valor;
                }
            }
        }

        static double CalcularPromedio()
        {
            if (contador > 0)
            {
                return (double)acumulador / contador;
            }
            else
            {
                return 0;
            }
        }

        static void MostrarPantallaMaximoYMinimo()
        {
            if (contador > 0)
            {
                Console.WriteLine($"Máximo: {maximo}");
                Console.WriteLine($"Mínimo: {minimo}");
            }
            else
            {
                Console.WriteLine("No se han procesado números.");
            }
        }

        static void MostrarPantallaCalcularYMostrarPromedio()
        {
            if (contador == 0)
            {
                Console.WriteLine("No se han procesado números.");
            }
            else
            {
                double promedio = CalcularPromedio();
                Console.WriteLine($"El promedio es: {promedio:F2}");
            }
        }

        static void MostrarPantallaCantidad()
        {
            Console.WriteLine($"Cantidad de números procesados: {contador}");
        }
    }
}

