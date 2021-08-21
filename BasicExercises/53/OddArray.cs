using System;
public class OddArray{
	public static void Main(){
		int[] arr = {2,4,6,7,8};

		bool odd = false;

		foreach(int i in arr)if(i%2!=0)odd=true;

		System.Console.WriteLine(odd);
	}
}
