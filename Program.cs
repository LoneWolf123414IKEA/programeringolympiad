using System;
namespace kap3upp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp = Console.ReadLine();
            int temp = 0;
            int sto;
            int cnt = 0;
            int cnt1 = 0;
            foreach(int i in inp)
            {
                sto = temp;
                temp = i - 48;
                if (sto == 1 || sto == 2)
                {
                    if (temp == 1 || temp == 2)
                    {
                        cnt1++;
                    }
                    else
                    {
                        cnt++;
                    }
                }
            }
            Console.WriteLine(cnt + " " + cnt1);
        }
    }
}