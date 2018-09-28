using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace Archery.Tools
{
    public static class Crypto
    {


        public static string CryptoMDP(string mdp)
        {
            byte[] bito;
            MD5 MD5 = MD5.Create();
            bito = MD5.ComputeHash(Encoding.UTF8.GetBytes(mdp));
            return bito.GetHashCode().ToString();
        }
        public static string GenerateMD5(string yourString)
        {
            return string.Join("", MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(yourString)).Select(s => s.ToString("x2")));
        }
    }
}