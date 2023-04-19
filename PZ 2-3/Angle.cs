using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_2_3
{
    internal class Angle
    {
        private int _degrees;
        private int _minutes;

        public int Degrees
        {
            get
            {
                return _degrees;
            }
            set
            {
                if (value > 360 && value < 0)
                {
                    _degrees = 0;
                }
                else _degrees = value;
            }
        }
        public int Minutes
        {
            get
            {
                return _minutes;
            }
            set
            {
                if (value >= 60)
                {
                    _degrees++;
                    _minutes = 0;
                }
                else _minutes = value;
            }
        }
        public Angle(int degrees, int minutes)
        {
            Prov(degrees, minutes);
        }
        public Angle() { }
        private void Prov(int degrees, int minutes)
        {
            if (minutes >= 60)
            {
                _degrees++;
                _minutes = 0;
            }
            else _degrees = minutes;

            if (degrees > 360 || degrees < 0)
            {
                _degrees = 0;
            }
            else _degrees = degrees;
        }
        public void Plus(int Graduse)
        {
            _degrees += Graduse;
            Display();
        }
        public void Minus(int Graduse)
        {
            _degrees -= Graduse;
            Display();
        }
        public void Display()
        {
            Console.WriteLine($"Градусов {_degrees} минут {_minutes}");
        }
        public void Read()
        {
            Console.WriteLine("Введите Градусы");
            _degrees = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите минуты");
            _minutes = Convert.ToInt32(Console.ReadLine());

            Prov(_degrees, _minutes);
        }
        public void Sin()
        {
            double i = Math.Sin(_degrees);
            Console.WriteLine($"Синус угла {i}");
        }
        public void Compare(Angle ang)
        {
            if (this._degrees == ang.Degrees && this._minutes == ang.Minutes)
            {
                Console.WriteLine("Одинаковы");
                return;
            }
            Console.WriteLine("Разные");


        }
        public void Casting()
        {
            Console.WriteLine($"Родиан {_degrees * (Math.PI / 180)}");
        }
    }
}
