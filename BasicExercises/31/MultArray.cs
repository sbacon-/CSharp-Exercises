using System;

public class MultArray{
	public static void Main(){
		
		int[] arr1 = {1,3,-5,4};
		int[] arr2 = {1,4,-5,-2};

		for(int i=0; i<arr1.Length; i++){
			Console.Write(arr1[i]*arr2[i]);
			Console.Write(" ");
		}

		Console.WriteLine();

	}
}
