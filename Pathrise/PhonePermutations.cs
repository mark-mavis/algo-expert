using System;



class PhonePermuations
{


    public static void Controller()
    {
        //Dictionary<int, char[]> phoneNumbers = new Dictionary<int, char[]> { { 1, new char[] { 'A', 'B', 'C' } }, { 2, new char[] { 'D', 'E', 'F' } } };

        //Permutations(phoneNumbers);

        char[] a = new char[] { 'A', 'B', 'C' };
        char[] b = new char[] { 'D', 'E', 'F' };
        Permutations(a, b);
    }

    public static void Permutations(char[] a, char[] b)
    {
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < b.Length; j++)
            {
                Console.WriteLine($"{a[i]}, {b[j]}");
            }
        }
    }
    public static int[] Permutations(Dictionary<int, char[]> phoneNumbers)
    {
        Dictionary<int, char[]>.KeyCollection keysCollection = phoneNumbers.Keys;

        return new int[0];
    }


}