using System;
public class LowerFour{
	public static void Main(){
		
		string str;

		System.Console.Write("Input a string: ");
		str = System.Console.ReadLine();

		if(str.Length<4){
			System.Console.WriteLine(str.ToUpper());
		}else{
			System.Console.Write(str.Substring(0,4).ToLower());
			if(str.Length>4)System.Console.Write(str.Substring(4));
			System.Console.WriteLine();
		}

	}
}
