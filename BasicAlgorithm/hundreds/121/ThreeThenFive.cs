using System;
public class ThreeThenFive{
	public static void Main(){
		int[] ar1 = { 3, 5, 1, 3, 7 };
		int[] ar2 = { 1, 2, 3, 4 };
		int[] ar3 = { 3, 3, 5, 5, 5, 5};
		int[] ar4 = { 2, 5, 5, 7, 8, 10};
		Console.WriteLine(Check(ar1));
		Console.WriteLine(Check(ar2));
		Console.WriteLine(Check(ar3));
		Console.WriteLine(Check(ar4));

	}
	private static bool Check(int[] arr){
		
		bool thr=false;
		foreach(int a in arr){
			if(thr && a==5)return true;
			if(a==3)thr=true;
		}
		
		return false;
	}
}
