using System;
using System.Linq;
namespace AtCoderTest
{
    public class ABC081B
    {
        public ABC081B()
        {
            int.Parse(Console.ReadLine());
            long[] num = Array.ConvertAll(
                Console.ReadLine().Split(' '),
                new Converter<string, long>(s => long.Parse(s) ));
            
            int[] count = new int[num.Length];
            for (int i = 0; i <num.Length;i++){
                int warucount = 0;
                while(num[i]%2==0 && num[i]!=0){
                    warucount++;
                    num[i] = num[i] / 2;
                }
                count[i] = warucount;
            }
            Console.WriteLine(count.Min());
        }
    }
}
