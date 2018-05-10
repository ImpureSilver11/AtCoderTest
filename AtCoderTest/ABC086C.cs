using System;
namespace AtCoderTest
{
    public class ABC086C
    {
		string ans = "No";
        public ABC086C()
        {
			int n = int.Parse(Console.ReadLine());
			int[] t = new int[n];
			int[] x = new int[n];
			int[] y = new int[n];
            //数値の入力
			for (int i = 0; i < n;i++){
				int[] num = Array.ConvertAll(
                Console.ReadLine().Split(' '),
                new Converter<string, int>(s => int.Parse(s)));
				
				t[i] = num[0];
				x[i] = num[1];
				y[i] = num[2];
			}
            //今の位置
			int ti = 0;
			int xi = 0;
			int yi = 0;
            //一つ前の位置
			int tj = 0;
			int xj = 0;
			int yj = 0;

			//旅行の成否チェック
			for (int i = 0; i < n;i++){
				ti = t[i];
                xi = x[i];
                yi = y[i];
				if( i != 0){
					//一つ前の値
					tj = t[i - 1];
					xj = x[i - 1];
					yj = y[i - 1];
				}
                //現在の位置
				int xa = xj;
				int ya = yj;
				int timecount = tj;
                //道のりの計測
				while(timecount <ti){
					if(xa < xi){
						xa++;
					}else if(xa > xi){
						xa--;
					}else if (ya < yi ){
						ya++;
					}else if (ya > yi){
						ya--;
					}else{
						xa--;
					}             
					timecount++;
				}
				if (xa != xi || ya != yi){
					break;
				}

				if( i == n-1){
					ans = "Yes";
				}
			}

        }

		public string getAns()
        {
            return this.ans;
        }
    }
}
