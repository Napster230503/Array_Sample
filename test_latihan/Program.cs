using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int lengthOfcontoh;
            String[] contoh = new string[4]
            {
                "Agus", "Budi", "Setiawan", "Zulkarnain"
            };
            lengthOfcontoh = contoh.Length;
            Console.WriteLine("-----------------");
            Console.WriteLine("Array With 'FOR' Version 1");
            Console.WriteLine("-----------------");




            for (int k = 0; k < lengthOfcontoh; k++)
            {
                Console.WriteLine(contoh[k]);
            }
            Console.WriteLine("-----------------");
            Console.WriteLine("Array With Foreach");
            Console.WriteLine("-----------------");
            foreach (string contoh1 in contoh)
            {
                Console.WriteLine(contoh1);
            }




            Console.WriteLine("-----------------");
            Console.WriteLine("array With For");
            Console.WriteLine("-----------------");
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine(contoh[i]);
            }




            Console.WriteLine("-----------------");
            Console.WriteLine("Array With 'FOR' Version 2");
            Console.WriteLine("-----------------");
            string[] weekDays2 = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            for (int j = 0; j < 7; j++)
            {
                Console.WriteLine(weekDays2[j]);
            }




            int a;
            int lengthOfbrand;
            String[] brand = new string[4]
            {
                "Toyota", "Mitsubishi", "Subaru", "Nissan"
            };
            lengthOfbrand = brand.Length;


            Console.WriteLine("-----------------");
            Console.WriteLine("SAMPLE");
            Console.WriteLine("-----------------");




            for (int k = 0; k < lengthOfbrand; k++)
            {
                Console.WriteLine(brand[k]);
            }


            Console.ReadKey();

        }
    }
}