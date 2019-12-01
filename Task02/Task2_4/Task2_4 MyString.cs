using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyString String1 = new MyString("sdghlaghlkgjhsaglkjhsgdh");
            //Console.WriteLine(String1.ToString());
            //Console.WriteLine(String1[5]);
            //MyString String2 = new MyString("sdghlaghlkgjhsaglkjhsgdh");
            //Console.WriteLine(String1==String2);
            //MyString String3 = String2 + String1;
            //Console.WriteLine(String3.ToString());
        }
        class MyString
        {
            private char[] _mainChars;
            private int Length;
            public int ArrLength => Length;
            public MyString(string StringIn)
            {
                Length = StringIn.Length;
                _mainChars = new char[Length];
                for (int i = 0; i < Length; i++)
                {
                    _mainChars[i] = StringIn[i];
                }
            }
            public char this[int index]
            {
                get
                {
                    return _mainChars[index];
                }
                set
                {
                    _mainChars[index] = value;
                }
            }
            public int GetFirstIndexOfChar(char Char)
            {
                for (int i = 0; i < Length; i++)
                {
                    if (_mainChars[i] == Char)
                    {
                        return i;
                    }                    
                }
                return -1;
            }
            public int GetLastIndexOfChar(char Char)
            {
                for (int i = Length-1; i >= 0; i--)
                {
                    if (_mainChars[i] == Char)
                    {
                        return i;
                    }
                }
                return -1;
            }
            public override string ToString()
            {
                return new string(_mainChars);
            }
            public char[] ToCharArray()
            {
                return _mainChars;
            }           
            public static MyString operator +(MyString str1, MyString str2)
            {
                int cl = str1.Length + str2.Length;
                char[] Conc = new char[cl];
                for (int i = 0; i < str1.Length; i++)
                {
                    Conc[i] = str1[i];
                }
                for (int i = str1.Length; i < cl; i++)
                {
                    Conc[i] = str2[i - str1.Length];
                }
                return new MyString(new string(Conc));
            }
            public static bool operator ==(MyString str1, MyString str2)
            {
                if (str1.Length != str2.Length)
                {
                    return false;
                }
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            public static bool operator !=(MyString str1, MyString str2)
            {
                if (str1.Length != str2.Length) 
                {
                    return true;
                }
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
