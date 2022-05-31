using System;
/*Napišite program koji će ispisati sve prijestupne godine u razdoblju od
(uključujući) 1900. do (uključujući) 2100. Prijestupne godine su one koje su djeljive sa
400 plus one koje su djeljive sa 4, ali ne i sa 100.*/
namespace Zadatak_2_
{
    class Program
    {
        static void Main(string[] args)
        {
           
            for(int i=1900;i<2101;i++)
            {
                if((i%400==0|| (i%4==0&&i%100!=0)))
                {
                    Console.WriteLine("Godina " + i + ". je prijestupna godina\n");
                }
            }
        }
    }
}
