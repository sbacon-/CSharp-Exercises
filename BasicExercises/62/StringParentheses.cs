using System;
public class StringParentheses{
	public static void Main(){
            Console.WriteLine(ReverseStr("p(rq)st"));
            Console.WriteLine(ReverseStr("(p(rq)st)"));
            Console.WriteLine(ReverseStr("ab(cd(ef)gh)ij"));
	}
	private static string ReverseStr(string str){
		
		while(str.IndexOf('(')!=-1){
			string res = "";
			int li = str.LastIndexOf('(');
			int ri = str.IndexOf(')',li);
			res = str.Substring(0,li);
			
			char[] rev = str.Substring(li+1,ri-li-1).ToCharArray();
			Array.Reverse(rev);
			res+= new string(rev);

		
			res += str.Substring(ri+1);	

			
			str = res;
		}

		return str;
	}

}
