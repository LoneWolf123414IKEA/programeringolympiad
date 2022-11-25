using System;
namespace kap3upp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How log does it take tor to eat?");
            int tor = int.Parse(Console.ReadLine());
            Console.WriteLine("How log does it take mom to eat?");
            int mom = int.Parse(Console.ReadLine());
            int tors = 0;
            int moms = 0;
            int torc = 1;
            int momc = 1;
            int crrts = 0;
            while (crrts<38)
            {
                if ((tors == tor) && (moms == mom) && (crrts == 37))
                {
                    break;
                }
                else if (tor == tors)
                {
                    tors = 0;
                    torc++;
                    crrts++;
                }
                if ((tors == tor) && (moms == mom) && (crrts == 39))
                {
                    break;
                }
                else if (mom == moms)
                {
                    moms = 0;
                    momc++;
                    crrts++;
                }
                moms++;
                tors++;
            }
            Console.WriteLine("tor ate " + torc + " carrots and mom ate " + momc + " carrots!");
        }
    }
}
