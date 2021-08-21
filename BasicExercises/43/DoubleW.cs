using System;
public class DoubleW{
	public static void Main(){
	
		string str;

		System.Console.Write("Input a string: ");
		str = System.Console.ReadLine();

		bool valid = str[0]=='w';

		if(str.Length<5 || str.Substring(1,2)!="ww" || str.Substring(3,2)!="ww")valid=false;

		System.Console.WriteLine(valid);
	}
}
