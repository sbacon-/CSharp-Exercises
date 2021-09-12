using System;
public class FiveIndividualFives{
	public static void Main(){
		int[] ar1 = { 3, 5, 1, 5, 3, 5, 7, 5, 1, 5 };
		int[] ar2 = { 3, 5, 5, 5, 5, 5, 5};
		int[] ar3 = { 3, 5, 2, 5, 4, 5, 7, 5, 8, 5};
		int[] ar4 = { 2, 4, 5, 5, 5, 5};
		Console.WriteLine(Check(ar1));
		Console.WriteLine(Check(ar2));
		Console.WriteLine(Check(ar3));
		Console.WriteLine(Check(ar4));

	}
	private static bool Check(int[] arr){
		int count = 0;
		for(int i = 0; i<arr.Length; i++){
			if(arr[i] == 5){
				count++;
				if(i!=arr.Length-1 && arr[i+1]==5)return false;
			}
		}
		return count==5;
	}
}
