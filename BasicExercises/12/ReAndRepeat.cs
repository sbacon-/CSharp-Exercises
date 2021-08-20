using System;

public class ReAndRepeat{
	public static void Main(){

		int x;
		
		System.Console.Write("Input number: ");
		x = int.Parse(System.Console.ReadLine());

		for (int i = 0; i<4; i++){
			for(int j = 0; j < 4; j++){
				String str = x + ((i%2==0)?" ":"");
				System.Console.Write(str);
			}
			System.Console.Write("\n");
		}
	}
}	
