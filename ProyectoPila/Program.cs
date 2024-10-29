namespace ProyectoPila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool p = true;
            int n = 0;
            while (p != false)
            {
                try
                {
                    
                    Pila a = new Pila(n);
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
                        case 1://TAMAÑO
                            Console.Write("Escribe el tope de la pila => ");
                            n = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            Console.Write("¡Tamaño de pila ajustado correctamente!");
                            break;
                        case 2://PUSH
                            Console.Write("Escriba Numero a Insertar => ");
                            n = Convert.ToInt32(Console.ReadLine());
                            if (a.Push(n) == false)
                            {
                                Console.WriteLine("La pila está llena");
                            } 
                            else if(a.Push(n) == true)
                            {
                                Console.WriteLine("Numero Insertado Correctamente");
                            } 
                            break;
                        case 3://POP
                            break;
                        case 4://IMPRIMIR
                            Console.Clear();
                            a.PrintStack();
                            Console.ReadKey();
                            break;
                        case 5://SALIR
                            Console.WindowHeight = 10;
                            Console.WindowWidth = 60;
                            Console.Clear();
                            p = false;
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