using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassid_loomine
{
    class Opilane : Inimene
    {
        string ruhm;
        double hinne;
        bool toetus;
        public Opilane() { }
        public Opilane(string Eesnimi, string Perenimi, string Ruhm):base(Eesnimi,Perenimi)
        {
            ruhm = Ruhm;
        }
        public string Ruhm
        {
            set { ruhm = value; }
            get { return ruhm; }
        }
        public double Hinne
        {
            set { if (value > 0 && value <= 5) hinne = value; }
            get { return hinne; }
        }
        public bool Toetus
        {
            get
            {
                if (hinne>3.3)
                {
                    toetus = true;
                }
                else
                {
                    toetus = false;
                }
                return toetus;
            }
        }
        public void Informatsioon()
        {
            string t = "";
            Console.WriteLine("Tere! Minu nimi on {0} {1}", Eesnimi, Perenimi);
            if (Toetus==true)
            {
                t = "Saan toetust kätte :)";
            }
            else if (Toetus==false && hinne>0)
            {
                t = "Ei saa toetust :(";
            }
            else
            {
                t = "Andem hinnetest puuduvad";
            }
            Console.WriteLine("Minu keskmine hinne on {0}. {1}", hinne, t);
        }
        public override void Kes_ma_olen()
        {
            Console.WriteLine("Ma olen õpilane!");
        }
    }
}
