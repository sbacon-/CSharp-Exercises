using System;
public class IntegersOnly{
	public static void Main(){
	
		object[] mixedArray = new object[6];
            mixedArray[0] = 25;
            mixedArray[1] = "Anna";
            mixedArray[2] = false;
            mixedArray[3] = System.DateTime.Now;
            mixedArray[4] = -112;
            mixedArray[5] = -34.67;

	    	Test(mixedArray);
		
	}
	private static int[] IntOnly(object[] arr){
		
		int size = 0;
		foreach(object o in arr){
			if (o.GetType() == size.GetType()) size++;
		}
		
		int[] result = new int[size];
		int index = 0;
		foreach(object o in arr){
			if (o.GetType() == index.GetType()) result[index++]=(int)o;
		}

		return result;
	}
	private static void Test(object[] arr){
		
		Console.WriteLine("Original Array: ");
		foreach(object o in arr) Console.Write(o + " ");

		Console.WriteLine();
		
		Console.WriteLine("Integer Array: ");
		foreach(int i in IntOnly(arr)) Console.Write(i + " ");

		Console.WriteLine();
	}
}
