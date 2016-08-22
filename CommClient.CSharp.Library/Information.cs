using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommClient.CSharp.Library
{
    public class Information
    {
        public byte Encrypttype;
        /* 
         * Server Password Encryption Type.
         * 
         * 0 = SHA-256 (default)
         * 1 = SHA-1
         * 2 = SHA-512
         * 3 = SHA-384
         * 4 = MD5
        */
        public bool XMLUse;
        public string token = "test1234";
    }
}
