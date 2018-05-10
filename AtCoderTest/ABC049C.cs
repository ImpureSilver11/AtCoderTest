using System;
namespace AtCoderTest
{
    public class ABC049C
    {
        string ans= "NO";

        string dream = "dream";
		string dreamer = "dreamer";
        string erase = "erase";
		string eraser = "eraser";

        public ABC049C()
        {
            string s = Console.ReadLine();
            string t = "";
			string ss = s;
            while(ss.Length != 0){
			    if (ss.LastIndexOf(erase) == ss.Length - 5 && ss.Length >=5){
					t = erase + t;
                    ss = ss.Substring(0, ss.Length - 5);
				}else if (ss.LastIndexOf(dream) == ss.Length - 5 && ss.Length >= 5){
                    t = dream + t;
                    ss = ss.Substring(0, ss.Length - 5);
				}else if (ss.LastIndexOf(eraser) == ss.Length - 6 && ss.Length >= 6){
					t = eraser + t;
                    ss = ss.Substring(0, ss.Length - 6);
				}else if (ss.LastIndexOf(dreamer) == ss.Length - 7 && ss.Length >= 7){
					t = dreamer + t;
					ss = ss.Substring(0, ss.Length - 7);
				}else {
					break;				
				}
            }
            if(s == t){
                ans = "YES";
            }
        }

        public string getAns(){
            return  this.ans;
        }
    }
}
