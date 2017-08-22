using System;

namespace MyCountryApp
{
  public  static  class StringExtensions
    {
        public static bool ContainsByStringComparison(this string src, string toCheck, StringComparison comp)
        {
            return src.IndexOf(toCheck, comp) >= 0;
        }
    }
}
