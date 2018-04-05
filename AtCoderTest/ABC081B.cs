using System;
using System.Linq;
namespace AtCoderTest
{
    public class ABC081B
    {
        public static void Main(string[] args)
        {
            int count = 0;
            //int length = 
            int.Parse(Console.ReadLine());
            long[] num = Array.ConvertAll(
                Console.ReadLine().Split(' '),
                new Converter<string, long>(s => long.Parse(s) ));
            count = keisan(num ,count);
            GC.Collect();
            Console.WriteLine(count);
        }
        public static  int keisan(long[] num,int count){
            if(num.Sum() %2 ==1 || num.Sum() ==0){
                return count;
            }else{
                count++;
                num = Array.ConvertAll( num, i => i/2);
                GC.Collect();
                return keisan(num, count);
            }
        }
    }
}
