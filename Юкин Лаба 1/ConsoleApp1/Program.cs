using System;

namespace ConsoleApp1
{
    class Program
    {
       static int Checkout(int V)
        {
            return V;
        }
        static void Main(string[] args)
        {
            double V;
            int R, h;
            Console.WriteLine("Введіть радіус конуса");
            Console.WriteLine("R=");
            R = Convert.ToInt32(Console.ReadLine());
            R = Checkout(R);
            Console.WriteLine("Введіть висоту конуса");
            Console.WriteLine("h=");
            h = Convert.ToInt32(Console.ReadLine());
            h = Checkout(h);
            V = (Math.Pow(R, 2) * h * 3.14) / 3;
            Console.WriteLine("Відповідь, V={0}", V);
        }
    }
}