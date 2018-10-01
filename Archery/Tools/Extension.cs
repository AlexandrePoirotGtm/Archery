using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace Archery.Tools
{
    public static class Extension
    {


        public static string CryptoMDP(this string mdp)
        {
            byte[] bito = System.Text.Encoding.Default.GetBytes(mdp);
            //MD5 MD5 = MD5.Create();
            //bito = MD5.ComputeHash(Encoding.UTF8.GetBytes(mdp));
            MD5CryptoServiceProvider provider = new MD5CryptoServiceProvider();
            byte[] calcul = provider.ComputeHash(bito);
            string result = "";
            foreach(byte b in calcul)
            {
                if (b < 16)
                    result += "0" + b.ToString("x");
                else
                    result += b.ToString("x");
            }
            return result;
        }
        public static string GenerateMD5(string yourString)
        {
            return string.Join("", MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(yourString)).Select(s => s.ToString("x2")));
        }
    }
}