using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxValue = 100;
            int minValue = 0;
            GetValue("HealthPoints", minValue, maxValue, 0, ConsoleColor.Green);
            GetValue("ManaPoints", minValue, maxValue, 1, ConsoleColor.DarkBlue);
            GetValue("EnergyPoints", minValue, maxValue, 2, ConsoleColor.DarkRed);
        }
        static void GetValue(string value, int minValue, int maxValue, int position, ConsoleColor colour)
        {
            Console.Write($"{value}: ");
            int enteredValue = Convert.ToInt32(Console.ReadLine());

            if (enteredValue > maxValue)
            {
                enteredValue = maxValue;
            }

            if (enteredValue < minValue)
            {
                enteredValue = minValue;
            }

            DrawBar(enteredValue, maxValue, colour, position, value);
        }

        static void DrawBar(int value, int maxValue, ConsoleColor colour, int position, string nameOfBar)
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            string bar = "";

            for (int i = 0; i < value; i++)
            {
                bar += "#";
            }

            Console.SetCursorPosition(0, position);
            Console.ForegroundColor = colour;
            Console.Write('[');
            Console.Write(bar);
            Console.ForegroundColor = defaultColor;
            bar = "";

            for (int i = value; i < maxValue; i++)
            {
                bar += "#";
            }

            if (value == maxValue)
            {
                Console.ForegroundColor = colour;
                Console.Write(bar + ']');
                Console.ForegroundColor = defaultColor;
                Console.WriteLine(nameOfBar);
            }
            else
            {
                Console.Write(bar + ']');
                Console.WriteLine(nameOfBar);
            }
        }
    }

}
