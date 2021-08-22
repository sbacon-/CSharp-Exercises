using System;
using System.Linq;

public class FilesPath{
	public static void Main(){
		Console.WriteLine(FileFromPath("/home/tom/test.txt"));		
		Console.WriteLine(FileFromPath("/usr/local/bin/cSharp"));
		Console.WriteLine(FileFromPath("/home/tom/Code/cSharpExercises/BasicExercises/64/FilesPath.cs"));
	}
	private static string FileFromPath(string str){
		return str.Split('/').Last();
	}
}
