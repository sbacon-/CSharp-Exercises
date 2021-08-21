using System;
public class ProductArray{
	public static void Main(){
	
            System.Console.WriteLine(MaxProduct(new int[] { 2, 4, 2, 6, 9, 3 }) == 27);
            System.Console.WriteLine(MaxProduct(new int[] { 0, -1,-1, -2 }) == 2);
            System.Console.WriteLine(MaxProduct(new int[] { 6, 1, 12, 3, 1, 4 }) == 36);
            System.Console.WriteLine(MaxProduct(new int[] { 1, 4, 3, 0 }) == 16);
	
	}
	private static int MaxProduct(int[] arr){
		
		int product=arr[0]*arr[1];
		
		for(int i = 0; i<arr.Length-1; i++){
			
			product = (arr[i]*arr[i+1])>product?arr[i]*arr[i+1]:product;

		}
		
		return product;

	}
}
