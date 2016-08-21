using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CommClient.CSharp.Library
{
    class md5
    {
        public static string Encrypt(string Raw)
        {
            StringBuilder MD5Str = new StringBuilder();
            byte[] byteArr = Encoding.ASCII.GetBytes(Raw);
            byte[] resultArr = (new MD5CryptoServiceProvider()).ComputeHash(byteArr);

            for (int cnti = 0; cnti < resultArr.Length; cnti++)
            {
                MD5Str.Append(resultArr[cnti].ToString("X2"));
            }

            return MD5Str.ToString().ToLower();
        }
    }
    public class sha256
    {
        public static string Encrypt(string raw)
        {
            SHA256 sha = new SHA256Managed();
            byte[] byt = sha.ComputeHash(Encoding.ASCII.GetBytes(raw));
            StringBuilder sb = new StringBuilder();
            foreach (byte by in byt)
            {
                sb.AppendFormat("{0:x2}", by);
            }
            return sb.ToString();
        }

    }
}
