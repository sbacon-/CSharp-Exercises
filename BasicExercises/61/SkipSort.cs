using System;
public class SkipSort{
	public static void Main(){
		PrintArray(SortSome((new int[] {-5, 236, 120, 70, -5, -5, 698, 280 })));
	}
	private static int[] SortSome(int[] arr){
		
		int[] result = new int[arr.Length];

		for(int i=0; i<arr.Length; i++){
			if(arr[i]==-5) result[i]=arr[i];
		}
		
		Array.Sort(arr);
		int index = 0;	
		foreach(int a in arr){
			if (a==-5)continue;
			while(result[index]==-5)index++;

			result[index++]=a;
			
		}

		return result;

	}
	private static void PrintArray(int[] arr){
		
		System.Console.Write("[ ");
		foreach(int a in arr){
			System.Console.Write(a+" ");
		}
		System.Console.WriteLine("]");

	}
}

