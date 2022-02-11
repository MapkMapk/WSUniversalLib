using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSUniversalLib;

namespace WSUniversalConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculation.GetDataFromFile(@"c:\Users\МАРК\Desktop\1\" + "InputData_01.txt").Replace(Environment.NewLine, " "));
            Console.ReadLine();
        }
    }
}
