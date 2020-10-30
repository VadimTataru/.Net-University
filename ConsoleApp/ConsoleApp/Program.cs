using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество дней: ");
            int dayCount = Convert.ToInt32(Console.ReadLine());

            int years = dayCount / 365;
            int months = (dayCount - years * 365) / 30;
            int days = dayCount - (years * 365 + months * 30);

            Console.WriteLine($"{years} лет/года/год, {months} месяцев/месяц, {days} дней/день");
            Console.ReadKey();
        }
    }
}
