using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BossLeilaProject.AppCode.Helpers
{
 static   partial class Extension
    {

        static internal bool isHomeNum(this string phone)
        {
            return Regex.IsMatch(phone, @"(0[0-9][0-9])[-\s]\d{3}-\d{2}-\d{2}");
        }
       
    }
}
