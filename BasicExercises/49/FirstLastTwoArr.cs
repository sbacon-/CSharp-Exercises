using System;
public class FirstLastTwoArr{
	public static void Main(){
	
		int[] arr1 = {1,2,2,3,3,4,5,6,5,7,7,7,8,8,1};
		int[] arr2 = {1,2,2,3,3,4,5,6,5,7,7,7,8,8,5};

		System.Console.WriteLine(
			arr1[0]==arr2[0] ||
			arr1[arr1.Length-1] == arr2[arr2.Length-1]
		);
	}
}
