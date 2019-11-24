using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            Console.WriteLine("Средняя длинна слов в вашей строке = " + AvgLength(Console.ReadLine()));            
        }
        static double AvgLength(string str)
        {
            if (str.Length == 0) return 0;
            else
            {
                int AllCharsCount = 0;
                int WordsCount = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    string word = "";
                    while (i < str.Length && !char.IsSeparator(str[i]) && !char.IsPunctuation(str[i]))
                    {
                        word += str[i];
                        i++;
                        AllCharsCount++;
                    }
                    if (word != "") WordsCount++;
                }
                return (double)AllCharsCount / WordsCount;

            }
            
        }
    }
}
