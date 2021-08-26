using System;
public class RangeTemperature{
	public static void Main(){
		Console.WriteLine(Temp(120,-1));
		Console.WriteLine(Temp(-1,120));
		Console.WriteLine(Temp(120,2));
	}
	private static bool Temp(int x, int y){

		bool a = x>100 || y>100;
		bool b = x<0 || y<0;
		
		return a && b;

	}
}
