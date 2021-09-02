using System;
public class SumWithQualifiers{
	public static void Main(){
		
		Console.WriteLine(Sum(4,5,7));
		Console.WriteLine(Sum(7,4,12));
		Console.WriteLine(Sum(10,13,12));
		Console.WriteLine(Sum(17,12,18));
	}
	private static int Sum(int x, int y, int z){
		int sum = 0;
		int[] arr = {x,y,z};
		foreach(int i in arr){
			if(i==13 || i ==17)sum+=i;
			if(i>=10 && i<=20)sum-=i;
			sum+=i;
		}
		return sum;		
	}
}
