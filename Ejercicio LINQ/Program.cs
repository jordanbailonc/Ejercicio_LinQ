using System;
using System.Collections;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;

namespace Ejercicio_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double[] numberarray = { 2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4 };
            //Fase 1
            Console.WriteLine("Fase 1");
            System.Collections.Generic.IEnumerable<double> lst = from d in numberarray
                                                              orderby d
                                                              where d%2==0
                                                              select d;
            foreach (var a in lst)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("--------");

            //Fase 2
            Console.WriteLine("FASE 2");

            double maximo = numberarray.Max();

            Console.WriteLine("Número Max:" + maximo);

            Console.WriteLine("--------");

            double minimo = numberarray.Min();

            Console.WriteLine("Número Min: " + minimo);

            Console.WriteLine("--------");

            double promedio = numberarray.Average();

            Console.WriteLine("Promedio:" + promedio);

            Console.WriteLine("--------");
            //Fase 3
            Console.WriteLine("Fase 3");
            Console.WriteLine("Aquí están los número más grandes a 5");
            System.Collections.Generic.IEnumerable<double> list3 = from g in numberarray
                                                                 where g >5
                                                                 orderby g
                                                                 select g;
            foreach (var i in list3)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("--------");

            Console.WriteLine("Aquí están los número más pequeños o iguales a 5");
            System.Collections.Generic.IEnumerable<double> list4 = from g in numberarray
                                                                   where g <= 5
                                                                   orderby g
                                                                   select g;
            foreach (var j in list4)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("--------");
            //Fase 4
            Console.WriteLine("Esta es la FASE 4");
            Console.WriteLine("Los nombres que empiezan con O:");
            string[] names = { "David", "Sergio", "Maria", "Laura", "Oscar", "Julia", "Oriol" };

            var sNameList = names.Where(x => x.StartsWith("O"));

            foreach (string m in sNameList)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine("--------");

            Console.WriteLine("Los nombres que tienen más de 6 carácteres:");
            System.Collections.Generic.IEnumerable<string> query =
                                                                from contact in names.AsEnumerable()
                                                                orderby contact.Length
                                                                where contact.Length>6
                                                                select contact;

            foreach (string n in query)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("--------");


            Console.WriteLine("Nombres ordenados de forma descendente:");
            System.Collections.Generic.IEnumerable<string> query2 =
                                                                from contact in names.AsEnumerable()
                                                                orderby contact.Length descending                                                        
                                                                select contact;
            foreach (var e in query2)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("--------");

            /*
            Console.WriteLine("Esta es una prueba para familiarizarme con LinQ");
            string[] postres = { "pastel de manzana", "pastel de chocolate", "manzana caramelizada", "fresas con nata" };
            System.Collections.Generic.IEnumerable<string> buscalo = from p in postres
                                          where p.Contains("manzana")
                                          orderby p
                                          select p;
            foreach (string postre in buscalo)
            {
                Console.WriteLine(postre);
            }*/



        }
    }
}
