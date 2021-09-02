using System;
public class MaxModuloSeven{
	public static void Main(){
		
		Console.WriteLine(Max(11,21));
		Console.WriteLine(Max(11,20));
		Console.WriteLine(Max(10,10));

	}

	private static int Max(int x, int y){
		if(x==y)return 0;
		return x%7==y%7?Math.Min(x,y):Math.Max(x,y);
	}
}

