using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ZavrsniTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //inicijalizacija je kada promenljivoj dodelimo vredonost
            int broj=5;

            //inicijalizacija niza stringova od 25 elemenata
            string[] niz = new string[25];
            for(int i=0; i< niz.Length; i++)
            {
                niz[i] = "Elemenat" + i;
            }

            foreach (var elemenat in niz)
            {
                Console.WriteLine(" ");
                Console.WriteLine(elemenat);
            }

            Console.WriteLine(" ");
            //program


            int x;
            Console.WriteLine("Upisati broj od 1 do 50");
            x = int.Parse(Console.ReadLine());

            if (x % 3 == 0 && x % 5 == 0)
            {
                Console.WriteLine("Cica Maca");
            }

            else if (x % 3 == 0)
            {
                Console.WriteLine("Cica");
            }

            else if (x % 5 == 0)
            {
                Console.WriteLine("Maca");
            }


            Console.ReadLine();

        }



    }
}
