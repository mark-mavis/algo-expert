using System.Linq;
class ArrayOfProducts{

    public static void Controller(){
        //int[] array = new int[]{5, 1, 4, 2};
        //Solution1(array);

        //int[] array = new int[]{0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        int[] array = new int[]{0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
        Improved(array);
    }

    public static int[] BruteForce(int[] array){

        int[] result = new int[array.Length];
        
        int multiplier = 1;
        int count = 0;
        
        for(int i = 0; i < array.Length; i++){
            if(array[i] != 0){
                multiplier *= array[i];
                count++;
            }
        }

        if(count == 0) return result;

        for(int i = 0; i < array.Length; i++){
            int tempMult = 1;
            for(int j = 0; j < array.Length; j++){
                if(i == j) continue;
                tempMult *= array[j];
            }
            result[i] = tempMult;
        }
        return result;
    }

    public static int[] Improved(int[] array){
          
        return new int[0];
    }
}