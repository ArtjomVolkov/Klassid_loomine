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
            Inimene i = new Opilane("Anna", "Tamm", "Tarpv21");
            i.Kes_ma_olen();
            i.Tervitamine();
            Inimene[] inim = new Inimene[4];

            inim[0] = new Opetaja();
            inim[0].Kes_ma_olen();
            inim[1] = new Opilane();
            inim[1].Kes_ma_olen();
            inim[2] = new Opetaja();
            inim[2].Kes_ma_olen();
            inim[3] = new Opilane();
            inim[3].Kes_ma_olen();
            /*Opilane opin = new Opilane();
            Console.WriteLine("Mis on sinu nimi? => ");
            opin.Eesnimi =Console.ReadLine();
            //opin.Eesnimi = "Artjom";
            Console.WriteLine("Mis on sinu perenimi ? => ");
            opin.Perenimi = Console.ReadLine();
            Console.WriteLine("Mis on sinu hinne? => ");
            opin.Hinne = int.Parse(Console.ReadLine());
            opin.Informatsioon();*/
            /*Inimene naine = new Inimene("Kask");
            naine.Vanus = int.Parse(Console.ReadLine());
            naine.Tervitamine();*/

            /*Inimene meehed = new Inimene();
            meehed.Perenimi = "Volkov";
            meehed.Eesnimi = "Artjom";
            meehed.Palk = 1000;
            meehed.Vanus = 45;
            meehed.Strana = "Russia";
            double s = meehed.Sotsialmaks();
            Console.WriteLine("{0} Euro", s);*/

            /*Console.WriteLine("Ma olen " + meehed.Eesnimi + " ja perekonnanimi " + meehed.Perenimi);
            Console.WriteLine("Ma olen " + meehed.Palk);*/
            //meehed.Headaega();

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
