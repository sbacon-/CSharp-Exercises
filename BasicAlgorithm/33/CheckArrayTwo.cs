using System;
public class CheckArrayTwo{
	public static void Main(){
		int[] arr= {1,2,9,3};
		Console.WriteLine(Check(arr,3));
		int[] arr2 = {1,2,3,4,5,6};
		Console.WriteLine(Check(arr2,2));
		arr[2]=2;
		Console.WriteLine(Check(arr,9));
			
	}
	private static bool Check(int[] arr, int i){
		for(int index=0; index<4; index++){
			if(index==i)return true;	
		}
		return false;
	}
}
