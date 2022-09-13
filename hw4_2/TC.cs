using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace hw4_2
{
    abstract class TC
    {
        public string Stamp { get; set; } 
        public string Model { get; set; } 
        public int Cost { get; set; } 
        public TC(string _Stamp, string _Model, int _Cost)
        {
            Stamp = _Stamp;
            Model = _Model;
            Cost = _Cost;
        }

        public virtual void Print()
        {
            Write($"\nМарка: {Stamp} Модель: {Model} Стоимость: {Cost} руб.");
        }
        public abstract void Work();
    }

    abstract class Ground:TC
    {
        public string Type { get; set; }
        public Ground(string _Stamp, string _Model, int _Cost, string _Type):base(_Stamp, _Model, _Cost)
        {
            Type = _Type;
        }
        public override void Print()
        {
            base.Print();
            Write($" Тип: {Type}");
        }
        public override void Work()
        {
            Write("Наземный транспорт. ");
        }
    }

    class Passenger: Ground
    {
        public int PassengerNumbers { get; set; }
        public Passenger(string _Stamp, string _Model, int _Cost, string _Type, int _PassengerNumbers) : base(_Stamp, _Model, _Cost, _Type)
        {
            PassengerNumbers = _PassengerNumbers;
        }
        public override void Print()
        {
            base.Print();
            WriteLine($" Количество пассажиров: {PassengerNumbers} чел.");
        }
        public override void Work()
        {
            base.Work();
            Write("Легковой. ");
        }
    }

    class Cargo : Ground
    {
        public int Capacity { get; set; }
        public Cargo(string _Stamp, string _Model, int _Cost, string _Type, int _Capacity) : base(_Stamp, _Model, _Cost, _Type)
        {
            Capacity = _Capacity;
        }
        public override void Print()
        {
            base.Print();
            WriteLine($" Грузоподъемность: {Capacity} т");
        }
        public override void Work()
        {
            base.Work();
            Write("Грузовой. ");
        }

    }

    class Moto: Ground
    {
        public int Power { get; set; }
        public Moto(string _Stamp, string _Model, int _Cost, string _Type, int _Power) : base(_Stamp, _Model, _Cost, _Type)
        {
            Power = _Power;
        }
        public override void Print()
        {
            base.Print();
            WriteLine($" Мощность: {Power} л.с.");
        }
        public override void Work()
        {
            base.Work();
            Write("Мотоцикл. ");
        }
    }

    abstract class Air : TC
    {
        public int NumberEngines { get; set; }
        public Air(string _Stamp, string _Model, int _Cost, int _NumberEngines) : base(_Stamp, _Model, _Cost)
        {
            NumberEngines = _NumberEngines;
        }
        public override void Print()
        {
            base.Print();
            Write($" Вид: {NumberEngines}");
        }
        public override void Work()
        {
            Write("Воздушный транспорт. ");
        }
    }

    class Plane: Air
    {
        public int Distance { get; set; }
        public Plane(string _Stamp, string _Model, int _Cost, int _NumberEngines, int _Distance) : base(_Stamp, _Model, _Cost, _NumberEngines)
        {
            Distance = _Distance;
        }
        public override void Print()
        {
            base.Print();
            WriteLine($" Дальность: {Distance} км");
        }
        public override void Work()
        {
            base.Work();
            Write("Самолет. ");
        }
    }

    class Helicopter : Air
    {
        public int NumberScrews { get; set; }
        public Helicopter(string _Stamp, string _Model, int _Cost, int _NumberEngines, int _NumberScrews) : base(_Stamp, _Model, _Cost, _NumberEngines)
        {
            NumberScrews = _NumberScrews;
        }
        public override void Print()
        {
            base.Print();
            WriteLine($" Количество несущих винтов: {NumberScrews}");
        }
        public override void Work()
        {
            base.Work();
            Write("Вертолет. ");
        }
    }

    class Airship : Air
    {
        public string FillingGas { get; set; }
        public Airship(string _Stamp, string _Model, int _Cost, int _NumberEngines, string _FillingGas) : base(_Stamp, _Model, _Cost, _NumberEngines)
        {
            FillingGas = _FillingGas;
        }
        public override void Print()
        {
            base.Print();
            WriteLine($" Заполняющий газ: {FillingGas}");
        }
        public override void Work()
        {
            base.Work();
            Write("Дирижабль. ");
        }
    }

    
}
