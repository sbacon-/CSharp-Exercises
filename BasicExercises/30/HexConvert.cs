using System;
using System.Collections.Generic;

public class HexConvert{
	public static void Main(){
		
		string s;
		int d;

		System.Console.Write("Hexidecimal Number: ");
		s=Console.ReadLine();

		d=int.Parse(s,System.Globalization.NumberStyles.HexNumber);

		System.Console.WriteLine("Decimal Number: "+d);
	}
}
