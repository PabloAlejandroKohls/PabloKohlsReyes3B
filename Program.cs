using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PabloKohls3eroB
{
    class Program
    {
        static void Main(string[] args)
        {
            //lista de numeros aleatorios
            Random random = new Random();
            List<int> ListaKhol = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                ListaKhol.Add(random.Next(50,53));
            }
            foreach (var item in ListaKhol)
            {
                Console.WriteLine(item);
            }

            // numeros primos
            (from k in ListaKhol where Primo(k) select k).
                ToList().
                ForEach(k => Console.WriteLine("Numero Primo   {0}",k));

            // la suma de todos los elementos 

          var suma=ListaKhol.Sum();
            Console.WriteLine("la suma es {0} ",suma);

            //Generar una nueva lista con el cuadrado de los numeros  Math.Pow

            List<int> NumerosCuadrado = new List<int>();

            ListaKhol.ForEach(k => { NumerosCuadrado.Add(k*k); });
            NumerosCuadrado.ForEach(k => 
            Console.WriteLine("Numero Elevado al cuadrado   {0}",k));

            //Generar una nueva lista con los numeros primos

            List<int> NumerosPrimos = new List<int>();
            var lisPri = from k in ListaKhol where Primo(k) select k;
            foreach (var primos in lisPri)
            {
                NumerosPrimos.Add(primos);
            }

            // optener el promedio de todos los numeros mayores a 50 

            var Mayores = from k in ListaKhol where k > 50 select k;
            foreach (var item in Mayores)
            {
                Console.WriteLine(item);
            }
            var Promedio = Mayores.Average();
            Console.WriteLine("Promedio de numeros mayores a 50: {0}", Promedio);

            // contar la cantidad de numeros pares eh impares
            var par = from k in ListaKhol where Par(k) select k;
            var pares =par.Count();
            Console.WriteLine("Cantidad pares: {0}", pares);

            var Impar = from k in ListaKhol where !Par(k) select k;
            var im = par.Count();
            Console.WriteLine("Cantidad de impares: {0}", im);

            // mostrar en consola el numero y la cantidad de veces que este se encuentra en la lista

            foreach (var item in ListaKhol)
            {
                Console.WriteLine("Numeros:  {0}", item);
                
            }

            //mostrar en consola los Numeros de forma descendente

            var descendente = from a in ListaKhol orderby a descending select a;
            Console.WriteLine("numeros de forma descendente");
            foreach (var item in descendente)
            {
                Console.WriteLine(item);
            }

            // mostrar en consola los numeros unicos 

            var Unicos = from k in ListaKhol select 



            Console.ReadKey();


        }
        public static Boolean Primo(int num)
        {
            return num % 2 != 0;
        }
        static bool Par(int num)
        {
            return num % 2 == 0;
        }
    }
    
}
