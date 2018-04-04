using System;
namespace AtCoderBeginnersSelection
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string num = Console.ReadLine();
            Console.WriteLine(num.Length - num.Replace("1","").Length );
        }
    }
}
