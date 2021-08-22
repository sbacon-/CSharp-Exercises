using System;
public class ASCIINumber{
	public static void Main(){
		Console.WriteLine("Ascii value of 1 is: "+ASCIINum('1'));
		Console.WriteLine("Ascii value of A is: "+ASCIINum('A'));
		Console.WriteLine("Ascii value of a is: "+ASCIINum('a'));
		Console.WriteLine("Ascii value of # is: "+ASCIINum('#'));
	}
	private static int ASCIINum(char c){
		return (int)c;
	}
}
