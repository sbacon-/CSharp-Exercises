using System;
public class NextPrime{
	public static void Main(){
		
		int x;

		Console.Write("Input an integer: ");
		x=int.Parse(Console.ReadLine());

		Console.WriteLine("Next Prime: "+PrimeX(x));
	}
	private static int PrimeX(int x){
		
		if(x <= 2)return x;
		if(x%2==0)x++;

		bool prime = false;
		while (!prime){
			prime=true;
			for(int i=x-1;i>1;i--){
				if(x%i==0){
					prime=false;
					break;
				}
			}
			if(!prime)x+=2;
		}

		return x;
	}
}
