using System;

namespace easy1
{
    class Program
    {

        public static int[] TwoNumberSum(int[] array, int targetSum) {
            
            for(int i = 0; i < array.Length - 1; i++){
                int firstNum = array[i];
                for(int j = i + 1; j < array.Length; j++){
                    int secondNum = array[j];
                    if((firstNum + secondNum) == targetSum){
                        return new int[] {firstNum, secondNum};
                    }
                }
            }

		return new int[0];
        
        }
	
        static void Main(string[] args)
        {
            int[] newArray = {1,2,3,4,5,6,7,8,9};
            int target = 10;
            int[] result;

            result = TwoNumberSum(newArray, target);
            
            Console.WriteLine(result);
        }
    }
}
