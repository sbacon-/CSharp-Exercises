using System;

public class PHCheck{
	public static void Main(){
		
		string str;

		System.Console.Write("Input a string: ");
		str = System.Console.ReadLine();

		string result = "";

		if(str[0]=='P')result+=str[0];
		if(str[1]=='H')result+=str[1];

		System.Console.WriteLine(result);
	}
}
