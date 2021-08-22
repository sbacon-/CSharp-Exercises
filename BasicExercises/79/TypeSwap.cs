using System;
public class TypeSwap{
	public static void Main(){
		int test1 = 50;
		string test2 = "122";

		Console.WriteLine(test1+" :"+test1.GetType());
		Console.WriteLine(test1+" :"+SwapInt(test1).GetType());
		Console.WriteLine(test2+" :"+test2.GetType());
		Console.WriteLine(test2+" :"+SwapStr(test2).GetType());
	}
	private static int SwapStr(string str){
		return int.Parse(str);
	}
	private static string SwapInt(int i){
		return i.ToString();
	}
}
