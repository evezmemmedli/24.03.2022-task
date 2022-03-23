using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._03._2022_task
{
    internal class MainPrintFile
    {
        public MainPrintFile(IPrintable printable)
        {
            printable.Print();
        }
    }
}
