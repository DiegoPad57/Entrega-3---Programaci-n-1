using System;

class Reserva
{
    private string usuario;
    private string laboratorio;
    private string fecha;
    private string hora;

    public string Usuario
    {
        get { return usuario; }
        set { usuario = value; }
    }

    public string Laboratorio
    {
        get { return laboratorio; }
        set { laboratorio = value; }
    }

    public string Fecha
    {
        get { return fecha; }
        set { fecha = value; }
    }

    public string Hora
    {
        get { return hora; }
        set { hora = value; }
    }
}

class ReservaLaboratorio : Reserva
{
    private string laboratorio;

    public string Laboratorio
    {
        get { return laboratorio; }
        set { laboratorio = value; }
    }
}


class Program
{
    static void Main(string[] args)
    {

        ReservaLaboratorio[] reservas = new ReservaLaboratorio[10];

        int contador = 0;
        int opcion = 0;

        while (opcion != 4)
        {
            Console.WriteLine("\nGestion de reservas para salones y laboratorios");
            Console.WriteLine("1. Registrar reserva");
            Console.WriteLine("2. Listar reservas");
            Console.WriteLine("3. Buscar reserva");
            Console.WriteLine("4. Salir");

            Console.WriteLine("Seleccione su opcion: ");
            try
            {
                opcion = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error: Ingrese un número válido.");
                opcion = 0;
            }

            switch (opcion)
            {
                case 1:
                    if (contador < 10)
                    {
                        ReservaLaboratorio r = new ReservaLaboratorio();

                        Console.Write("Usuario: ");
                        r.Usuario = Console.ReadLine();

                        Console.Write("Laboratorio: ");
                        r.Laboratorio = Console.ReadLine();

                        Console.Write("Fecha: ");
                        r.Fecha = Console.ReadLine();

                        Console.Write("Hora: ");
                        r.Hora = Console.ReadLine();

                        reservas[contador] = r;
                        contador++;

                        Console.WriteLine("Reserva agregada correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("Se ha alcanzado el numero maximo de reservas.");
                    }
                
                break;

                case 2:
                    if (contador == 0)
                    {
                        Console.WriteLine("No hay reservas registradas.");
                        Console.ReadLine();
                    }
                    else
                    {
                        for (int i = 0; i < contador; i++)
                        {
                            Console.WriteLine("\nReserva " + (i + 1));
                            Console.WriteLine("Usuario: " + reservas[i].Usuario);
                            Console.WriteLine("Laboratorio: " + reservas[i].Laboratorio);
                            Console.WriteLine("Fecha: " + reservas[i].Fecha);
                            Console.WriteLine("Hora: " + reservas[i].Hora);
                        }
                    }

                break;

                case 3:
                    Console.Write("Ingrese nombre de usuario a buscar: ");
                    string buscar = Console.ReadLine();
                    bool encontrado = false;

                    for (int i = 0; i < contador; i++)
                    {
                        if (reservas[i].Usuario == buscar)
                        {
                            Console.WriteLine("\nReserva encontrada:");
                            Console.WriteLine("Laboratorio: " + reservas[i].Laboratorio);
                            Console.WriteLine("Fecha: " + reservas[i].Fecha);
                            Console.WriteLine("Hora: " + reservas[i].Hora);
                            encontrado = true;
                        }
                    }

                    if (!encontrado)
                    {
                        Console.WriteLine("No se encontro la reserva.");
                    }
                break;

                case 4:
                    Console.WriteLine("Adios :)");
                break;

                default:
                    Console.WriteLine("Opcion no valida");
                break;

            }
        }
    }
}