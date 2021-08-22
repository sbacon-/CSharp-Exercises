using System;
public class StringNumbers{
	public static void Main(){
		Console.WriteLine(MinimumStr("12","42"));		
	}
	private static int MinimumStr(string a, string b){
		int x = int.Parse(a);
		int y = int.Parse(b);

		return x>y?y:x;
	}	
}
