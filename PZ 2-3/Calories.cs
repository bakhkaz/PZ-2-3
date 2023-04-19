using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_2_3
{
    internal class Calories
    {
        int _first;
        double _second;
        public int First
        {
            get { return _first; }
            set { _first = value; }
        }
        public double Second
        {
            get { return _second; }
            set { _second = value; }
        }
        public double Power(int _first, double _second)
        {
            double P = (_second * 10) * _first;
            return P;
        }
        public void Read()
        {
            Console.WriteLine("Введите каллорийность в 100 г продкута");
            _first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Массу продутка");
            _second = Convert.ToDouble(Console.ReadLine());

        }
        public void Display()
        {
            Console.WriteLine($"Общая калорийность продукта {Power(_first, _second)}");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Calories cal = new Calories();
            cal.Read();
            cal.Display();
            Console.ReadKey();
        }

        
    }
}
