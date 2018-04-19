using System;
using System.Linq;
using System.Collections.Generic;


namespace AtCoderTest
{
    public class ABC085B
    {
        int ans = 0;
        public ABC085B()
        {
            int num = int.Parse(Console.ReadLine());

            int[] moti = new int[num];
            int teihen = 0;
            for (int i = 0; i < num; i++){
                moti[i] = int.Parse(Console.ReadLine());
            }
            List<int> motiList = new List<int>(moti);
            motiList.Sort();
            teihen = motiList.Max();
            motiList.RemoveAt(motiList.Count - 1);
            ans++;
            while(motiList.Count>0){
                if(teihen != motiList.Max()){
                    ans++;
                 }
                teihen = motiList.Max();
                motiList.RemoveAt(motiList.Count - 1);
            }
   
        }

        public int getAns(){
            return this.ans;
        }
    }
}
