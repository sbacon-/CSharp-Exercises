using System;

public class First500{
	public static void Main(){
		
		int sum = 0, count = 0;
		
		for(int i=2;count<500;i++){

			int divisors = 0;

			for(int j = i; j>0; j--){

				if(i%j==0)divisors++;
			
			}

			if (divisors == 2){

				sum+=i;
				count++;


			}

		}

		System.Console.WriteLine(sum);

	}
}
