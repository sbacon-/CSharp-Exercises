using System;
public class CharacterCount{
	public static void Main(){
		
		string text;
            text = "Python 3.0";
            Console.WriteLine("Original string:: "+text);
            Console.WriteLine(CharCount(text));
            text = "dsfkaso230samdm2423sa";
            Console.WriteLine("\nOriginal string:: " + text);
            Console.WriteLine(CharCount(text));

	}
	private static string CharCount(string str){
		int digits = 0, letters = 0;

		foreach(char c in str.ToCharArray()){
			if(char.IsLetter(c))letters++;
			if(char.IsDigit(c))digits++;
		}

		return ("Letters: "+letters+" || Digits: "+digits);

	}
}
