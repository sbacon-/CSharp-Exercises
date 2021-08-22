using System;
public class NthOdd{
	public static void Main(){
		
		NOdd(1);
		NOdd(2);
		NOdd(4);
		NOdd(100);

	}
	private static void NOdd(int n){
		Console.Write(n);
		if(n%100>10 && n%100<14)Console.Write("th ");
		else{
			switch(n%10){
				case 1:
					Console.Write("st ");
					break;
				case 2:
					Console.Write("nd ");
					break;
				case 3:
					Console.Write("rd ");
					break;
				default:
					Console.Write("th ");
					break;
			}
		}
		Console.WriteLine("odd number: "+((n*2)-1));
	}
}
