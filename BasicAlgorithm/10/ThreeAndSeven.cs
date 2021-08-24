using System;
public class ThreeAndSeven{
	public static void Main(){
		Console.WriteLine(StoneAge(3));	
		Console.WriteLine(StoneAge(14));	
		Console.WriteLine(StoneAge(12));	
		Console.WriteLine(StoneAge(37));	
	}
	private static bool StoneAge(int i){
		return (i%3==0) || (i%7==0);
	}
}
