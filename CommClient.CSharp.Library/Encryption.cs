using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CommClient.CSharp.Library
{
    public class Encryption
    {
        public string EncryptData(string data)
        {
            Information infor = new Information();
            if(infor.Encrypttype == 0)
            {
                return sha256.Encrypt(data);

            }
            else if (infor.Encrypttype == 1)
            {
                return sha1.Encrypt(data);
            }
            else if(infor.Encrypttype == 2)
            {
                return sha512.Encrypt(data);
            }
            else if(infor.Encrypttype == 3)
            {
                return sha3.Encrypt(data);
            }
            else if(infor.Encrypttype == 4)
            {
                return md5.Encrypt(data);
            }
            else
            {
                return "Unknown Error";
            }
        }

        //public string encrypt(string data, SHA256 asd)
    }
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
    public class sha1
    {
        public static string Encrypt(string raw)
        {
            SHA1 sha = new SHA1Managed();
            byte[] byt = sha.ComputeHash(Encoding.ASCII.GetBytes(raw));
            StringBuilder sb = new StringBuilder();
            foreach (byte by in byt)
            {
                sb.AppendFormat("{0:x2}", by);
            }
            return sb.ToString();
        }
    }
    public class sha512
    {
        public static string Encrypt(string raw)
        {
            SHA512 sha = new SHA512Managed();
            byte[] byt = sha.ComputeHash(Encoding.ASCII.GetBytes(raw));
            StringBuilder sb = new StringBuilder();
            foreach (byte by in byt)
            {
                sb.AppendFormat("{0:x2}", by);
            }
            return sb.ToString();
        }
    }
    public class sha3
    {
        public static string Encrypt(string raw)
        {
            SHA384 sha = new SHA384Managed();
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
