using System;
using System.Collections.Generic;
using System.IO;

public class FileMeasure{
	public static void Main(){
		FileInfo f = new FileInfo("./TestFile.txt");
		Console.WriteLine("Size of file: "+f.Length.ToString());
	}
}
