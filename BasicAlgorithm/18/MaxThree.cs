using System;
public class MaxThree{
	public static void Main(){
		Console.WriteLine(Max(1,2,3));
		Console.WriteLine(Max(1,3,2));
		Console.WriteLine(Max(1,1,1));
		Console.WriteLine(Max(1,2,2));
		
	}
	private static int Max(int x,int y,int z){
		return (x>y?(x>z?x:z):(y>z?y:z));
	}
}
