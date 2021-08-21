using System;
public class Century{
	public static void Main(){
	
		int year;

		System.Console.Write("Input a year: ");
		year = int.Parse(System.Console.ReadLine());
		int century = (year/100)+1;
			
		if(century<0){
			System.Console.WriteLine("Please enter a year in this; the year of our lord Jesus Christ");
			return;
		}

		if(century%100>10 && century%100<14){
			System.Console.WriteLine(century+"th century");
			return;
		}

		switch(century%10){
			case 1:
				System.Console.WriteLine(century+"st century");
				break;
			case 2:
				System.Console.WriteLine(century+"nd century");
				break;
			case 3:
				System.Console.WriteLine(century+"rd century");
				break;
			default:
				System.Console.WriteLine(century+"th century");
				break;

		}
		
	}
}
