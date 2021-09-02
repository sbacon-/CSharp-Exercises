using System;
public class SumOfThreeDifferent{
	public static void Main(){
		
		Console.WriteLine(Sum(4,5,7));
		Console.WriteLine(Sum(7,4,12));
		Console.WriteLine(Sum(10,10,12));
		Console.WriteLine(Sum(12,12,18));
	}
	private static int Sum(int x, int y, int z){
		if(z==y)return x;
		if(z==x)return y;
		if(y==x)return z;
		
		return (x+y+z);	
	}
}
