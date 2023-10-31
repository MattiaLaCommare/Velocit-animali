using System.Security.Cryptography.X509Certificates;

namespace Velocità_animali
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a1, a2;
            int vb1 = 0, vb2 = 0;
            Random v1 = new Random(), v2 = new Random();
            int dp1 = 0, dp2 = 0;
            int crono = 60;

            Console.WriteLine("dai un nome al tuo animale");
            a1 = Console.ReadLine();
            Console.WriteLine("chiama il tuo animaletto");
            a2 = Console.ReadLine();
            Console.WriteLine("quanto è veloce? " + a1);
            vb1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("quanto corre? " + a2);
            vb2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(a1 + ", " + vb1 + " di velocita");
            Thread.Sleep(1000);
            Console.WriteLine(a2 + ", " + vb2 + " di velocita");
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.WriteLine("LA CORSA INIZIA!");
            Console.WriteLine();
            for (int i = 1; i <= crono; i++)
            {
               
                dp1 = v1.Next(1,41) + vb1;
                dp2 = v2.Next(1,41) + vb2;
                vb1 = dp1;
                vb2 = dp2;
                Thread.Sleep(2000);
                Console.WriteLine("siamo al " + i + "° secondo");
                Console.WriteLine(a1 + " è a: " + dp1 + " metri!");
                Console.WriteLine(a2 + " è a: " + dp2 + " metri!");
                Console.WriteLine();
            }
            Thread.Sleep(2000);
            if (dp1 > dp2)
            {
                Console.WriteLine(a1);
                Thread.Sleep(1000);
                Console.WriteLine(vb1 + " metri");
                Thread.Sleep(2000);
                Console.WriteLine("HA VINTO LA GARA!!");
            }
            if (dp1 < dp2)
            {
                Console.WriteLine(a2);
                Thread.Sleep(1000);
                Console.WriteLine(vb2 + " metri");
                Thread.Sleep(2000);
                Console.WriteLine("HA VINTO LA GARA!!");
            }
            if (dp1 == dp2)
            {
                Console.WriteLine("e.......");
                Thread.Sleep(2000);
                Console.WriteLine("PAREGGIOO!!");
            }

        }
    }
}