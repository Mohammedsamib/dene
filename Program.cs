using System;

namespace The_first_one
{
    class Program
    {
        static int Toplam()
        {
            int x = 6, y = 6;
            return x + y;
        }
      
        static void Main(string[] args)
        {
            calisan c1 = new calisan() ;

            c1.Code = "XCWEWE";
            c1.name = "Mohammed";
            c1.telefon = "05524677219";
            c1.salary = 7500;
            c1.printdata();
            calisan c2 = new calisan();

            c2.Code = "RTRRT";
            c2.printdata();

            Console.ReadKey();



        }
    }
}
