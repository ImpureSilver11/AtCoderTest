using System;
using System.Linq;
namespace AtCoderTest
{
    public class ABC081B
    {
        public static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            long[] num = Array.ConvertAll(
                Console.ReadLine().Split(' '),
                new Converter<string, long>(s => long.Parse(s) ));
            int count = 0;
            count = keisan(num ,count);
            Console.WriteLine(count);
        }
        public static int keisan(long[] num,int count){
            GC.Collect();
            if(num.Sum() %2 ==1){
                return count;
            }else{
                count++;
                num = Array.ConvertAll<long,long>( num,waru);
                return keisan(num, count);
            }
        }
        public  static long  waru(long i){
            return i / 2;
        }
    }
}
