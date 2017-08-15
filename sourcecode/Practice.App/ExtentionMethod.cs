namespace Practice.App
{
    public static class ExtentionMethodTest
    {
        public static string Hello(this string source)
        {
            return "Hello:" + source;
        }

        public static string ReplaceColon(this string source, string str)
        {
           return source.Replace(@":", str);
        }
    }
}
