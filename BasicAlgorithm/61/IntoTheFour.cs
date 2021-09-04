using System;
public class IntoTheFour{
	public static void Main(){
		Console.WriteLine(Ins("[[]]","Hello"));
		Console.WriteLine(Ins("(())","Hi"));
	}
	private static string Ins(string p,string s){
		return p.Substring(0,2)+s+p.Substring(2);
	}
}
