using PrintUtil;

class TwoNumberSum
{
    public static void Controller()
    {
        int[] unsorted_arr = new int[] { -21, 301, 12, 4, 65, 56, 210, 356, 9, -47 };
        ArrayPrinter.Print(TwoNumberSum.UnsortedArrays(unsorted_arr, 163));

        int[] sorted_arr = new int[] { 3, 5, -4, 8, 11, 1, -1, 6 };
        ArrayPrinter.Print(TwoNumberSum.SortedArrays(sorted_arr, 10));
    }
    public static int[] UnsortedArrays(int[] array, int targetSum)
    {
        // Time Complexity - O(N)
        // Space Complexity - O(N)

        HashSet<int> searchVals = new HashSet<int>();  // <--- Auxilary storage makes this method a space complexity of O(N)

        for (int i = 0; i < array.Length; i++)
        {
            int currVal = array[i];
            if (searchVals.Contains(currVal))
            {
                return new int[] { targetSum - currVal, array[i] };
            }
            else
            {
                searchVals.Add(targetSum - array[i]);
            }
        }
        return new int[0];
    }
    public static int[] SortedArrays(int[] array, int targetSum)
    {
        //Time Complexity - O(nlog(n))
        //Space Complexity - O(1)

        //Array.Sort(array); <--- if we are receiving unsorted arrays

        int right_idx = array.Length - 1;
        int left_idx = 0;

        while (left_idx < right_idx)
        {
            int currentSum = array[right_idx] + array[left_idx];
            if (currentSum == targetSum) return new int[] { array[left_idx], array[right_idx] };
            else if (currentSum < targetSum) left_idx++;
            else if (currentSum > targetSum) right_idx--;
        }
        return new int[0];
    }
}