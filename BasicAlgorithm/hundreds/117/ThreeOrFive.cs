using System;
public class ThreeOrFive{
	public static void Main(){
		int[] ar1 = { 5, 5, 5, 5, 5 };
		int[] ar2 = { 3, 3, 3, 3 };
		int[] ar3 = { 3, 3, 3, 5, 5, 5};
		int[] ar4 = { 1, 6, 8, 10};
		Console.WriteLine(Check(ar1));
		Console.WriteLine(Check(ar2));
		Console.WriteLine(Check(ar3));
		Console.WriteLine(Check(ar4));

	}
	private static bool Check(int[] arr){
		foreach(int a in arr) if (a==3 || a==5)return true;
		return false;
	}
}
