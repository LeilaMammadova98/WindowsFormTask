using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BossLeilaProject.AppCode.Helpers
{
   static partial  class Extension
    {


        static internal string Md5(this string value)
        {
          MD5 md5 = new MD5CryptoServiceProvider();
            byte[] buffer = Encoding.UTF8.GetBytes($"!fri#{value}#ends!");
            var md5buffer = md5.ComputeHash(buffer);
            return string.Join("", md5buffer.Select(x => x.ToString("x2")).Reverse());
        }

    }
}
