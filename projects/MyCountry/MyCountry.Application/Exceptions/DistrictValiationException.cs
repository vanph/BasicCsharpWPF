using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCountry.Application.Exceptions
{
    public class DistrictValiationException: Exception
    {
        public DistrictValiationException(string message):base(message)
        {
            
        }
    }
}
