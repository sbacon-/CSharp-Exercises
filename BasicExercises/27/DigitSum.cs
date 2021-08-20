using System;

public class DigitSum{
	public static void Main(){
		
		int x,pow=5,sum=0;
		System.Console.Write("Input integer up to 10^"+pow+": ");
		x=int.Parse(System.Console.ReadLine());

		while(pow>=0){
			
			sum+=x/(int)Math.Pow(10,pow);

			x%=(int)Math.Pow(10,pow);

			pow--;
		}
		
		System.Console.WriteLine(sum);

	}
}
