using System;
public class OrderedEulers{
	public static void Main(){
		Console.WriteLine(Check(1,2,3));
		Console.WriteLine(Check(4,5,6));
		Console.WriteLine(Check(-1,1,0));		
	}
	private static bool Check(int x, int y, int z){
		return y>x && y<z;
	}
}
