using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCountry.Application.Security
{
    public class ServiceContext
    {
        public static  bool IsLoggedIn { get; set; }

        public static string UserName = "Anonymous";
    }
}
