using System;
namespace AtCoderBeginnersSelection
{
    class ABC086A
    {
        public ABC086A()
        {
            int A, B;
            string[] num = Console.ReadLine().Split(' ');
            A = int.Parse(num[0]);
            B = int.Parse(num[1]);

            if((A*B)%2 ==1){
                Console.WriteLine("Odd");
            }else{
                Console.WriteLine("Even");
            }
        }
    }

}
