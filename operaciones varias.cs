using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operacionesvarias
{
    class Program
    {
        static void Main(string[] args)
        {

            int op = 0;
            double a, r, t, y, u, suma = 0, resta = 0, multi = 0, divi = 0, prom = 0; ;

            do
            {

                Console.Clear();
                Console.WriteLine("OPERACIONES MULTIPLES");
                Console.WriteLine("\n");
                Console.WriteLine("1.Suma");
                Console.WriteLine("2.Resta");
                Console.WriteLine("3.Multiplicación");
                Console.WriteLine("4.División");
                Console.WriteLine("5.Promedio de notas");
                Console.WriteLine("\n");


                Console.Write("Inserte la opción deseada:");
                op = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("\n");

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Suma");
                        Console.Write("Inserte el primer valor:");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Inserte el segundo valor:");
                        r = Convert.ToDouble(Console.ReadLine());
                        suma = (a + r);
                        Console.WriteLine("\n");
                        Console.WriteLine("El resultado de la suma es: " + suma);
                        break;

                    case 2:
                        Console.WriteLine("Resta");
                        Console.Write("Inserte el primer valor:");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Inserte el segundo valor:");
                        r = Convert.ToDouble(Console.ReadLine());
                        resta = (a - r);
                        Console.WriteLine("\n");
                        Console.WriteLine("El resultado de la resta es: " + resta);
                        break;

                    case 3:
                        Console.WriteLine("Multiplicación");
                        Console.Write("Inserte el primer valor:");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Inserte el segundo valor:");
                        r = Convert.ToDouble(Console.ReadLine());
                        multi = (a * r);
                        Console.WriteLine("\n");
                        Console.WriteLine("El resultado de la Multiplicación es: " + multi);
                        break;

                    case 4:
                        Console.WriteLine("División");
                        Console.Write("Inserte el primer valor:");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Inserte el segundo valor:");
                        r = Convert.ToDouble(Console.ReadLine());
                        divi = (a / r);
                        Console.WriteLine("\n");
                        Console.WriteLine("El resultado de la división es: " + divi);
                        break;

                    case 5:
                        Console.WriteLine("Promedio de 5 notas");

                        Console.Write("Inserte la primera nota:");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Inserte la segunda nota:");
                        r = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Inserte la tercera nota:");
                        t = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Inserte la cuarta nota:");
                        y = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Inserte la quinta nota:");
                        u = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("\n");

                        prom = (a + r + t + y + u) / 5;

                        if (prom == 0 || prom <= 59) { Console.WriteLine(" *F* "); }
                        else if (prom == 60 || prom <= 69) { Console.WriteLine(" *D* "); }
                        else if (prom == 70 || prom <= 79) { Console.WriteLine(" *C* "); }
                        else if (prom == 80 || prom <= 89) { Console.WriteLine(" *B* "); }
                        else if (prom == 90 || prom <= 100) { Console.WriteLine(" *A* "); }
                        else if (prom > 100) { Console.WriteLine(" *Este valor no es válido. El rango a utilizar va de 0 (F) a 100 (A)*"); }
                        Console.WriteLine("\n");
                        Console.Write("El promedio de todas las notas es igual a: " + prom);
                        break;


                    default:
                        Console.Write("*----El numero que ha introducido no es valido----*");
                        break;

                }


                Console.ReadKey();

            } while (op != 5);
        }
    }

}
