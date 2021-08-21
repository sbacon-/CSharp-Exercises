using System;
public class ArrayCount{
	public static void Main(){
		
		int[] arr = {1,2,2,3,3,4,5,6,5,7,7,7,8,8,1};

		int x,count=0;

		System.Console.Write("Input an integer to search: ");
		x=int.Parse(System.Console.ReadLine());

		foreach(int y in arr)if(x==y)count++;

		System.Console.WriteLine("There are "+count+" occurences of "+x+" in the array");
		
	}
}
