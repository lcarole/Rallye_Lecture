using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace rallyeLecture
{
    class Hash
    {
        public static string GetMd5Hash(MD5 md5Hash, string id)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(id));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length ; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        public static string GetSha256FromString(string data)
        {
            var message = Encoding.ASCII.GetBytes(data);
            SHA256Managed hashString = new SHA256Managed();
            string hex = "";

            var hashValue = hashString.ComputeHash(message);
            foreach (byte x in hashValue)
            {
                hex += String.Format("{0:x2}", x);

            }
            return hex;
        }
    }
}
