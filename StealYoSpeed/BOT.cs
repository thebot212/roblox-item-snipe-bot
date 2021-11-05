using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StealYoSpeed
{
    class BOT
    {
        public static bool CheckAsset(string name, string id, string price)
        {
            foreach(string asset in Globals.buylist)
            {
                if(asset == name + "," + id)
                {
                    return false;
                }
            }
            //<span class="text-robux-lg wait-for-i18n-format-render ">2,313,306</span>
            string document = GET.DocumentByID(id);
            string[] documentPrice = Regex.Split(Regex.Split(document, "<span class=\"text-robux-lg wait-for-i18n-format-render \">")[1], "</span>");
            int outprice = int.Parse(documentPrice[0].Replace(",", ""));
            if(outprice <= int.Parse(price))
            {
                Globals.buylist.Add(name + "," + id);
                Globals.Print("FOUND " + name + " =     " + "R$ " + documentPrice[0]);
                return true;
            }
            else
            {
                Globals.Print(name + " =     " + "R$ " + documentPrice[0]);
                return false;
            }
        }
    }
}
