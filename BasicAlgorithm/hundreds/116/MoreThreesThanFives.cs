using System;
public class MoreThreesThanFives{
	public static void Main(){
		int[] ar1 ={ 1, 5, 6, 9, 3, 3 };
		int[] ar2 ={ 1, 5, 5, 5, 10, 17 };
		int[] ar3 ={ 1, 3, 3, 5, 5, 5};
		Console.WriteLine(Check(ar1));
		Console.WriteLine(Check(ar2));
		Console.WriteLine(Check(ar3));
		
	}
	private static bool Check(int[] arr){
		int thr=0, fiv=0;
		foreach(int a in arr){
			if(a==3)thr++;
			else if (a==5)fiv++;
		}
		return thr>fiv;
	}
}
