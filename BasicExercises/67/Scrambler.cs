using System;
public class Scrambler{
	public static void Main(){
		Console.WriteLine(Scramble("PHP"));
		Console.WriteLine(Scramble("JAVASCRIPT"));
	}
	private static string Scramble(string str){
		char[] arr = str.ToCharArray();
		
		for(int i = 0; i < arr.Length; i++){
			switch(arr[i]){
				case 'P':
					arr[i]='9';
					break;
				case 'T':
					arr[i]='0';
					break;
				case 'S':
					arr[i]='1';
					break;
				case 'H':
					arr[i]='6';
					break;
				case 'A':
					arr[i]='8';
					break;
			}
		}
	
		return new string(arr);
	}
}
