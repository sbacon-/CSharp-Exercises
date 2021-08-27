using System;
public class LastDigitCheck{
	public static void Main(){
		
		Console.WriteLine(DigitCheck(123,456));
		Console.WriteLine(DigitCheck(12,512));
		Console.WriteLine(DigitCheck(7,87));
		Console.WriteLine(DigitCheck(12,45));
	}
	private static bool DigitCheck(int x,int y){
		return x%10 == y%10;
	}
}
