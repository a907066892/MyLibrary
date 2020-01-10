using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Helpers
{
    public class CodeHelper
    {
        public static string GetAsciiCode(string data)
        {
            string[] array = data.Split('-');
            string send = "";
            foreach (string item in array)
            {
                send += Encoding.ASCII.GetString(new byte[] { byte.Parse(item) });
            }

            return send;
        }
    }
}
