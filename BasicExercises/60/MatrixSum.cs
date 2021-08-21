using System;
public class MatrixSum{
	public static void Main(){
		Console.WriteLine(Sumify(
                new int[][] {
                    new int[]{0, 2, 3, 2},
                    new int[]{0, 6, 0, 1},
                    new int[]{4, 0, 3, 0}
                }));
            	Console.WriteLine(Sumify(
                new int[][] {
                    new int[]{1, 2, 1, 0 },
                    new int[]{0, 5, 0, 0},
                    new int[]{1, 1, 3, 10 }
                }));
           	Console.WriteLine(Sumify(
                new int[][] {
                    new int[]{1, 1},
                    new int[]{2, 2},
                    new int[]{3, 3},
                    new int[]{4, 4}
                }));
	}
	private static int Sumify(int[][] mat){
	
		int sum = 0;

		for(int i=0; i< mat[0].Length; i++){
			foreach(int[] arr in mat){
				if(arr[i]==0)break;
				else sum+=arr[i];
			}
		}
		
		return sum;
	}

}
