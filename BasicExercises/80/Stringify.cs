using System;
public class Stringify{
	public static void Main(){
		
		object[] test = new object[5];
		
		test[0] = 25;
		test[1] = "Anna";
		test[2] = false;
		test[3] = System.DateTime.Now;
		test[4] = 112.22;
		
		PrintArray(test);
		Console.WriteLine("------");
		PrintArray(StrArr(test));

	}
	private static object[] StrArr(object[] arr){
		
		for(int i=0; i<arr.Length; i++){
			
			arr[i] = arr[i].ToString();

		}

		return arr;

	}
	private static void PrintArray(object[] arr){
		
		foreach(object a in arr){
			Console.WriteLine("Val: "+a+" :: Type: "+a.GetType());
		}

	}
}
