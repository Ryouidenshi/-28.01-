using System;
using System.Linq;


namespace visilitsa
{
    class Logic
    {
        public string Word { get; set; } 

        public char[] TrueAnswers { get; set; }

        public int Life { get; set; } //пусть жизней будет 5

        public char[] UnkownWord { get; set; }
        
        public bool Win { get; set; }


        public Logic(string word, char[] unkownWord)
        {
            Win = false;
            Word = word;
            TrueAnswers = Word
                .ToCharArray()
                .ToArray();
            UnkownWord = unkownWord;
            Life = 5;
        }

        public void PressKey(ConsoleKeyInfo Key)
        {
            bool flag = false;
            for (int i = 0; i < UnkownWord.Count(); i++)
            {
                if (Key.KeyChar == TrueAnswers[i])
                {
                    UnkownWord[i] = Key.KeyChar;
                    TrueAnswers[i] = ' ';
                    flag = true;
                    break;
                }
            }
            if (flag != true)
                Life--;
            if (CheckForWin() == true)
                Win = true; 
        }

        public bool CheckForWin()
        {
            var res = true;
            foreach (var item in TrueAnswers)
            {
                if (item != ' ')
                {
                    res = false;
                    break;
                }
            }
            return res;
        }
    }
}
