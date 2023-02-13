using System;

namespace CalcularAreaFiguras
{
    public class Program
    {
        static void Main(string[] args)
        {
            int op, altura, b, radio;
            do
            {
                Console.WriteLine("\n1. Cuadrado\n" +
                    "2. Circulo\n" +
                    "3. Rectangulo\n" +
                    "4. Triangulo\n" +
                    "5. Salir");
                Console.WriteLine("Introduzca una opcion: ");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        //Pedimos la longitud del lado del cuadrado e invocamos al metodo Cuadrilateros() que nos devolvera su perimetro
                        Console.WriteLine("Introduzca la longitud del lado del cuadrado: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El area es de " + Cuadrilateros(b, b));
                        break;

                    case 2:
                        //Pedimos la longitud del radio del circulo e invocamos al metodo Circulo() que nos devolvera su perimetro
                        Console.WriteLine("Introduzca el radio del circulo: ");
                        radio = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El area es de " + Circulo(radio));  
                        break;

                    case 3:
                        //Pedimos la longitud de la base y de la altura del rectangulo e invocamos al metodo Cuadrilateros() que nos devolvera su perimetro
                        Console.WriteLine("Introduzca la longitud de la base del rectangulo: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Introduzca la longitud de la altura del rectangulo: ");
                        altura = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El area es de " + Cuadrilateros(b, altura));
                        break;

                    case 4:
                        //Pedimos la longitud de la base y de la altura del triangulo e invocamos al metodo Triangulo() que nos devolvera su perimetro
                        Console.WriteLine("Introduzca la longitud de la base del triangulo: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Introduzca la longitud de la altura del triangulo: ");
                        altura = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El area es de " + Triangulo(b, altura));
                        break;

                    case 5:
                        Console.WriteLine("Fin del programa");
                        break;

                    default:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                }


            } while (op != 5);
        }
        public static double Cuadrilateros(int b, int altura) => (b * altura);
        //Con este metodo calculamos el area de cualquier cuadrilatero a partir de su formula (Base * altura)

        public static double Circulo(int radio) => (Math.Pow(radio, 2) * Math.PI);
        //Con este metodo calculamos el area de cualquier Circulo a partir de su formula (π * radio²)

        public static double Triangulo(int b, int altura) => (b * altura) / 2;
        //Con este metodo calculamos el area de cualquier Triangulo a partir de su formula (Base * altura / 2)

    }
}
