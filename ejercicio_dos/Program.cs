namespace niñas_menu
{
    internal class Program
    {
        static int edad0 = 0, edad1 = 0, edad2 = 0, edad3 = 0;
        static double porcentaje0, porcentaje1, porcentaje2, porcentaje3;
        static double monto0, monto1, monto2, monto3, montoTotal;
        static void Main(string[] args)
        {
            

            int opcion;
            do
            {
                opcion = MostrarPantallaSolicitarOpcionMenu();
                switch (opcion)
                {
                    case 1:
                        MostrarPantallaSolicitarMontoARepartir();
                        break;
                    case 2:
                        MostrarPantallaSolicitarEdadesNiñas();
                        break;
                    case 3:
                        MostrarPantallaCalcularMostrarMontoYPorcentajePorNiña();
                        break;

                }
            }
            while (opcion!=0 && opcion<=3 && opcion>0);
        }

        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.WriteLine("1. Solicitar monto a repartir");
            Console.WriteLine("2. Solicitar edades de las niñas");
            Console.WriteLine("3. Calcular y mostrar monto y porcentaje por niña");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            return int.Parse(Console.ReadLine());
        }

        static void MostrarPantallaSolicitarMontoARepartir()
        {
            Console.Write("Ingrese el monto a repartir: ");
            double monto = double.Parse(Console.ReadLine());
            Console.WriteLine($"Monto ingresado: {monto:C}");
            RegistrarMontoARepartir(monto);
            Console.WriteLine("Monto registrado correctamente.");
        }

        static void MostrarPantallaSolicitarEdadesNiñas()
        {
            Console.WriteLine("Ingrese las edades de las niñas:");
            Console.Write("Edad niña 1: ");
            RegistrarEdad(int.Parse(Console.ReadLine()), 0);
            Console.Write("Edad niña 2: ");
            RegistrarEdad(int.Parse(Console.ReadLine()), 1);
            Console.Write("Edad niña 3: ");
            RegistrarEdad(int.Parse(Console.ReadLine()), 2);
            Console.Write("Edad niña 4: ");
            RegistrarEdad(int.Parse(Console.ReadLine()), 3);
        }

        static void MostrarPantallaCalcularMostrarMontoYPorcentajePorNiña()
        {
            if (montoTotal != 0 && edad0!=0 && edad1!=0 && edad2!=0 && edad3!=0)
            { 
                CalcularMontosYPorcentajesARepartir();
                Console.WriteLine("Monto y porcentaje por niña:");
                Console.WriteLine($"Niña 1: Monto = {monto0:C}, Porcentaje = {porcentaje0:P2}");
                Console.WriteLine($"Niña 2: Monto = {monto1:C}, Porcentaje = {porcentaje1:P2}");
                Console.WriteLine($"Niña 3: Monto = {monto2:C}, Porcentaje = {porcentaje2:P2}");
                Console.WriteLine($"Niña 4: Monto = {monto3:C}, Porcentaje = {porcentaje3:P2}");
            }
            else
            {
                Console.WriteLine("Debe ingresar el monto a repartir y las edades de las niñas antes de calcular.");
            }
        }

        static void RegistrarMontoARepartir(double monto)
        {
            montoTotal=monto;
        }

        static void RegistrarEdad(int edad,int numeroNiña)
        {
            switch (numeroNiña)
            {
                case 0:
                    edad0 = edad;
                    break;
                case 1:
                    edad1 = edad;
                    break;
                case 2:
                    edad2 = edad;
                    break;
                case 3:
                    edad3 = edad;
                    break;
            }
        }

        static void CalcularMontosYPorcentajesARepartir()
        {
            int sumaEdades = edad0 + edad1 + edad2 + edad3;
            porcentaje0 = (double)edad0 / sumaEdades;
            porcentaje1 = (double)edad1 / sumaEdades;
            porcentaje2 = (double)edad2 / sumaEdades;
            porcentaje3 = (double)edad3 / sumaEdades;

            monto0 = montoTotal * porcentaje0;
            monto1 = montoTotal * porcentaje1;
            monto2 = montoTotal * porcentaje2;
            monto3 = montoTotal * porcentaje3;
        }
    }
}
