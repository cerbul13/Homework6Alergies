using System;

namespace Homework6Alergies
{
    public enum Alergies
    {
        eggs=1,
        peanuts=2,
        shellfish=4,
        strawberries=8,
        tomatoes=16,
        chocolate=32,
        pollen=64,
        cats=128
    }
    //256,512,1024,2048,4096,8192,16384,32768,65536,131072,262144,524288,
    class Program
    {
        public static int powerof2(int n)
        {
            if (n == 0) return 1;
            int pw = 2;
            for (int i=1;i<n;i++)
            {
                pw *= 2;
            }
            return pw;
        }
        static void Main(string[] args)
        {
            Console.Write("Introduceti score-ul lui Tom: ");
            int score = int.Parse(Console.ReadLine());//2147483647
            int sc = score;
            for (int i=30;i>=0;i--)
            {
                //Console.WriteLine($"2 la puterea a {i}-a este: {powerof2(i)}");
                int pw2 = powerof2(i);
                if (sc >= pw2)
                {
                    if (pw2 <= 128)
                    {
                        Alergies value; Enum.TryParse(pw2.ToString(), out value);
                        Console.WriteLine($"Tom este alergic la {value}");
                    }
                        sc = sc - pw2;
                }
            }
        }
    }
}
