using System;
public class WithinRange{
	public static void Main(){
	
		Console.WriteLine(TenCheck(103));
		Console.WriteLine(TenCheck(90));
		Console.WriteLine(TenCheck(89));
	
	}
	private static bool TenCheck(int x){
		
		return (Math.Abs(100-x)<=10 || Math.Abs(200-x)<=10 );
	}
}
