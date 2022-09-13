using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace hw4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Passenger p1 = new Passenger("Volvo", "XC90", 7000000, "Кроссовер", 5);
            Cargo c1 = new Cargo("Hyundai", "HD78", 2900000, "Рефрижиратор", 5);
            Moto m1 = new Moto("Kawasaki", "Z 1000SX", 1400000, "Спорт-туризм", 142);

            Plane pl1 = new Plane("Zodiac", "CH 650", 3300000, 1, 925);
            Helicopter h1 = new Helicopter("McDonnel-Douglas", "MD 900 Explorer", 75000000, 2, 1);
            Airship a1 = new Airship("AY-30", "AY-30", 2500000, 2, "Гелий");

            Ground[] gr = { p1, c1, m1 };
            Air[] air = { pl1, h1, a1 };
            TC[] tc = { p1, c1, m1, pl1, h1, a1 };
            while (true)
            {
                WriteLine("Выберете действие, которое хотите произвести:\n " +
                    "1. Распечатать весь автопарк; \n " +
                    "2. Стоимость наземного транспорта; \n " +
                    "3. Стоимость воздушного транспорта; \n " +
                    "4. Стоимость всего автопарка; \n " +
                    "5. Выйти из программы.");
                WriteLine();

                int posnum = Convert.ToInt32(ReadLine());

                switch (posnum)
                {
                    case 1:
                        {
                            foreach (TC item in tc)
                            {
                                item.Work();
                                item.Print();
                                WriteLine();
                            };
                        }
                        break;
                    case 2:
                        {
                            WriteLine($"Стоимость всего наземного транспорта = {Sum(gr)}\n");
                        }
                        break;
                    case 3:
                        {
                            WriteLine($"Стоимость всего воздушного транспорта = {Sum(air)}\n");
                        }
                        break;
                    case 4:
                        {
                            WriteLine($"Стоимость всего парка ТС = {Sum(tc)}\n");
                        }
                        break;
                    case 5:
                        return;

                    default:
                        WriteLine("Вы выбрали несуществующий пункт меню. Выберите снова.");
                        continue;
                }
            }
        }

        static int Sum(TC[] ar)
        {
            int sum = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                sum += ar[i].Cost;
            }
            return sum;
        }
    }
}
