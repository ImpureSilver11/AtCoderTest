using System;

namespace AtCoderBeginnersSelection
{
    class Practice
    {
        public Practice()
        {
            int A, B, C;
            string S;
            A = int.Parse(Console.ReadLine());
            string[] bandc = Console.ReadLine().Split(' ');
            B = int.Parse(bandc[0]);
            C = int.Parse(bandc[1]);
            S = Console.ReadLine();
            Console.WriteLine ((A+B+C) + " " +S);
        }
    }
}
