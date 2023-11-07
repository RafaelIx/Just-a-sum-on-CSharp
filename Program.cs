namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            inicio: // Etiqueta inicio del programa

            Console.WriteLine("Pues una suma, anota un numero");
            string dato1 = Console.ReadLine();
            
            Console.WriteLine("Ahora el otro");
            string dato2 = Console.ReadLine();
            
            // Transformacion de datos numericos tipo objeto a numericos normales
            int numero1 = int.Parse(dato1);
            int numero2 = int.Parse(dato2);
                    
                        
            // Respuesta
            Console.WriteLine($"El resultado es {numero1 + numero2}");
            Console.WriteLine("Quieres hacer otra suma? \nS/N");

            // Reinicio o fin del programa
            solicitud: // Etiqueta solisitud al usuario

            string letra = Console.ReadLine();
            if (letra == "S" || letra == "s")
            { goto inicio;
            }

            else if (letra == "N" || letra == "n")
            { Console.WriteLine("Vale, chaito");
                Environment.Exit(0);
            }

            else
            { Console.WriteLine("Entrada invalida");
                goto solicitud;
            }
        }
    }
}
