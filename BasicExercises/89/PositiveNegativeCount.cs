using System;
public class PositiveNegativeCount{
	public static void Main(){

		int[] test = {10,-11,12,-13,14,-18,19,-20};
		Test(test);

		int[] test2={-4,-3,-2,0,3,5,6,2,6};
		Test(test2);

	}
	private static void PosNeg(int[] arr){

		int pos=0, neg=0;

		foreach(int i in arr){
			if(i>0)pos++;
			else if(i<0) neg++;
		}

		Console.WriteLine("+: "+pos);
		Console.WriteLine("-: "+neg);

	}
	private static void Test(int[] arr){
		Console.WriteLine("Original Array");

		Console.Write("[ ");
		foreach(int i in arr)Console.Write(i+" ");
		Console.WriteLine("]");

		PosNeg(arr);

		Console.WriteLine();
	}
}
