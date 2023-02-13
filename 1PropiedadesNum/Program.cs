using System;

namespace PropiedadesNum
{
    public class Program
    {
        static void Main(string[] args)
        {
            int op, n;
            Console.WriteLine("Introduzca un numero: ");
            n = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("\n1. Factorial\n" +
                    "2. Es primo\n" +
                    "3. Divisores\n" +
                    "4. Salir");
                Console.WriteLine("Introduzca una opcion: ");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        //Llamada al metodo factorial()
                        Console.WriteLine(Factorial(n));
                        break;
                    case 2:
                        //Llamada al metodo esPrimo(). Si este metodo retorna true n es primo, si retorna false no lo es
                        if (esPrimo(ref n))
                            Console.WriteLine("El numero " + n + " es primo");
                        else
                            Console.WriteLine("El numero " + n + " no es primo");
                        break;
                    case 3:
                        //Aqui recorremos los numeros desde 0 hasta la mitad de n, para ver si son divisores de n con la llamada 
                        //al metodo divisores()
                        int contador = 1;
                        Console.Write("Los divisores de " + n + " son: ");
                        for (int i = 0; i < n / 2; i++)
                        {
                            if (divisores(n, contador))
                            {
                                Console.Write(contador + " ");
                            }
                            contador++;
                        }
                        Console.Write(n);
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("Fin del programa");
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                }


            } while (op != 4);
        }

        public static int Factorial(int n)//En este metodo calculamos el factorial del numero que le pasamos por parametro
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        public static bool esPrimo(ref int n)//En este metodo calcularemos si un numero pasado por parametro es primo o no. Si lo es 
                                         //retorna una variable booleana con valor true, y si no lo es con valor false
        {
            bool esPrimo = true;
            for (int i = 2; i < n; i++)
            {
                if ((n % i) == 0)
                {
                    esPrimo = false;
                }
            }
            return esPrimo;
        }

        public static bool divisores(int n, int cont) => (n % cont) == 0 ? true : false;
        //Este metodo retorna una variable booleana. Si la variable cont es divisor de n se retorna true, y si no lo es retorna false



    }
}
