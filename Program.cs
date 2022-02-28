using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassid_loomine
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Inimene naine = new Inimene("Kask");
            naine.Vanus = int.Parse(Console.ReadLine());
            naine.Tervitamine();*/

            Inimene meehed = new Inimene();
            meehed.Perenimi = "Artjom";
            meehed.Eesnimi = "Volkov";
            meehed.Palk = 1500;
            meehed.Vanus = 45;
            meehed.Strana = "Russia";
            /*Console.WriteLine("Ma olen " + meehed.Eesnimi + " ja perekonnanimi " + meehed.Perenimi);
            Console.WriteLine("Ma olen " + meehed.Palk);*/
            meehed.Headaega();

            /*Inimene mees = new Inimene();
            mees.Perenimi = "Tamm";
            mees.Vanus = 45;
            Console.WriteLine(mees.Perenimi+ "on"+ mees.Vanus+ " aastane mees");
            mees.Tervitamine();

            Inimene[] inimesed = new Inimene[5];
            for (int i = 0; i < 5; i++)
            {
                inimesed[i] = new Inimene();
                Console.WriteLine("Mis on sinu nimi?");
                inimesed[i].Perenimi = Console.ReadLine();
                Console.WriteLine("Kui vana sa oled?");
                inimesed[i].Vanus = int.Parse(Console.ReadLine());
            }
            foreach (Inimene inimene in inimesed)
            {
                inimene.Tervitamine();
            }*/
            Console.ReadKey();
        }
    }
}
