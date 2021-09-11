using System;
public class FivesToFifteen{
	public static void Main(){
		int[] ar1 = {1,5,6,9,10,17};	
		int[] ar2 = {1,5,5,5,10,17};	
		int[] ar3 = {1,1,5,5,5,5};	
		Console.WriteLine(Check(ar1));
		Console.WriteLine(Check(ar2));
		Console.WriteLine(Check(ar3));
	}
	public static bool Check(int[] arr){
		int sum = 0;
		foreach(int i in arr) if(i==5)sum++;
		return sum==3;
	}
}
