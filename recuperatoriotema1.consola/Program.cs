using System.Runtime.Intrinsics.Arm;

namespace recuperatoriotema1.consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double AreaBase, AreaAltura, AreaAncho, Area, Volumen, Diagonal, contador;
            int largo, altura, ancho;
                contador = 0;
            try
            {
                do

                {
                    Console.Write("Ingresar el largo del prisma (PONER 0 EN LARGO, ALTURA Y ANCHO PARA FINALIZAR): ");
                    largo = int.Parse(Console.ReadLine());
                    Console.Write("Ingresar la altura del prisma (PONER 0 EN LARGO, ALTURA Y ANCHO PARA FINALIZAR): ");
                    altura = int.Parse(Console.ReadLine());
                    Console.Write("Ingresar el ancho del prisma (PONER 0 EN LARGO, ALTURA Y ANCHO PARA FINALIZAR): ");
                    ancho = int.Parse(Console.ReadLine());
                    if (largo > 0 && altura > 0 && ancho > 0)
                    {
                        contador = contador + 1;
                        AreaBase = sacarab(largo, ancho);
                        AreaAltura = sacarah(altura, ancho);
                        AreaAncho = sacaraa(altura, largo);
                        Area = sacararea(AreaAltura, AreaAncho, AreaBase);
                        Volumen = sacarvolumen(largo, ancho, altura);
                        Diagonal = sacardiagonal(largo, ancho, altura);
                        Console.WriteLine($"El Area del prisma es de  {Area} ");
                        Console.WriteLine($"El Volumen del prisma es de {Volumen}");
                        Console.WriteLine($"La Diagonal del prisma es de {Diagonal}");
                        Console.WriteLine($"Se van ingresando {contador} Prismas");
                    }
                } while (!(largo == 0 && altura == 0 && ancho == 0));
                Console.WriteLine($"Se ingresaron una cantidad de {contador} Prismas");
            }
            catch (Exception)
            {

                Console.WriteLine("numero ingresado no es valido");
            }
        }

        private static double sacararea(double areaaltura, double areaancho, double areabase)
        {
            double resultado;
            resultado = 2 * (areabase + areaaltura + areaancho);
            return resultado;
        }

        private static double sacarvolumen(double largo, double ancho, double altura)
        {
            double resultado;
            resultado = largo * ancho * altura;
            return resultado;
        }

        private static double sacardiagonal(double largo, double ancho, double altura)
        {
            double resultado;
            resultado = Math.Sqrt(Math.Pow(largo, 2) + Math.Pow(ancho, 2) + Math.Pow(altura, 2));
            return resultado;
        }
        private static double sacaraa(double altura, double largo)
        {
            double resultado;
            resultado = altura * largo;
            return resultado;
        }

        private static double sacarah(int altura, int ancho)
        {
            double resultado;
            resultado = altura * ancho;
            return resultado;
        }

        private static double sacarab(int largo, int ancho)
        {
            double resultado;
            resultado = largo * ancho;
            return resultado;
        }
    }
    }
