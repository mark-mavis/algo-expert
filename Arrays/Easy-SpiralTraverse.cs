
using System.Runtime.InteropServices;

class SpiralTraverse{

    public static void Controller(){
        int[,] array = new int[,]{
            {1, 2, 3, 4},
            {10, 11, 12, 5},
            {9, 8, 7, 6}
        };
        //Solutions(array);
        RecursiveSolution(array);
    }

    public static List<int> Solutions(int[,] array){

        List<int> results = new List<int>();
        int rowStart = 0;
        int rowEnd = array.GetLength(0)-1;
        
        int colStart = 0;
        int colEnd = array.GetLength(1)-1;
        
        while(rowEnd >= rowStart && colEnd >= colStart){
            for(int i = colStart; i <= colEnd; i++){
                results.Add(array[rowStart, i]);
            }
            for(int i = rowStart+1; i <= rowEnd; i++){
                results.Add(array[i, colEnd]);
            }
            for(int i = colEnd-1; i >= colStart && rowEnd > rowStart; i--){
                results.Add(array[rowEnd, i]);
            }
            for(int i = rowEnd-1; i > rowStart && colEnd > colStart; i--){
                results.Add(array[i, colStart]);
            }
            colStart++;
            colEnd--;
            rowStart++;
            rowEnd--;
        }
        return results;        
   
    }

    public static void RecursiveSolution(int[,] array){
        List<int> results = new List<int>();
        RecursiveHelper(array, 0, array.GetLength(1)-1, 0, array.GetLength(0)-1, results);
    }

    public static List<int> RecursiveHelper(int[,] array, int colStart, int colEnd, int rowStart, int rowEnd, List<int> results){
        while(rowEnd >= rowStart && colEnd >= colStart){
            for(int i = colStart; i <= colEnd; i++){
                results.Add(array[rowStart, i]);
            }
            for(int i = rowStart+1; i <= rowEnd; i++){
                results.Add(array[i, colEnd]);
            }
            for(int i = colEnd-1; i >= colStart && rowEnd > rowStart; i--){
                results.Add(array[rowEnd, i]);
            }
            for(int i = rowEnd-1; i > rowStart && colEnd > colStart; i--){
                results.Add(array[i, colStart]);
            }
            RecursiveHelper(array, colStart+1, colEnd-1, rowStart+1, rowEnd-1, results);
        }
        return results;




    }
}