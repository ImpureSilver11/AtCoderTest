using System;
namespace AtCoderTest
{
    class ABC083B{
        int count = 0;
        public ABC083B()
        {
            string[] num = Console.ReadLine().Split(' ');
            int a = int.Parse(num[1]);
            int b = int.Parse(num[2]);
            for (int i = 1; i <= int.Parse(num[0]);i++){
                int sum = 0;
                for (int j = 0; j <= i.ToString().Length-1;j++){
                    sum += int.Parse(i.ToString().Substring(j,1));
                }
                if (a <= sum && sum <= b)
                {
                    count += i;
                }
            }
        }

        public int getAns(){
            return this.count;
        }
    }
}
