using System;
public class Palindrome{
	public static void Main(){
	
		string str;

		System.Console.Write("Input a string: ");
		str = System.Console.ReadLine();
		
		bool palin =true;

		for(int i=0;i<str.Length/2;i++){
			if(str[i]!=str[str.Length-1-i])palin=false;
		}
		
		System.Console.WriteLine(palin);

	}
}
