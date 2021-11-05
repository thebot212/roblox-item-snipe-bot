using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StealYoSpeed
{
    class Save
    {
        public static void SaveInfo(string fileName, string info, bool separate)
        {
            if (separate)
            {
                string outString    = "";
                string[] contents   = info.Split(',');
                foreach(string line in contents)
                {
                    outString += line + Environment.NewLine;
                }
                File.AppendAllText(Directory.GetCurrentDirectory() + "\\Save\\" + fileName, outString);
            }
            else
            {
                File.AppendAllText(Directory.GetCurrentDirectory() + "\\Save\\" + fileName, Environment.NewLine + info);
            }
        }

        public static void RemoveInfo(string fileName, string info)
        {
            string contents = File.ReadAllText(Directory.GetCurrentDirectory() + "\\Save\\" + fileName);
            string newContents = contents.Replace(info, "");
            File.WriteAllText(Directory.GetCurrentDirectory() + "\\Save\\" + fileName, newContents);
           
        }

        public static List<string> GetInfo(string fileName)
        {
            List<string> contents = new List<string>();

            foreach(string line in File.ReadAllLines(Directory.GetCurrentDirectory() + "\\Save\\" + fileName).ToList())
            {
                if(line.Contains("["))
                {
                    contents.Add(line);
                }
            }
            return contents;
        }
    }
}
