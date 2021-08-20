using System;

public class Temperatures{
	public static void Main(){
		
		float c;

		System.Console.Write("Input Temp in (C): ");
		c = float.Parse(System.Console.ReadLine());

		float k,f;

		k = c + 273.15f;
		f = (9/5) * c + 32;

		System.Console.WriteLine("Celcius: "+c);
		System.Console.WriteLine("Kelvin: "+k);
		System.Console.WriteLine("Farenheit: "+f);

	}
}
