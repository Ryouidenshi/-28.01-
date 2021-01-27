using System;

namespace visilitsa
{
    class Painter
    {
        public Logic Lg { get; set; }
        public Painter(Logic lg)
        {
            Lg = lg;
        }

        public void Draw()
        {
            Console.Clear();
            foreach (var item in Lg.UnkownWord)
            {
                Console.Write(item + " ");
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine();
            }
            if (Lg.Win != true && Lg.Life > 0)
            {
                switch (Lg.Life)
                {
                    case 5:
                        Console.Write("_____");
                        break;
                    case 4:
                        for (int i = 0; i < 6; i++)
                        {
                            Console.WriteLine(@"   |   ");
                        }
                        Console.Write(@" ______   ");
                        break;
                    case 3:
                        Console.WriteLine(@"   ------------");
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine(@"   |   ");
                        }
                        Console.Write(@" ______   ");
                        break;
                    case 2:
                        Console.WriteLine(@"   ------------");
                        Console.WriteLine(@"   |          |");
                        Console.WriteLine(@"   |          |");
                        Console.WriteLine(@"   |   ");
                        Console.WriteLine(@"   |   ");
                        Console.WriteLine(@"   |   ");
                        Console.Write(@" ______   ");
                        break;
                    case 1:
                        Console.WriteLine(@"   ------------");
                        Console.WriteLine(@"   |          |");
                        Console.WriteLine(@"   |          |");
                        Console.WriteLine(@"   |          O");
                        Console.WriteLine(@"   |   ");
                        Console.WriteLine(@"   |   ");
                        Console.Write(@" ______   ");
                        break;
                }
            }
            else if (Lg.Win == true)
            {
                Console.Clear();
                Console.WriteLine(@"Win!");
            }
            else if (Lg.Life == 0)
            {
                Console.Clear();
                Console.WriteLine(@"Lose :(");
            }
        }
    }
}
