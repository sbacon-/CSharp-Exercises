using System;

public class MultiTable{
	public static void Main(){

		int x;

		System.Console.Write("Input number: ");
		x=int.Parse(System.Console.ReadLine());
		
		for(int i=1; i<13; i++){
			System.Console.WriteLine(x+" * "+i+" = "+(x*i));
		}
	}
}	
