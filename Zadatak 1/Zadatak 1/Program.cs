using System;
 
/* Napišite program koji će provjeriti jesu li vrijednosti sadržane u int
varijablama x, y i z stranice pravokutnog trokuta. U program uključite i provjeru da
vrijednosti varijabli za ovakav primjer imaju smislene vrijednosti (iznosi moraju biti
veći od 0).*/
namespace Zadatak_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            do
            {
                Console.WriteLine("Unesi 1. katetu pravokutnog trokuta: ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Unesi 2. katetu pravokutnog trokuta: ");
                y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Unesi hipotenuzu pravokutnog trokuta: ");
                z = Convert.ToInt32(Console.ReadLine());

                if (x < 0 || y < 0 || z < 0)
                {
                    Console.WriteLine("Drugi put unesi smislene, tj. pozitivne vrijednosti!\n");
                }

                if (Math.Pow(x, 2) + Math.Pow(y, 2) != Math.Pow(z, 2))
                {
                    Console.WriteLine("To nije pravokutni trokut\n");
                }

            } while (Math.Pow(x, 2) + Math.Pow(y, 2) != Math.Pow(z, 2));

            Console.WriteLine("To je pravokutni trokut");
            Console.ReadKey();
        }

      
    }
}
