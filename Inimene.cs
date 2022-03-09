using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassid_loomine
{
    public abstract class Inimene
    {
        string perenimi;
        //поле фамилии
        string staatus;
        //поле статуса
        int vanus;
        //поле возраста
        int palk;
        //зарплаты
        string eesnimi;
        //поле имя
        string palga;
        //поле зарплаты
        string strana;
        //поле страны
        Emakeel emakeel;
        public Inimene() { } //пустой конструктор
        public Inimene(string Perenimi,Emakeel emakeel) //свойство для поля фамилия и языка
        {
            perenimi = Perenimi;
            this.emakeel = emakeel;
        }
        public Emakeel Emakeel //свойство для языка
        {
            get { return emakeel; } // код - чтение поля язык
        }
        public Inimene(string Perenimi,string Eesnimi) //свойство для поля фамилия
        {
            perenimi = Perenimi;
            eesnimi = Eesnimi;
        }
        public string Strana //свойство для поля страны
        {
            set { if (strana == null) strana = value; } // код - чтение поля страны
            get { return strana; } //код - установка поля страны
        }
        public string Eesnimi //свойство для поля имя
        {
            set { if (eesnimi == null) eesnimi = value; } // код - чтение поля имя
            get { return eesnimi; } //код - установка поля имя
        }
        public int Palk //свойство для поля зарплаты
        {
            set // код - чтение поля зарплаты
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
            get { return palk; } //код - установка поля зарплаты
        }
        public string Palga //свойство для поля зарплаты(txt)
        {
            get { return palga; } // код - чтение поля зарплаты
        }
        public string Perenimi //свойство для поля фамилии
        {
            set { if (perenimi == null) perenimi = value; } // код - чтение поля фамилии
            get { return perenimi; } //код - установка поля фамилии
        }
        public int Vanus //свойство для поля возраста
        {
            set // код - чтение поля возраста
            {
                vanus = value;
            }
            get { return vanus; } //код - установка поля возраста
        }
        public string Staatus //свойство для поля статуса
        {
            get //код - установка поля статуса
            { 
                
                if (vanus < 7)
                {
                    staatus = "laps";
                }
                else if (vanus < 17)
                {
                    staatus = "kooli laps";
                }
                else if (vanus < 24)
                {
                    staatus = "ülikooli laps";
                }
                else
                {
                    staatus = "tööline";
                }
                return staatus; }
        }
        public void Tervitamine()  // метод вывода значений полей
        {
            Console.WriteLine("Tere! Minu perenimi on " + perenimi); //Вывод на экран фамилии
            Console.WriteLine("Ma olen {0} aastat vana, olen {1}",vanus,staatus); //Вывод на экран возраст и статус
        }
        public void Headaega() // метод вывода значений полей
        {
            if (perenimi != null && eesnimi != null)
            {
                Console.WriteLine("Tere! Minu eesnimi on {0} ja perenimi on {1}", eesnimi, perenimi); //Вывод на экран фамилии и имя
            }
            else if (perenimi == null && eesnimi != null)
            {
                Console.WriteLine("Tere! Minu eesnimi on {0}", eesnimi); //Вывод на экран имя
            }
            else if (eesnimi == null && perenimi != null)
            {
                Console.WriteLine("Tere! Minu perenimi on {0}", perenimi); //Вывод на экран фамилии
            }
            else
            {
                Console.WriteLine("Tere! Sõber"); //Вывод на экран текст
            }
            if (vanus==0 && staatus==null)
            {
                Console.WriteLine("Ma olen ROOBOT!"); //Вывод на экран текст
            }
            else
            {
                Console.WriteLine("Ma olen {0} aastat vana, olen {1}", vanus, Staatus); //Вывод на экран возраст и статус
            }
            Console.WriteLine("Minu palk on " + palga); //Вывод на экран зарплату
            Console.WriteLine("Ma elan " + strana); //Вывод на экран страну
        }
        public double Sotsialmaks() // метод вывода значений полей
        {
            double sots = 0;
            sots = palk * 0.33;
            return sots;
        }
        public abstract void Kes_ma_olen();
    }
}
