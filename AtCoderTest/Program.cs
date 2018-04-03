using System;

namespace AtCoderTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int A, B, C;
            string S;

            A = int.Parse(Console.ReadLine());
            string[] bandc = Console.ReadLine().Split(' ');
            B = int.Parse(bandc[0]);
            C = int.Parse(bandc[1]);
            S = Console.ReadLine();

            if (A < 1 || A > 1000)
            {
                Console.Write("Aは１〜1000の値を入力して下さい");
                return;
            }

            if (B < 1)
            {
                Console.Write("Bは1以上の値を入力して下さい");
                return;
            }

            if (C > 1000)
            {
                Console.Write("Cは1000以下の値を入力して下さい");
                return;
            }

            if (S =="" || S.Length >100 )
            {
                Console.Write("Sは1文字以上100文字以内で入力して下さい");
                return;
            }

            Console.Write("{0} {1}",A+B+C,S);


        }
    }
}
