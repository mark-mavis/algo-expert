


class ThreeNumberArray
{

    public static void Controller(int targetSum)
    {
        int[] array = new int[] { 12, 3, 1, 2, -6, 5, -8, 6 };

        //BruteForce(array, targetSum);
        Optimal(array, targetSum);
    }

    public static List<int[]> BruteForce(int[] array, int targetSum)
    {
        // Time Complexity - O(n^3)
        //  - n^3 <-- nested forloops
        // Space Complexity - O(n)
        //  - n <-- List<int[]>

        List<int[]> combinations = new List<int[]>();

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                for (int k = 0; k < array.Length; k++)
                {
                    if ((i != j && i != k && j != k) && (i < j && j < k))
                    {
                        int combinationSum = array[i] + array[j] + array[k];

                        if (array[i] + array[j] + array[k] == targetSum)
                        {
                            int[] combination = new int[] { array[i], array[j], array[k] };
                            Array.Sort(combination);
                            combinations.Add(combination);
                        }
                    }
                }
            }
        }
        return combinations;
    }

    public static List<int[]> Optimal(int[] array, int targetSum)
    {
        List<int[]> combinations = new List<int[]>();
        Array.Sort(array);

        for (int i = 0; i < array.Length - 2; i++)
        {
            int currBaseVal = array[i];
            int lPtr = i + 1;
            int rPtr = array.Length - 1;
            while (lPtr < rPtr)
            {
                int cs = currBaseVal + array[lPtr] + array[rPtr];
                if (cs == targetSum)
                {
                    combinations.Add(new int[] { currBaseVal, array[lPtr], array[rPtr] });
                    lPtr++;
                }
                else if (cs < targetSum) lPtr++;
                else rPtr--;
            }
        }
        return new List<int[]>();
    }





}