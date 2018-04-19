using System;
namespace AtCoderTest
{
    class ABC087B
    {
        int count = 0;
        public ABC087B()
        {
            //入力数値
            int a, b, c, s;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            s = int.Parse(Console.ReadLine());

            for (int i = 0; i <= a;i++){
                for (int j = 0; j <= b;j++){
                    for (int k = 0; k <= c;k++){
                        if((i*500)+(j*100)+(k*50)==s){
                            count++;
                        }
                    }
                }
            }
        }

            public int getAns(){
            return this.count;
        }
    }
}
