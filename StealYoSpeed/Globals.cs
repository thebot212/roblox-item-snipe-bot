using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StealYoSpeed
{
    class Globals
    {
        public static string console = "Stealing kids finger speed activated!\n";
        public static bool enable = false;
        public static List<string> buylist = new List<string>();


        public static void Print(string line)
        {
            console += line + Environment.NewLine;
        }
    }
}
