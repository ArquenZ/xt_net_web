using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Font fonts = Font.Default;
            int a;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            do
            {
                Menu(fonts);
                a = InputTest(ReadInput());

                switch (a)
                {
                    case 1: fonts ^= Font.Bold; break;
                    case 2: fonts ^= Font.Italic; break;
                    case 3: fonts ^= Font.Underline; break;
                    //default: break;
                }
                Console.Clear();
            }
            while (a != 4);
            Console.WriteLine("Ваш итоговый вариант: " +fonts);
            

             
        }
        [Flags]
        enum Font
        {
            Default = 0,
            Bold = 1,
            Italic = 2,
            Bold_Italic = Bold | Italic,
            Underline = 4,
            Bold_Underline = Bold | Underline,
            Italic_Underline = Italic | Underline,
            Bold_Italic_Underline = Bold | Italic | Underline
        }
        private static int ReadInput()
        {
            int a;
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Некорректный ввод");
            }
            return a;
        }
        private static int InputTest(int a)
        {
            if (a == 1 || a==2 || a==3|| a==4) return a;
            else
            {
                Console.WriteLine("Некорректный ввод");
                return ReadInput();
            }
        }
        private static void Menu(Font fonts)
        {
            
            Console.WriteLine("Параметры надписи: " + fonts);
            Console.WriteLine("Введите:");
            Console.WriteLine("\t" + "1:bold");
            Console.WriteLine("\t" + "2:italic");
            Console.WriteLine("\t" + "3:underline");
            Console.WriteLine("\t" + "4:Accept");
        }
    }
}
