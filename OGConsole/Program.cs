using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpacEngine;

namespace Opacity_Generator
{
    class Program
    {
        private static int[] _sizes = new int[] {32, 64, 128, 256, 512};

        private static List<Opacity> _opacities = new List<Opacity>();

        static void Main(string[] args)
        {
            Console.Title = "IMVUMafias Opacity Generator";

            ColoredConsoleWriteLine(ConsoleColor.Cyan, "|==============================================|");
            ColoredConsoleWriteLine(ConsoleColor.Cyan, "|                                             =|");
            ColoredConsoleWriteLine(ConsoleColor.Cyan, "|  IMVUMafias Opacity Generator by DataMine   =|");
            ColoredConsoleWriteLine(ConsoleColor.Cyan, "|                                             =|");
            ColoredConsoleWriteLine(ConsoleColor.Cyan, "|     This program creates opacities with     =|");
            ColoredConsoleWriteLine(ConsoleColor.Cyan, "|        different brightness values          =|");
            ColoredConsoleWriteLine(ConsoleColor.Cyan, "|                                             =|");
            ColoredConsoleWriteLine(ConsoleColor.Cyan, "|==============================================|");
            Console.WriteLine();

            menu();

            Console.ReadLine();
        }

        private static void menu()
        {
            string availableSizes = string.Join((", "), _sizes);
            string input;
            int size = 0;

            //sizing
            while (!_sizes.Contains(Convert.ToInt32(size)))
            {                
                Console.WriteLine("(Available Sizes: " + availableSizes + ")");
                //Console.WriteLine("");
                Console.Write("Type in your desized opacity size: ");

                input = Console.ReadLine();

                while (!Int32.TryParse(input, out size))
                {
                    Console.WriteLine("Please enter a valid size");
                    input = Console.ReadLine();
                }

                size = Convert.ToInt32(input);
            }

            OpacitySettings.OpacityResolution = size;

            Console.WriteLine();
            Console.WriteLine();

            int shadeDifference = 0;

            //shade
            Console.WriteLine("Type in the amount of brightness you want between each opacity");
            Console.WriteLine("(Higher numbers mean fewer opacities)");
            Console.Write("Brightness value: ");

            input = Console.ReadLine();

            while (!Int32.TryParse(input, out shadeDifference))
            {
                Console.WriteLine("Please enter a valid number");
                input = Console.ReadLine();
            }

            OpacitySettings.BrightnessFactor = Convert.ToInt32(input);

            CreateColors();

            ColoredConsoleWriteLine(ConsoleColor.Green, "|==============================================|");
            ColoredConsoleWriteLine(ConsoleColor.Green, "|                                             =|");
            ColoredConsoleWriteLine(ConsoleColor.Green, "|                   DONE!                     =|");
            ColoredConsoleWriteLine(ConsoleColor.Green, "|                                             =|");
            ColoredConsoleWriteLine(ConsoleColor.Green, "|    Would you like to make more opacities?   =|");
            ColoredConsoleWriteLine(ConsoleColor.Green, "|                                             =|");
            ColoredConsoleWriteLine(ConsoleColor.Green, "|           Type Yes(y) or No(n)              =|");
            ColoredConsoleWriteLine(ConsoleColor.Green, "|                                             =|");
            ColoredConsoleWriteLine(ConsoleColor.Green, "|==============================================|");
            Console.WriteLine();

            string answer = Console.ReadLine();

            if(answer.Equals("yes") || answer.Equals("y"))
            {
                Console.Clear();
                menu();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private static void CreateColors()
        {
            int currentBrightness = 0;
            int maxShades = 255 / OpacitySettings.BrightnessFactor;

            for (int i = 0; i < maxShades; ++i)
            {
                Opacity opac = new Opacity(currentBrightness, currentBrightness, currentBrightness);
                currentBrightness += OpacitySettings.BrightnessFactor;
                opac.Save();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private static void ColoredConsoleWriteLine(ConsoleColor color, string text)
        {
            ConsoleColor originalColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = originalColor;
        }
    }
}
