namespace MyCountryApp
{
    public static class ExtensionTrimStart
    {
        public static string ExtTrimStart(this string target, string trimString)
        {
            var result = target;

            while (result.StartsWith(trimString))
            {
                result = result.Substring(trimString.Length);
            }

            return result;
        }
    }
}
