using System;
public class RemoveEndingInSeven{
	public static void Main(){
		int[] arr ={ 10, 22, 35 , 47, 53, 67 };
		PrintArray(Conv(arr));
	}
	private static int[] Conv(int[] arr){
		int count = 0;
		foreach(int i in arr) if (i%10!=7) count++;

		int[] res = new int[count];
		int pos = 0;
		for(int i = 0; i < arr.Length; i++){
			if(arr[i]%10!=7)res[pos++]=arr[i];
		}
		return res;
	}
	private static void PrintArray(int[] arr){
		Console.Write("new array: ");
		foreach(int a in arr)Console.Write(a+" ");
		Console.WriteLine();
	}
}
