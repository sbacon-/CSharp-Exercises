using System;
public class ExclusiveOrRange{
	public static void Main(){
		Console.WriteLine(XOrRange(20,84));
		Console.WriteLine(XOrRange(14,50));
		Console.WriteLine(XOrRange(11,45));
		Console.WriteLine(XOrRange(25,40));
	}
	private static bool XOrRange(int x, int y){
		return (x>=20 && x<=50)^(y>=20 && y<=50);
	}	
}
