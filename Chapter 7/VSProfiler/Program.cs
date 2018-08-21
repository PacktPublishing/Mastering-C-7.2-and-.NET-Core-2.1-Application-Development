namespace VSProfiler
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateWithString();
        }
        static string GenerateWithString()
        {
            var str = "";
            for (var i = 0; i < 5000; i++)
            {
                str += i.ToString();
            }
            return str;
        }
    }
}
