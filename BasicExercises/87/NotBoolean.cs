using System;
public class NotBoolean{
	public static void Main(){

		bool b = false;
		Console.WriteLine(b+" -->"+NotBool(b));
		b = true;
		Console.WriteLine(b+" -->"+NotBool(b));

	}
	private static bool NotBool(bool b){
		return !b;
	}
}
