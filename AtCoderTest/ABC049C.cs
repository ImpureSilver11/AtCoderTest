using System;
namespace AtCoderTest
{
    public class ABC049C
    {
        string ans= "NO";

        string dream = "dream";
        string er = "er";
        string ase = "ase";
        string r = "r";

        public ABC049C()
        {
            string s = Console.ReadLine();
            string t = "";
            while(s.Length >t.Length ){
                if(0 == s.IndexOf(t+dream)){
                    t += dream;
                }else if ( 0==s.IndexOf(t+er)){
                    
                    t += er; 
                }else if ( 0 == s.IndexOf(t+ase )){
                    t += ase;
                }else if ( 0 == s.IndexOf(t+r )){
                    t += r;
                }else{
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
