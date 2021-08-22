using System;
public class ConsecutiveString{
	public static void Main(){
		Console.WriteLine(ConString("PHP"));
		Console.WriteLine(ConString("PHPP"));
		Console.WriteLine(ConString("PHHP"));
		Console.WriteLine(ConString("PPHP"));
	}
	private static bool ConString(string str){
		bool result = false;
		
		char[] arr = str.ToCharArray();
		for(int i = 0; i<arr.Length-1; i++){
			if (arr[i] == arr[i+1] ) result=true;
		}

		return result;
	}
}
