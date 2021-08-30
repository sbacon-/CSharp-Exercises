using System;
public class TripleFinder{
	public static void Main(){
		int[] ar1 = {1,1,2,2,1};
		int[] ar2 = {1,1,2,1,2,3};
		int[] ar3 = {1,1,1,2,2,2,1};

		Console.WriteLine(CheckEm(ar1));
		Console.WriteLine(CheckEm(ar2));
		Console.WriteLine(CheckEm(ar3));
		
	}
	private static bool CheckEm(int[] arr){
		for(int i=0; i<arr.Length-2; i++){
			if(arr[i]!=arr[i+1])continue;
			if(arr[i]!=arr[i+2]){
				i++;
				continue;
			}
			return true;
		}
		return false;
	}
}
