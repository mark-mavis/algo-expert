using System.Linq;
using System.Collections;
class MergeOverlappingIntervals{
    public static void Controller(){
        int[,] TwoDArray = new int[,]{{1, 2}, {3, 5}, {4, 7}, {6, 8}, {9, 10}};
        Solution1(TwoDArray);


    }

    public static int[,] Solution1(int[,] intervals){   
        for(int i = 0; i < intervals.GetLength(0); i++){
            for(int j = 0; j < intervals.GetLength(1); j++){
                Console.WriteLine(intervals[i,j]);
            }
        }

        
        Array.Sort(intervals, , intervals.Length);

        SortedList<int, int> kvp = new SortedList<int, int>();
        for(int i = 0; i < intervals.Length; i++){
            kvp.Add(intervals[i,0], )
        }

        return new int[0,0];
    }
}