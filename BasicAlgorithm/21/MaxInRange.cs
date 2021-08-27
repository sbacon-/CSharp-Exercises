using System;
public class MaxInRange{
	public static void Main(){
		Console.WriteLine(Test(78,95));
		Console.WriteLine(Test(20,30));
		Console.WriteLine(Test(21,25));
		Console.WriteLine(Test(28,28));	
	}
	private static int Test(int x, int y){
		if(!(x>=20&&x<=30))x=0;
		if(!(y>=20&&y<=30))y=0;
		return (x>y)?x:y;	
	}
}
