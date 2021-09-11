using System;
public class SumExceptFiveSix{
	public static void Main(){
		int[] ar1 = {5,6,1,5,6,9,10,17,5,6};
		int[] ar2 = {5,6,1,5,6,9,10,17};
		int[] ar3 = {1,5,6,9,10,17,5,6};
		int[] ar4 = {1,5,9,10,17,5,6};
		int[] ar5 = {1,5,9,10,17,5};
		Console.WriteLine("Sum of the numbers of the said array except those numbers starting with five followed by atleast one 6:");
		Console.WriteLine(Sum(ar1));
		Console.WriteLine(Sum(ar2));
		Console.WriteLine(Sum(ar3));
		Console.WriteLine(Sum(ar4));
		Console.WriteLine(Sum(ar5));
	}
	private static int Sum(int[] arr){
		int sum = 0;
		
		for(int i = 0; i<arr.Length-1; i++){
			if(arr[i]==5 && arr[i+1]==6){
				arr[i]=0;
				arr[i+1]=0;
				Console.Write("Rem");
			}
			sum+=arr[i];
		}
		sum+=arr[arr.Length-1];

		return sum;
	}
}
