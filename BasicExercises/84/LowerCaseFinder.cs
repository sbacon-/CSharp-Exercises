using System;
using System.Linq;
using System.Text;

public class LowerCaseFinder{
	public static void Main(){
		string text;
           	text = "Python";
	        Console.WriteLine("Orginal string: "+text);
                int[] result = LCFind(text);
                Console.WriteLine("\nIndices of all lower case letters of the said string:");
                foreach (var item in result)
                {
                    Console.WriteLine(item.ToString()+" ");
                }
                text = "JavaScript";
                Console.WriteLine("\nOrginal string: " + text);
                result = LCFind(text);
                Console.WriteLine("\nIndices of all lower case letters of the said string:");
                foreach (var item in result)
                {
                    Console.WriteLine(item.ToString() + " ");
                }
	}
	public static int[] LCFind(string str){

		StringBuilder sb = new StringBuilder();

		char[] arr = str.ToCharArray();
		for(int i  = 0; i < arr.Length; i++) if(arr[i]>='a' && arr[i]<='z') sb.Append(i+"/");

		string[] indicies = sb.ToString().Split("/"); 
		
		int[] result = new int[indicies.Length-1];

		for(int i = 0; i<result.Length; i++){
			result[i]=int.Parse(indicies[i].ToString());
		}

		return result;
	}

	/* The correct solution 
	public static int[] LCFind(string str){
		return str.Select((x,i)=>i).Where(i=>char.IsLower(str[i])).ToArray();
	}
	*/
}
