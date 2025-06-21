using System;

namespace EncuestaApp
{
    internal class Program
    {
        static int positivos = 0;
        static int negativos = 0;
        static int indecisos = 0;

        static double porcentajePositivos = 0;
        static double porcentajeNegativos = 0;
        static double porcentajeIndecisos = 0;

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
                        MostrarPantallaRegistrarEncuesta();
                        break;
                    case 2:
                        MostrarPantallaProcesarMostrarResultadosEncuesta();
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
            Console.WriteLine("1 - Registrar opinión");
            Console.WriteLine("2 - Procesar y mostrar resultados de la encuesta");
            Console.WriteLine("0 - Salir");
            Console.Write("Seleccione una opción: ");
        }

        static void MostrarPantallaRegistrarEncuesta()
        {
            string continuar;
            int opinion;

            do
            {
                Console.Write("Ingrese opinión (0: Positivo, 1: Negativo, 2: Indeciso): ");
                opinion = int.Parse(Console.ReadLine());

                RegistrarOpinion(opinion);

                Console.Write("¿Desea ingresar otra opinión? (s/n): ");
                continuar = Console.ReadLine().ToLower();

            } while (continuar == "s");
        }

        static void RegistrarOpinion(int opinion)
        {
            if (opinion == 0)
            {
                positivos++;
            }
            else if (opinion == 1)
            {
                negativos++;
            }
            else if (opinion == 2)
            {
                indecisos++;
            }
            else
            {
                Console.WriteLine("Opinión inválida. Use 0, 1 o 2.");
            }
        }

        static void MostrarPantallaProcesarMostrarResultadosEncuesta()
        {
            if (positivos + negativos + indecisos == 0)
            {
                Console.WriteLine("No se ingresaron opiniones aún.");
                return;
            }

            ProcesarEncuesta();

            Console.WriteLine("Resultados de la encuesta:");
            Console.WriteLine($"Positivos: {porcentajePositivos:F2}%");
            Console.WriteLine($"Negativos: {porcentajeNegativos:F2}%");
            Console.WriteLine($"Indecisos: {porcentajeIndecisos:F2}%");
        }

        static void ProcesarEncuesta()
        {
            int total = positivos + negativos + indecisos;

            porcentajePositivos = (positivos * 100.0) / total;
            porcentajeNegativos = (negativos * 100.0) / total;
            porcentajeIndecisos = (indecisos * 100.0) / total;
        }
    }
}
