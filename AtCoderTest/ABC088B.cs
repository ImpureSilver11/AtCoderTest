using System;
using System.Linq;
using System.Collections.Generic;


namespace AtCoderTest
{
    public class ABC088B
    {
        int ansAlice = 0;
        int ansBob = 0;
        public ABC088B()
        {
            int num = int.Parse(Console.ReadLine());
            List<int> alist = new List<int>(Array.ConvertAll(
                Console.ReadLine().Split(' '),
                new Converter<string, int>(s => int.Parse (s))));

            alist.Sort();
                 
            //大きさでソートして1つ空けで取得していく
            while(alist.Count  > 0){
                int max = alist.Max();
                ansAlice += max;
                alist.RemoveAt(alist.Count - 1);
                if (alist.Count >0){
                    max = alist.Max();
                    ansBob += max;
                    alist.RemoveAt(alist.Count  - 1);
                }
            }
            ansAlice -= ansBob;
        }
        public int getAns(){
            return this.ansAlice; 
        }
    }
}
