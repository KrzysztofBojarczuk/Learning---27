using System;
using System.IO;

namespace Learning___144
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napiwek, podatek i łączna ecna");

            while (true)
            {
                try
                {

               

                Calc();

                Console.WriteLine("Jesli chcesz zakończyć program wpisz Tak / tak. Jeśli chcesz dalej kontynować wciśjnij inny przycisk:");
                string end = Console.ReadLine();
                if (end == "Tak" || end =="tak" || end == "tAk" || end =="tAk")
                {
                    break;
                }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private static void Calc()
        {
            StreamWriter inputDate = File.CreateText("Napiwek.text"); 
            Console.WriteLine("Wprowadź cenne za posiłek w reustaracji: ");
            decimal price = decimal.Parse(Console.ReadLine());

            decimal result = price * 0.18m;

            decimal result1 = price * 0.07m;

            decimal totalPrice = price + result + result1;
            Console.WriteLine($"Suma {totalPrice.ToString("c")}");
            Console.WriteLine($"Napiwek {result.ToString("c")}");
            Console.WriteLine($"Podatek {result1.ToString("c")}");

            inputDate.WriteLine($"Suma {totalPrice.ToString("c")}");
            inputDate.WriteLine($"Napiwek {result.ToString("c")}");
            inputDate.WriteLine($"Podatek {result1.ToString("c")}");
            inputDate.Close();
        }
    }
}
