using System;
public class IncreasingSequence{
	public static void Main(){

		System.Console.WriteLine(CheckIncrease(new int[] {1,3, 5,6,9}));
             	System.Console.WriteLine(CheckIncrease(new int[] {0,10}));
             	System.Console.WriteLine(CheckIncrease(new int[] {1, 3, 1, 3}));
        	
		
	}
	private static bool CheckIncrease(int[] arr){
		
		bool result = true;

		for(int i=0; i<arr.Length-1;i++){
			if(arr[i]>arr[i+1])result=false;
		}

		return result;
	}
}
