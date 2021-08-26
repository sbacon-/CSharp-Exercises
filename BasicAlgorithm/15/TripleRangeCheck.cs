using System;
public class TripleRangeCheck{
	public static void Main(){
		Console.WriteLine(Triple(11,20,12));
		Console.WriteLine(Triple(30,30,17));
		Console.WriteLine(Triple(25,35,50));
		Console.WriteLine(Triple(15,12,8));
	}
	private static bool Triple(int x,int y,int z){
		return Range(x) || Range(y) || Range(z);
		
	}
	private static bool Range(int x){
		return x>=20 && x<=50;
	}
}
