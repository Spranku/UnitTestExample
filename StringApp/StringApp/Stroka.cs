using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringApp
{
    public class Stroka
    {
        private string Str;

        public Stroka(string InString)
        {
            Str = InString;
        }

        public int CountSymbol(char FoundChar)
        {
            int count = 0;
            foreach (char c in Str)
            {
                if (c == FoundChar)
                {
                    count++;
                }
            }
            return count;
        }

        private string ReverseString(string InText)
        {
            char[] charArray = InText.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public string SplitAndReverse(int Border)
        {
            if (Border < 0 || Border > Str.Length)
            {
                return "Ошибка: неверная граница разделения";
            }
            string firstPart = Str.Substring(0, Border);
            string secondPart = Str.Substring(Border);
            string reversedFirst = ReverseString(firstPart);
            string reversedSecond = ReverseString(secondPart);
            return reversedFirst + reversedSecond;
        }

        public int CountVowels()
        {
            string vowels = "аеёиоуыэюяaeiouyАЕЁИОУЫЭЮЯAEIOUY";
            int count = 0;

            foreach (char c in Str)
            {
                if (vowels.Contains(c))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
