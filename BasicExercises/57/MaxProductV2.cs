using System;
public class MaxProductV2{
	public static void Main(){

 		System.Console.WriteLine(MaxProduct(new int[] {1, -3, 4, -5, 1}));
             	System.Console.WriteLine(MaxProduct(new int[] {1 , 3, 4, 5, 2}));
             	System.Console.WriteLine(MaxProduct(new int[] {1 , 3, -4, 5, 2}));
             	System.Console.WriteLine(MaxProduct(new int[] {1 , 0, -4, 0, 2}));
         	
	
	}
	private static string MaxProduct(int[] arr){
		
		int index = 0;
		int product = arr[index] * arr[index+1];

		for(int i=1; i<arr.Length-1;i++){
			int tempProduct = arr[i]*arr[i+1];
			if(tempProduct>product){
				product=tempProduct;
				index=i;
			}
		}

		return (arr[index]+" * "+arr[index+1]+" = "+product);
	}
}
