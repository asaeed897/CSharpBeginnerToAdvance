using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBeginner
{
    class StringUtility
    {
        public static string SummarizeText(String text, int maxLength = 20)
        {
            if (text.Length < maxLength)
            {
                return text;
            }

            var words = text.Split(" ");
            var wordsList = new List<string>();

            var characterCount = 0;
            foreach (var word in words)
            {
                characterCount += word.Length;
                if (characterCount > maxLength)
                {
                    break;
                }
                wordsList.Add(word);
            }

            return String.Join(" ", wordsList) + "...";



        }

    }
}
