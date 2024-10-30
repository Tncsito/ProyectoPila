namespace ProyectoPila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool p = true;
            int n = 99;
            Pila a = new Pila(n); // Inicializa la pila fuera del bucle

            while (p == true)
            {
                try
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WindowHeight = 15;
                    Console.WindowWidth = 30;
                    Console.WriteLine("\tProyecto Pilas");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("1.-Establecer Tamaño");
                    Console.WriteLine("");
                    Console.WriteLine("2.-Push");
                    Console.WriteLine("");
                    Console.WriteLine("3.-Pop");
                    Console.WriteLine("");
                    Console.WriteLine("4.-Imprimir");
                    Console.WriteLine("");
                    Console.WriteLine("5.-Salir");
                    Console.WriteLine("------------------------------");
                    Console.Write("Seleccionar Opción => ");
                    int opción = int.Parse(Console.ReadLine());
                    Console.WindowHeight = 15;
                    Console.WindowWidth = 60;
                    Console.Clear();
                    switch (opción)
                    {
                        case 1: // TAMAÑO
                            Console.Write("Escribe el nuevo tamaño de la pila => ");
                            n = Convert.ToInt32(Console.ReadLine());
                            a.Tope(n);
                            Console.Clear();
                            Console.WriteLine("¡Tamaño de pila ajustado correctamente! \n");
                            break;
                        case 2: // PUSH
                            if (a.Full())
                            {
                                Console.WriteLine("La pila está llena");
                            }
                            else
                            {
                                Console.Write("Escriba número a insertar => ");
                                int num = Convert.ToInt32(Console.ReadLine());
                                if (a.Push(num))
                                {
                                    Console.WriteLine("Número insertado correctamente");
                                }
                                else
                                {
                                    Console.WriteLine("No se pudo insertar el número");
                                }
                            }
                            break;
                        case 3: // POP
                            int r = a.Pop();
                            if (r != -1)
                            {
                                Console.WriteLine($"Número {r} Extraído Correctamente");
                            }
                            else
                            {
                                Console.WriteLine("La pila está vacía");
                            }
                            break;
                        case 4: // IMPRIMIR
                            Console.Clear();
                            a.PrintStack();
                            break;
                        case 5: // SALIR
                            p = false;
                            break;
                        default:
                            Console.WriteLine("Opción no válida, por favor intente de nuevo.");
                            Console.ReadKey();
                            break;
                    }
                    Console.Write("\n\n\n\n\n\n\t<Presiona cualquier tecla para continuar>");
                    Console.ReadKey();
                }
                catch (Exception e)
                {
                    Console.WindowHeight = 10;
                    Console.WindowWidth = 60;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("\n\n\n\n\tCaracter no válido <ENTER PARA CONTINUAR>");
                    Console.ReadKey();
                }
            }
        }
    }
}