using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace logoprint
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            string characters = "/#&@HXM$%@@+-"; //this is the character set to replace 'v', modify it to include different characters or make them show up more
            Console.WriteLine("");
            List<String> strings = new List<string>() //edit this to modify the ASCII image
            {
                "                 EvvvvvvvvvvvvvE                 ",
                "            EEE ELlvvvvvvvvvvvvvE FLF            ",
                "         ELvvvvvLE  Flvvvvvvvvvvl EvvvlLE        ",
                "       FvvvvvvvvvvvlF  ELvvvvvvvvE lvvvvvlF      ",
                "     FvvvvvvvvvvvvvvvvvLE EFlvvvvL EvvvvvvvlE    ",
                "    lvvvvvvvvvvvvvvFEE        FLvv  vvvvvvvvvL   ",
                "                                EE Fvvvvvvvl     ",
                "  EFvvvvvvvvvlE                      vvvvvvF Evl ",
                " LvvvvvvvvvvF                        Lvvvl  lvvvF",
                " vvvvvvvvvl                           vvE Fvvvvvl",
                " vvvvvvvvF                            F  lvvvvvvv",
                " vvvvvvl  Lv                           Fvvvvvvvvv",
                " lvvvvF EvvvF                        ElvvvvvvvvvL",
                " Evvl  Lvvvvl                       Lvvvvvvvvvvl ",
                "  LF FvvvvvvvE                                   ",
                "    lvvvvvvvvL ElF                EEFvvvvvvvvvE  ",
                "    Evvvvvvvvv  vvvvLE   ELvvvvvvvvvvvvvvvvvl    ",
                "      FvvvvvvvF FvvvvvvlF  FlvvvvvvvvvvvvvlF     ",
                "        Flvvvvv  vvvvvvvvvlLE ELvvvvvvvvlE       ",
                "           FlvvE LvvvvvvvvvvvvLF  FlvLF          ",
                "               E ElvvvvvvvvvvvvvLE               "
            };
            string temp;
            strings.ForEach(c =>
            {
                temp = "";
                c.ToCharArray().ToList().ForEach(d =>
                {
                    if (d == 'E' || d == 'L' || d == 'l' || d == 'F')
                    {
                        temp += '.';
                    }
                    else if (d == 'v')
                    {
                        temp += characters[rng.Next(characters.Length)];
                    }
                    else
                    {
                        temp += ' ';
                    }
                });
                PrintByLetter(temp); //add 2 additional arguments to set the minimum and maximum wait time between displaying characters (2-8 by default)
            });
            PrintByLetter("\n\nWelcome to Aperture OS!\n", 30, 60);
        }
        static void PrintByLetter(string input, int min = 2, int max = 8)
        {
            Random rng = new Random();
            input.ToList().ForEach(c =>
            {
                if (c == ' ')
                {
                    Console.Write(c);
                }
                else
                {
                    Console.Write(c);
                    Thread.Sleep(rng.Next(min, max));
                }
            });
            Console.WriteLine();
            Thread.Sleep(10);
        }
    }
}
