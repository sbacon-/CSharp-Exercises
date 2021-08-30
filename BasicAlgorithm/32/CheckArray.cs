using System;
public class CheckArray{
	public static void Main(){
		int[] arr= {1,2,9,3};
		Console.WriteLine(Check(arr,3));
		arr[2]=2;
		Console.WriteLine(Check(arr,2));
		Console.WriteLine(Check(arr,9));
			
	}
	private static bool Check(int[] arr, int i){
		foreach(int index in arr){
			if(index==i)return true;	
		}
		return false;
	}
}
