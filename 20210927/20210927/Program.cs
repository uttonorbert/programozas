using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210927
{
    class Program
    {

        static void Main(string[] args)
        {
            //elsofeladat();//
            //masodikfeladat();//
            harmadikfeladat();
        }
            static void elsofeladat()
                { 
            Console.WriteLine("Adjon meg egy Hónapot");
            int szam = int.Parse(Console.ReadLine());


            if (szam == 1)
            {
                Console.WriteLine("Tél");

            }
            if (szam == 2)
            {
                Console.WriteLine("Tél");

            }
            if (szam == 3)
            {
                Console.WriteLine("Tavasz");

            }
            if (szam == 4)
            {
                Console.WriteLine("Tavasz");

            }
            if (szam == 5)
            {
                Console.WriteLine("Tavasz");

            }
            if (szam == 6)
            {
                Console.WriteLine("Nyár");

            }
            if (szam == 7)
            {
                Console.WriteLine("Nyár");

            }
            if (szam == 8)
            {
                Console.WriteLine("Nyár");

            }
            if (szam == 9)
            {
                Console.WriteLine("Ősz");

            }
            if (szam == 10)
            {
                Console.WriteLine("Ősz");

            }
            if (szam == 11)
            {
                Console.WriteLine("Ősz");

            }
            if (szam == 12)
            {
                Console.WriteLine("Tél");

            }
            if (szam > 12)
            {
                Console.WriteLine("Nem jó az érték");

            }
            Console.ReadLine();
}



        static void masodikfeladat() {
            int szam = int.Parse(Console.ReadLine());
            if (szam == 1)
            {
                Console.WriteLine("Január");

            }
            if (szam == 2)
            {
                Console.WriteLine("február");

            }
            if (szam == 3)
            {
                Console.WriteLine("Március");

            }
            if (szam == 4)
            {
                Console.WriteLine("Április");

            }
            if (szam == 5)
            {
                Console.WriteLine("Május");

            }
            if (szam == 6)
            {
                Console.WriteLine("Június");

            }
            if (szam == 7)
            {
                Console.WriteLine("Július");

            }
            if (szam == 8)
            {
                Console.WriteLine("augusztus");

            }
            if (szam == 9)
            {
                Console.WriteLine("Szeptember");

            }
            if (szam == 10)
            {
                Console.WriteLine("Október");

            }
            if (szam == 11)
            {
                Console.WriteLine("November");

            }
            if (szam == 12)
            {
                Console.WriteLine("December");

            }
            if (szam > 12)
            {
                Console.WriteLine("Nem jó az érték");

            }
            Console.ReadLine();
 }
        static void harmadikfeladat() { 

            Console.WriteLine("Kérek egy jegyet");
            int jegy = int.Parse(Console.ReadLine());
            if (jegy < 2)
            {
                Console.WriteLine("megbukott");
            }
            else
            {
                Console.WriteLine("átment");
            }
            Console.ReadLine();
}





           
    }   }

