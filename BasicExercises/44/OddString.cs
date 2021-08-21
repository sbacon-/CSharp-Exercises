using System;
public class OddString{
	public static void Main(){
		
		string str,result="";

		System.Console.Write("Input a string: ");
		str=System.Console.ReadLine();

		for(int i = 1; i<str.Length-1; i+=2){
			result+=str[i];
		}
		
		System.Console.WriteLine(result);
	}
}
