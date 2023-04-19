using PZ_2_3;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Angle ang = new Angle(180, 1);
        Angle ang1 = new Angle(350, 1);

        ang.Casting();

        ang.Compare(ang1);

        Console.ReadKey();


    }
}
