using System;
public class SequenceCheck{
	public static void Main(){
		int[] arr = {1,1,2,3,1};	
		Console.WriteLine(SeqCheck(arr));
		arr[3]=4;
		Console.WriteLine(SeqCheck(arr));
		int[] arr2 = {1,1,2,1,2,3};
		Console.WriteLine(SeqCheck(arr2));
	}
	private static bool SeqCheck(int[] arr){
		for(int i=0; i<arr.Length -2; i++){
			bool seq = true;	
			for(int j=0;j<3 && seq;j++){
				if(arr[i+j]!=j+1)seq=false;
			}
			if(seq)return true;
		}
		return false;
	}
}
