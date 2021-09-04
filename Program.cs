using System;

namespace assignment1
{
    class Program
    {
        enum days {Monday=1,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday}
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            int day1 = (int)(days.Monday);
            int day2 = (int)(days.Tuesday);
            int day3 = (int)(days.Wednesday);
            int day4 = (int)(days.Thursday);
            int day5 = (int)(days.Friday);
            int day6 = (int)(days.Saturday);
            int day7 = (int)(days.Sunday);
            if((number>=day1)&&(number<=day5))
            Console.WriteLine($"its a working day");
           else
            Console.WriteLine("its a holiday");
        }
    }
}
