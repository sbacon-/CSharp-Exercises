using System;
using System.Linq;

public class ArrayRange{
	public static void Main(){
		int[] arr = {1,3,5,7,9,11,12};

		Console.WriteLine(Range(arr));		
	}
	private static int Range(int[] arr){
		return arr.Max()-arr.Min();
	}
}
