using System;
namespace hej
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in två tal");
            int tal1 = int.Parse(Console.ReadLine());
            int tal2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Största talet var " + Störst(tal1, tal2));
        }
        static int Störst(int tal1, int tal2)
        {
            if (tal1 >= tal2)
            {
                return tal1;
            }
            else
            {
                return tal2;
            }
        }
    }
}