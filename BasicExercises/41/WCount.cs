using System;
public class WCount{
	public static void Main(){
	
		string str;

		System.Console.Write("Input a string: ");
		str = System.Console.ReadLine();

		int wCount = 0;

		foreach(char c in str.ToCharArray()){
			if(c=='w' || c=='W') wCount++;
		}

		System.Console.WriteLine(wCount>0 && wCount<4);

	}
}
