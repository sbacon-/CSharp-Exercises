using System;
public class DoubleFiveOrSeparatedFive{
	public static void Main(){
		int[] ar1 = { 5, 5, 1, 5, 5 };
		int[] ar2 = { 1, 2, 3, 4 };
		int[] ar3 = { 3, 3, 5, 5, 5, 5};
		int[] ar4 = { 1, 5, 5, 7, 8, 10};
		Console.WriteLine(Check(ar1));
		Console.WriteLine(Check(ar2));
		Console.WriteLine(Check(ar3));
		Console.WriteLine(Check(ar4));

	}
	private static bool Check(int[] arr){
		for(int i=0; i < arr.Length-1; i++){
			if(arr[i] == 5 && arr[i+1] == 5) return true;
			if(i!=arr.Length-2 && (arr[i]==5 && arr[i+2]==5)) return true;
		}
		return false;
	}
}
