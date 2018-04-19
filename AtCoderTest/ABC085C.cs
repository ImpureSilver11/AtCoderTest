using System;
namespace AtCoderTest
{
    public class ABC085C
    {
        string ans="-1 -1 -1";
        public ABC085C()
        {
            int[] num = Array.ConvertAll(Console.ReadLine().Split(' '),
                                         new Converter<string, int>(s => int.Parse(s)));
            int maisu = num[0];
            int okane = num[1];
            for (int i = 0; i <= maisu; i++)
            {
                if (((i * 10000) + ((maisu - i) * 5000)) < okane)
                {
                    continue;
                }

                for (int j = 0; j <= maisu; j++)
                {
                    if (((i * 10000) + (j * 5000)+ ((maisu-i-j)*1000) < okane))
                    {
                        continue;
                    }
                    for (int k = 0; k <= maisu;k++){
                        if (i + j + k > maisu ||
                            (i * 10000) + (j * 5000) + (k * 1000) > okane)
                        {
                            break  ;
                        }else if((i * 10000) > okane){
                                return;                      
                        }else if(((i*10000)+(j*5000)+(k*1000))==okane && i+j+k==maisu){
                            ans = i.ToString() + " " + j.ToString() + " " + k.ToString();
                            return;
                        }
                    }
                }
                
            }
        }
        public string getAns()
        {
            return this.ans;
        }

    }
}
