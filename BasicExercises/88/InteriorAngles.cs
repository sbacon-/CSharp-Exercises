using System;
public class InteriorAngles{
	public static void Main(){
		
		int s = 0;
		Console.Write("Input number of sides: ");
		s = int.Parse(Console.ReadLine());

		//if(s<3)Console.WriteLine("Not a valid polygon");
		
		Console.WriteLine(s+" sides --> SUM: "+SumAngles(s));
		Console.WriteLine("Each angle is: "+SumAngles(s)/s+" degrees");

	}
	private static int SumAngles(int s){
		return s*(180-(360/s));
	}
}
