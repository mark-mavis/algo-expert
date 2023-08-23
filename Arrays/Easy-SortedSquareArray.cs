

class SortedSquareArray
{

    public static void Controller()
    {
        Optimal(new int[] { -50, -13, -2, -1, 0, 0, 1, 1, 2, 3, 19, 20 });
    }

    static int[] BruteForce(int[] array)
    {
        //Time Complexity - n + nlog(n) 
        // n - iterate through the whole array passed
        // nlog(n) - Array.Sort(temp) function
        //Space Complexity - O(n)
        // n - Auxilery Int[] storage

        int[] temp = new int[array.Length]; // <-- Auxilery Storage - Space Complexity O(n)
        for (int i = 0; i < array.Length; i++)
        {
            temp[i] = (int)Math.Pow(array[i], 2);
        }
        Array.Sort(temp);
        return temp;
    }

    static int[] Optimal(int[] array)
    {
        // Time Complexity - O(n)
        // Space Complexity - O(1);
        int[] temp = new int[array.Length];
        int tempIt = temp.Length - 1;
        int start = 0;
        int end = array.Length - 1;

        while (start <= end)
        {
            if (start == end) temp[tempIt] = array[start];
            if (Math.Abs(array[start]) > Math.Abs(array[end]))
            {
                temp[tempIt] = (int)Math.Pow(array[start], 2);
                start++;
            }
            else
            {
                temp[tempIt] = (int)Math.Pow(array[end], 2);
                end--;
            }
            tempIt--;
        }
        Console.WriteLine(string.Join(',', temp));
        return temp;

    }

}