using System;

namespace _24._03._2022_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var excell = new Excell();
            var word = new Word();
            MainPrintFile mainPrintFile = new MainPrintFile(excell);
            MainPrintFile mainPrintFile1 = new MainPrintFile(word);
        }
    }
}
