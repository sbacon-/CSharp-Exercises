using System;
public class StrictIncrease{
	public static void Main(){
		Console.WriteLine(Check(1,2,3));
		Console.WriteLine(Check(1,2,3,true));
		Console.WriteLine(Check(10,2,30));
		Console.WriteLine(Check(10,10,30,true));	
	}
	private static bool Check(int x,int y ,int z){
		return Check(x,y,z,false);
	}
	private static bool Check(int x,int y, int z, bool e){
		if(!e && (x==y || x==z || y==z))return false;
		return x<=y && y<=z;
	}
}
