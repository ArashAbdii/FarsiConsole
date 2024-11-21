﻿using System.Text;

namespace FarsiConsole
{
    public class FarsiConsole
    {
        private static string Reverse_text(string txt)
        {
            string newText = string.Empty;

            char[] txtSplit = txt.ToCharArray();

            for (int i = txt.Length - 1; i >= 0; i--)
            {
                newText += txtSplit[i];
            }

            return newText;
        }

        private static string ReverseLatinWord(string textString)
        {
            string[] splitedText = textString.Split(" ");

            for (int i = 0; i < splitedText.Length; i++)
            {
                string newReverseLatinWord = string.Empty;

                if ((int)splitedText[i][0] <= 127)
                {
                    for (int j = splitedText[i].Length - 1; j >= 0; j--)
                    {
                        newReverseLatinWord += splitedText[i][j];
                    }

                    splitedText[i] = newReverseLatinWord;
                }
            }

            return string.Join(" ", splitedText);
        }

        public static void Enable()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
        }

        public static void Write(string text)
        {
            Console.Write(ReverseLatinWord(Reverse_text(text)));
        }

        public static void WriteLine(string text)
        {
            Console.WriteLine(ReverseLatinWord(Reverse_text(text)));
        }
    }
}
