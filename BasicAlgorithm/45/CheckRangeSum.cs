using System;
public class CheckRangeSum{
	public static void Main(){
		Console.WriteLine(Sum(3,7));
		Console.WriteLine(Sum(10,11));
		Console.WriteLine(Sum(10,20));
		Console.WriteLine(Sum(21,220));
		
	}
	private static int Sum(int x, int y){
		if(Math.Abs(15-x)<=5 || Math.Abs(15-y)<=5)return 18;
		return x+y;
	}
}
