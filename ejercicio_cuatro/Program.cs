using System;

namespace Tenistas
{
    internal class Program
    {
        static string jugador1;
        static string jugador2;
        static int setGanadosJugador1 = 0;
        static int setGanadosJugador2 = 0;

        static void Main(string[] args)
        {
            int opcion;
            do
            {
                opcion = MostrarPantallaSolicitarOpcionMenu();
                switch (opcion)
                {
                    case 1:
                        MostrarPantallaSolicitarNombreJugadores();
                        break;
                    case 2:
                        MostrarPantallaSolicitarResultadosSet();
                        break;
                    case 3:
                        MostrarPantallaGanador();
                        break;
                }
            }
            while (opcion >= 1 && opcion <= 3);
        }

        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Ingresar nombres de los jugadores");
            Console.WriteLine("2. Ingresar resultados de los sets");
            Console.WriteLine("3. Mostrar ganador del partido");
            Console.WriteLine("4. Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }

        static void RegistarJugadores(string nombreJugador1, string nombreJugador2)
        {
            jugador1 = nombreJugador1;
            jugador2 = nombreJugador2;
        }

        static void RegistrarResultados(int resultado1, int resultado2)
        {
            if (resultado1 > resultado2)
            {
                setGanadosJugador1++;
            }
            else if (resultado2 > resultado1)
            {
                setGanadosJugador2++;
            }
        }

        static string DeterminarGanador()
        {
            if (setGanadosJugador1 > setGanadosJugador2)
            {
                return jugador1;
            }
            else if (setGanadosJugador2 > setGanadosJugador1)
            {
                return jugador2;
            }
            else
            {
                return "Empate";
            }
        }

        static void MostrarPantallaSolicitarNombreJugadores()
        {
            Console.WriteLine("Ingrese el nombre del jugador 1:");
            string nombreJugador1 = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del jugador 2:");
            string nombreJugador2 = Console.ReadLine();
            RegistarJugadores(nombreJugador1, nombreJugador2);
        }

        static void MostrarPantallaSolicitarResultadosSet()
        {
            setGanadosJugador1 = 0;
            setGanadosJugador2 = 0;

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Ingrese el resultado del set {i} para {jugador1}:");
                int resultado1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Ingrese el resultado del set {i} para {jugador2}:");
                int resultado2 = Convert.ToInt32(Console.ReadLine());

                RegistrarResultados(resultado1, resultado2);
            }
        }

        static void MostrarPantallaGanador()
        {
            string ganador = DeterminarGanador();
            Console.WriteLine($"El ganador del partido es: {ganador}");
        }
    }
}
