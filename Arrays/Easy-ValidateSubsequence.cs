
class ValidateSubsequence
{
    public static void Controller()
    {
        List<int> array = new List<int>() { 5, 1, 22, 25, 6, -1, 8, 10 };
        List<int> sequence = new List<int>() { 1, 6, -1, 10 };

        Console.WriteLine(IsValidSubsequence(array, sequence));
    }

    public static bool IsValidSubsequence(List<int> array, List<int> sequence)
    {
        // Time Complexity - O(size of array) - O(n)
        // Space Complexity - O(1)
        int aPtr = 0;
        int sPtr = 0;

        while (aPtr < array.Count && sPtr < sequence.Count)
        {
            if (sequence[sPtr] == array[aPtr])
            {
                sPtr++;
            }
            aPtr++;
        }
        return sPtr == sequence.Count;


        // Time Complexity - O(size of array) - O(n)
        // Space Complexity - O(1)

        // int array_it = 0;
        // int array_length = array.Count;

        // int sequence_it = 0;
        // while (array_it < array_length)
        // {
        //     if (sequence[sequence_it] == array[array_it])
        //     {
        //         if (sequence_it + 1 == sequence.Count) return true;
        //         else if (sequence_it + 1 < sequence.Count) sequence_it++;
        //         else return false;
        //     }
        //     array_it++;
        // }
        // return false;
    }
}