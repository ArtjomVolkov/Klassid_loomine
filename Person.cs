using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassid_loomine
{
    class Person
    {
        string fam;     // поле фамилия
        string status;  // поле статус
        int salary;     // поле зарплата
        int age;        // поле возраст 
        public string Fam  //свойство для поля фамилия
        {
            set { if (fam == null) fam = value; }     //код - установка значения поля фамилия
            get { return fam; }                     //код - чтение значения поля  фамилия
        }
        public int Age        //свойство для поля возраст
        {
            set                    //код - установка значения полей возраст и статус
            {
                age = value;
                if (age < 7) status = "ребенок";
                else if (age < 17) status = "школьник";
                else if (age < 22) status = "студент";
                else status = "служащий";

            }
            get { return (age); }       //код - чтение значения поля  возраст
        }
        public string Status  //свойство для поля статус
        {
            get { return status; }    // код - чтение поля статус
        }
        public int Salary  //свойство для поля зарплата
        {
            get { return salary; }  //код - чтение поля зарплата
            set { salary = value; }   //код - установка поля зарплата
        }
        public void Show()  // метод вывода значений полей
        {
            Console.WriteLine("Фамилия " + fam);
            Console.WriteLine("Возраст " + age);
            Console.WriteLine("Статус " + status);
            Console.WriteLine("Зарплата " + salary);
        }
    }
    class Programs
    {
        static void Main(string[] args)
        {
            int n = 0, i;
            Person[] pr = new Person[10];          //объявляем массив на 10 объектов класса Person
            for (i = 0; i < 10; i++)
            { pr[i] = new Person(); }     // создаем 10 объектов
            String s, subkey, key;
            do                               // выводим меню для работы с программой
            {
                Console.WriteLine("***Меню***");
                Console.WriteLine("1 - Ввод данных");
                Console.WriteLine("2 - Вывод данных");
                Console.WriteLine("3 - Поиск данных по возрасту");
                Console.WriteLine("4 - Выход");
                Console.WriteLine();
                Console.WriteLine("Ваш выбор...");
                key = Console.ReadLine();
                switch (key)
                {
                    case "1":               // ввод данных выполняется через соответствующие свойства
                        do
                        {

                            Console.WriteLine("Введите фамилию: ");
                            s = Console.ReadLine(); pr[n].Fam = s;
                            Console.WriteLine("Введите возраст: ");
                            s = Console.ReadLine(); pr[n].Age = int.Parse(s);
                            Console.WriteLine("Введите зарплату: ");
                            s = Console.ReadLine(); pr[n].Salary = int.Parse(s);
                            n++;                               // количество инициализорованных объектов
                            Console.WriteLine("Продолжить?(Y/N)...");
                            subkey = Console.ReadLine();
                        } while ((subkey == "y") || (subkey == "Y")); break;
                    case "2":               // вывод данных
                        for (i = 0; i < n; i++)
                        {
                            pr[i].Show();
                            Console.WriteLine();
                        }
                        break;
                    case "3":             // поиск данных по указанному возрасту
                        {
                            bool tr = true;
                            Console.WriteLine("Введите возраст для поиска: ");
                            s = Console.ReadLine(); int num = int.Parse(s);
                            for (i = 0; i < n; i++)
                                if (pr[i].Age == num)
                                {
                                    Console.WriteLine("Фамилия={0}, возраст={1}, статус={2}",
                                     pr[i].Fam, pr[i].Age, pr[i].Status);
                                    tr = false;
                                    Console.WriteLine();
                                }
                            if (tr) Console.WriteLine("С таким возрастом нет человека!");
                            Console.WriteLine();
                        }
                        break;
                }
            } while (key != "4");
        }
    }
}
