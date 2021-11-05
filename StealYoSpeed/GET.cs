using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StealYoSpeed
{
    class GET
    {
        public static string NameByID(string id)
        {
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://www.roblox.com/catalog/" + id);
                // access req.Headers to get/set header values before calling GetResponse. 
                // req.CookieContainer allows you access cookies.

                var response = req.GetResponse();

                using (var strm = new StreamReader(response.GetResponseStream()))
                {
                    return strm.ReadToEnd();
                }

            }
            catch(Exception e)
            {
                return "Asset not Found";
            }
        }

        public static string DocumentByID(string id)
        {
            try
            {
                using (WebClient web1 = new WebClient())
                {
                    string data = web1.DownloadString("https://www.roblox.com/catalog/" + id);
                    return data;
                }
            }
            catch (Exception e)
            {
                Globals.Print("Unable to find Asset " + id);
                return "Asset not Found";
            }
        }
    }
}
