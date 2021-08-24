using System;
public class FourScore{
	public static void Main(){
		Console.WriteLine(Fourify("C Sharp"));
		Console.WriteLine(Fourify("JS"));
		Console.WriteLine(Fourify("a"));
		Console.WriteLine(Fourify("chancho.dev"));
	}
	private static string Fourify(string str){

		if(str.Length<2)return str;

		str = str.Substring(0,2);//1
		str+=str;//2
		str+=str;//4

		return str;
	}
}
