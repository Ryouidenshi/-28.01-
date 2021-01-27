using System;
using System.IO;

namespace visilitsa
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = GetRandomWord();
            var unkownWord = GetUnkownWord(word);
            var logic = new Logic(word, unkownWord);
            var painter = new Painter(logic);
            while (logic.Win != true && logic.Life>0)
            {
                painter.Draw();
                logic.PressKey(Console.ReadKey());
            }
            painter.Draw();
        }

        public static string GetRandomWord()
        {
            var words = File.ReadAllLines("../../Words.txt");
            var rnd = new Random().Next(0, words.Length - 1);
            return words[rnd];
        }

        public static char[] GetUnkownWord(string word)
        {
            var unkownWord = new char[word.Length];
            for (int i = 0; i < word.Length; i++)
                unkownWord[i] = '_';
            return unkownWord;
        }
    
    }
}
