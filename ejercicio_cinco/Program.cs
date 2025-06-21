using System;

namespace AnioBisiestoYDiaDelMes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                MostrarPantallaSolicitarOpcionMenu();
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        MostrarPantallaSolicitarMesAnioYDeterminarDias();
                        break;
                    case 2:
                        MostrarPantallaVerificarSiElAnioEsBisiesto();
                        break;
                    case 0:
                        Console.WriteLine("Programa finalizado.");
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                Console.WriteLine();

            } while (opcion != 0);
        }

        static void MostrarPantallaSolicitarOpcionMenu()
        {
            Console.WriteLine("Menú de Opciones:");
            Console.WriteLine("1 - Determinar Cantidad de Días del Mes.");
            Console.WriteLine("2 - Verificar Si el Año es Bisiesto.");
            Console.WriteLine("0 - Salir.");
            Console.Write("Seleccione una opción: ");
        }

        static void MostrarPantallaSolicitarMesAnioYDeterminarDias()
        {
            Console.Write("Ingrese el número del mes (1 a 12): ");
            int mes = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el año: ");
            int anio = int.Parse(Console.ReadLine());

            int dias = DeterminarLosDiasDelMes(mes, anio);

            Console.WriteLine($"El mes {mes} del año {anio} tiene {dias} días.");
        }

        static void MostrarPantallaVerificarSiElAnioEsBisiesto()
        {
            Console.Write("Ingrese el año a verificar: ");
            int anio = int.Parse(Console.ReadLine());

            if (DeterminarSiEsBisiesto(anio))
                Console.WriteLine($"El año {anio} es bisiesto.");
            else
                Console.WriteLine($"El año {anio} no es bisiesto.");
        }

        static bool DeterminarSiEsBisiesto(int anio)
        {
            if (anio % 4 == 0)
            {
                if (anio % 100 != 0 || anio % 400 == 0)
                {
                    return true;
                }
            }
            return false;
        }

        static int DeterminarLosDiasDelMes(int mes, int anio)
        {
            if (mes == 2)
            {
                return DeterminarSiEsBisiesto(anio) ? 29 : 28;
            }
            else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                return 30;
            }
            else
            {
                return 31;
            }
        }
    }
}
