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
            GetValue("HealthPoints", 0, ConsoleColor.Green, 5);

            GetValue("ManaPoints", 1, ConsoleColor.DarkBlue, 7);

            GetValue("EnergyPoints", 2, ConsoleColor.DarkRed, 9);
        }
        static void GetValue(string nameOfBar, int position, ConsoleColor colour, int positionOfText)
        {
            Console.SetCursorPosition(0, positionOfText);
            Console.Write($"Введите максимальное значение {nameOfBar}: ");
            float maxValue = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Текущее значение {nameOfBar} в %: ");
            float enteredPercent = Convert.ToInt32(Console.ReadLine());
            int minValue = 0;
            int maxPercent = 100;

            if (enteredPercent > maxPercent)
            {
                enteredPercent = maxPercent;
            }
            else if (enteredPercent < minValue)
            {
                enteredPercent = minValue;
            }

            float value = maxValue / maxPercent * enteredPercent;

            DrawBar(value, maxValue, colour, position, nameOfBar);
        }

        static void DrawBar(float value, float maxValue, ConsoleColor colour, int position, string nameOfBar)
        {
            char startBorder = '[';
            char finalBorder = ']';
            ConsoleColor defaultColor = Console.ForegroundColor;

            string bar = FillBar(0, value);

            Console.SetCursorPosition(0, position);
            Console.ForegroundColor = colour;
            Console.Write(startBorder);
            Console.Write(bar);
            Console.ForegroundColor = defaultColor;

            bar = FillBar(value, maxValue);

            if (value == maxValue)
            {
                Console.ForegroundColor = colour;
                Console.Write(bar + finalBorder);
                Console.WriteLine(nameOfBar);
                Console.ForegroundColor = defaultColor;
            }
            else
            {
                Console.Write(bar + finalBorder);
                Console.ForegroundColor = colour;
                Console.WriteLine(nameOfBar);
                Console.ForegroundColor = defaultColor;
            }
        }

        static string FillBar(float startValue, float finalValue)
        {
            string bar = null;
            char filledSymbol = '#';

            for (float i = startValue; i < finalValue; i++)
            {
                bar += filledSymbol;
            }

            return bar;
        }
    }
}
