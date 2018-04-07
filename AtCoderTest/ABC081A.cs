using System;
namespace AtCoderBeginnersSelection
{
    class ABC081A
    {
        public ABC081A()
        {
            string num = Console.ReadLine();
            Console.WriteLine(num.Length - num.Replace("1","").Length );
        }
    }
}
