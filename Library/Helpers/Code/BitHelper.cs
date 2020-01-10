using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Helpers
{
    public class BitHelper
    {
        /// <summary>
        /// 异或比特
        /// </summary>
        /// <param name="b1">原比特</param>
        /// <param name="b2">对比的比特</param>
        /// <returns></returns>
        public static int xorBytes(byte[] b1, byte[] b2)
        {
            //补值
            if (b1.Length > b2.Length)
            {
                b2 = appendBytes(b1, b2);
            }
            //补值
            if (b2.Length > b1.Length)
            {
                b1 = appendBytes(b2, b1);
            }

            byte[] ay = new byte[32];
            for (int i = 0; i < b1.Length; i++)
            {
                ay[i] = (byte)(b1[i] ^ b2[i]);
            }

            return BitConverter.ToInt32(ay, 0);
        }

        //补值
        public static byte[] appendBytes(byte[] max, byte[] min)
        {
            int subValue = max.Length - min.Length;//差值
            byte[] newByte = new byte[min.Length + subValue];
            min.CopyTo(newByte, 0);
            return newByte;
        }
    }
}
