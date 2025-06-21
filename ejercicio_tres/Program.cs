using System;

namespace RegistroAlumnos
{
    internal class Program
    {
        static string nombre0, nombre1, nombre2;
        static int numeroLibreta0, numeroLibreta1, numeroLibreta2;

        static void Main(string[] args)
        {
            int opcion;
            do
            {
                opcion = MostrarPantallaSolicitarOpcionMenu();
                switch (opcion)
                {
                    case 1:
                        MostrarPantallaSolicitarAlumnos();
                        break;
                    case 2:
                        MostrarPantallaMostrarListaOrdenada();
                        break;
                }
            }
            while (opcion != 0 && opcion >= 1 && opcion <= 2);
        }

        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.WriteLine("=== SISTEMA DE REGISTRO DE ALUMNOS ===");
            Console.WriteLine("1. Registrar las notas de los tres alumnos");
            Console.WriteLine("2. Mostrar lista ordenada");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            return int.Parse(Console.ReadLine());
        }

        static void MostrarPantallaSolicitarAlumnos()
        {
            Console.WriteLine("=== REGISTRO DE ALUMNOS ===");

            Console.WriteLine("Ingrese los datos del primer alumno:");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Número de libreta: ");
            int numeroLibreta = int.Parse(Console.ReadLine());
            RegistrarNombreYNumeroLibreta(nombre, numeroLibreta, 0);

            Console.WriteLine("Ingrese los datos del segundo alumno:");
            Console.Write("Nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Número de libreta: ");
            numeroLibreta = int.Parse(Console.ReadLine());
            RegistrarNombreYNumeroLibreta(nombre, numeroLibreta, 1);

            Console.WriteLine("Ingrese los datos del tercer alumno:");
            Console.Write("Nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Número de libreta: ");
            numeroLibreta = int.Parse(Console.ReadLine());
            RegistrarNombreYNumeroLibreta(nombre, numeroLibreta, 2);

            Console.WriteLine("¡Alumnos registrados correctamente!");
        }

        static void MostrarPantallaMostrarListaOrdenada()
        {
            if (string.IsNullOrEmpty(nombre0) || string.IsNullOrEmpty(nombre1) || string.IsNullOrEmpty(nombre2))
            {
                Console.WriteLine("Debe registrar los tres alumnos antes de mostrar la lista ordenada.");
                return;
            }

            Console.WriteLine("=== LISTA ORDENADA POR NÚMERO DE LIBRETA (MENOR A MAYOR) ===");
            Console.WriteLine("Pos.       Nombre       Número de Libreta");
            Console.WriteLine("----       ------       -----------------");

            if (numeroLibreta0 > numeroLibreta1)
            {
                if (numeroLibreta2 > numeroLibreta0)
                {
                    Console.WriteLine("1       " + nombre1 + "       " + numeroLibreta1);
                    Console.WriteLine("2       " + nombre2 + "       " + numeroLibreta2);
                    Console.WriteLine("3       " + nombre0 + "       " + numeroLibreta0);
                }
                else
                {
                    if (numeroLibreta2 > numeroLibreta1)
                    {
                        Console.WriteLine("1       " + nombre1 + "       " + numeroLibreta1);
                        Console.WriteLine("2       " + nombre2 + "     " + numeroLibreta2);
                        Console.WriteLine("3       " + nombre0 + "     " + numeroLibreta0);
                    }
                    else
                    {
                        Console.WriteLine("1       " + nombre2 + "       " + numeroLibreta2);
                        Console.WriteLine("2       " + nombre1 + "       " + numeroLibreta1);
                        Console.WriteLine("3       " + nombre0 + "       " + numeroLibreta0);
                    }
                }
            }
            else
            {
                if (numeroLibreta2 > numeroLibreta1)
                {
                    Console.WriteLine("1       " + nombre0 + "       " + numeroLibreta0);
                    Console.WriteLine("2       " + nombre1 + "       " + numeroLibreta1);
                    Console.WriteLine("3       " + nombre2 + "       " + numeroLibreta2);
                }
                else
                {
                    if (numeroLibreta2 > numeroLibreta0)
                    {
                        Console.WriteLine("1       " + nombre0 + "       " + numeroLibreta0);
                        Console.WriteLine("2       " + nombre2 + "       " + numeroLibreta2);
                        Console.WriteLine("3       " + nombre1 + "       " + numeroLibreta1);
                    }
                    else
                    {
                        Console.WriteLine("1       " + nombre2 + "       " + numeroLibreta2);
                        Console.WriteLine("2       " + nombre0 + "       " + numeroLibreta0);
                        Console.WriteLine("3       " + nombre1 + "       " + numeroLibreta1);
                    }
                }
            }
        }

        static void RegistrarNombreYNumeroLibreta(string nombre, int numeroLibreta, int posicion)
        {
            switch (posicion)
            {
                case 0:
                    nombre0 = nombre;
                    numeroLibreta0 = numeroLibreta;
                    break;
                case 1:
                    nombre1 = nombre;
                    numeroLibreta1 = numeroLibreta;
                    break;
                case 2:
                    nombre2 = nombre;
                    numeroLibreta2 = numeroLibreta;
                    break;
            }
        }
    }
}