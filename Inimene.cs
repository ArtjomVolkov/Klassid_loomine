using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassid_loomine
{
    class Inimene
    {
        string perenimi;
        string staatus;
        int vanus;
        int palk;
        string eesnimi;
        string palga;
        string strana;
        public Inimene() { }
        public Inimene(string Perenimi)
        {
            perenimi = Perenimi;
        }
        public string Strana
        {
            set { if (strana == null) strana = value; }
            get { return strana; }
        }
        public string Eesnimi
        {
            set { if (eesnimi == null) eesnimi = value; }
            get { return eesnimi; }
        }
        public int Palk
        {
            set
            {
                palk = value;
                if (palk<500)
                {
                    palga = "bednij";
                }
                else if (palk<1500)
                {
                    palga = "normalne";
                }
                else
                {
                    palga = "bogatij";
                }
            }
            get { return palk; }
        }
        public string Palga
        {
            get { return palga; }
        }
        public string Perenimi
        {
            set { if (perenimi == null) perenimi = value; }
            get { return perenimi; }
        }
        public int Vanus
        {
            set 
            {
                vanus = value;
                if (vanus<7)
                {
                    staatus = "laps";
                }
                else if (vanus<17)
                {
                    staatus = "kooli laps";
                }
                else if (vanus<24)
                {
                    staatus = "ülikooli laps";
                }
                else
                {
                    staatus = "tööline";
                }
            }
            get { return vanus; }
        }
        public string Staatus
        {
            get { return staatus; }
        }
        public void Tervitamine()
        {
            Console.WriteLine("Tere! Minu perenimi on " + perenimi);
            Console.WriteLine("Ma olen {0} aastat vana, olen {1}",vanus,staatus);
        }
        public void Headaega()
        {
            Console.WriteLine("Tere! Minu eesnimi on {0} ja perenimi {1}", eesnimi, perenimi);
            Console.WriteLine("Ma olen {0} aastat vana, olen {1}", vanus, staatus);
            Console.WriteLine("Minu palk on " + palga);
            Console.WriteLine("Ma elan " + strana);
        }
    }
}
