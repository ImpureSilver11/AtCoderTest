using System;
namespace AtCoderTest
{
    class ABC087B
    {
        int count = 0;
        public ABC087B()
        {
            //入力数値
            int a, b, c ,s;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            s = int.Parse(Console.ReadLine());

            //各コイン枚数、あまりの数値、パターン数値
            int couA, couB, couC;
            couA = Cons(ref s, 500, a);
            couB = Cons(ref s, 100, b);
            couC = Cons(ref s, 50, c);

            if (s != 0){
                return;
            }
            count++;

            while(couC < c ){
                
                int subA = couA;
                int subB = couB;
                while(subB < b && subA !=0){
                    count++;
                    subA -= 1;
                    subB += 5;
                }
                count++;
                couB -= 1;
                couC += 2;
            }    

            return;
        }

        private int Cons(ref int amari, int kane ,int abc){
            int maisu =0;

            if (abc < (amari / kane))
            {
                maisu = abc;
                amari = amari - (maisu * kane);
            }
            else
            {
                maisu = amari / kane;
                amari = amari % kane;
            }
            return maisu;
        }

            public int getAns(){
            return this.count;
        }
    }
}
