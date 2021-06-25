using System;

namespace Mob
{
    class Program
    {
        static void Main(string[] args)
        {
            string mon, mn, mb, mo;

            Console.WriteLine("==============Mobile=============");
            Console.WriteLine("Enter Mobile Owner Name: ");
            mon = Console.ReadLine();
            Console.WriteLine("Enter Mobile Number: ");
            mn = Console.ReadLine();
            Console.WriteLine("Enter Mobile Balance: ");
            mb = Console.ReadLine();
            Console.WriteLine("Enter Mobile OS Name: ");
            mo = Console.ReadLine();

            Console.WriteLine("\n----------------Successfully Submitted.-----------------\n");

            Mobile myMobile = new Mobile(mon,mn,mb,mo);
            myMobile.ShowInfo();

            int amn;
            Console.Write("\nEnter How much you want recharge:");
            amn = Convert.ToInt16(Console.ReadLine());

            myMobile.Recharge(amn);

            int time;
            Console.WriteLine("Enter Time Duration In Minute: ");
            time = Convert.ToInt16(Console.ReadLine());

            myMobile.CallSomeone(time);


        }
    }
}
