namespace ProyectoPila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            
            while (a != false)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    Console.WindowHeight = 17;
                    Console.WindowWidth = 30;
                    Console.WriteLine("\tProyecto Pilas");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("1.-Establecer Tamaño");
                    Console.WriteLine("");
                    Console.WriteLine("2.-Push");
                    Console.WriteLine("");
                    Console.WriteLine("3.-Pop");
                    Console.WriteLine("");
                    Console.WriteLine("4.-Imprimir");
                    Console.WriteLine("");
                    Console.WriteLine("5.-Salir");
                    Console.WriteLine("");
                    Console.WriteLine("------------------------------");
                    Console.Write("Seleccionar Opción => ");
                    int Opción = int.Parse(Console.ReadLine());
                    switch (Opción)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            Console.WindowHeight = 10;
                            Console.WindowWidth = 60;
                            Console.Clear();
                            a = false;
                            break;
                    }
                }catch(Exception e)
                {
                    Console.WindowHeight = 10;
                    Console.WindowWidth = 60;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("\n\n\n\n\tCaracter no valido <ENTER PARA CONTINUAR>");
                    Console.ReadKey();
                }
            }
        }
    }
}