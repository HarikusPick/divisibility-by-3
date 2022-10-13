using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, basla, bitis, i; 
            Console.WriteLine("1.sayı girin");
            sayi1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("2.sayı girin");
            sayi2 = Convert.ToInt16(Console.ReadLine());
             basla = sayi1;
             bitis = sayi2;
            if (sayi1 > sayi2) { basla = sayi2; bitis = sayi1; }
            Console.Clear();
            for (i = basla; i <= bitis; i++)
            {
              
                if (i % 3 == 0) Console.WriteLine( ""+ i);
                
            }
            Console.ReadKey();
            
        }
    }
}
