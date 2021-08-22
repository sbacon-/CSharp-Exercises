using System;
public class BinaryCount{
	public static void Main(){
		
		int test = 12;

		Console.WriteLine("Decimal: "+test);
		BinCount(test);
		

		test = 1234;

		Console.WriteLine("Decimal: "+test);
		BinCount(test);

	}
	private static void BinCount(int i){
	
		string str = Convert.ToString(i,2);
		
		int one = 0, zero = 0;
		
		foreach(char c in str.ToCharArray()){
			if(c=='1')one++;
			if(c=='0')zero++;
		}

		Console.WriteLine("1: "+one);
		Console.WriteLine("0: "+zero);
	}
}
