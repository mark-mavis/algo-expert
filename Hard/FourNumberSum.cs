class FourNumberSum{

    public static void Controller(){

    }

    public static List<int[]> Optimal(int[] array, int targetSum){
        
        List<int[]> combinations = new List<int[]>();
        Array.Sort(array);

        for (int i = 0; i < array.Length - 3; i++)
        {
            int currBaseVal = array[i];
            for(int j = 0; j < array.Length - 2; j++){
                int currSecBaseVal = array[j];
                
                int lPtr = i + 1;
                int rPtr = array.Length - 1;
                while (lPtr < rPtr)
                {
                    int cs = currBaseVal + currSecBaseVal + array[lPtr] + array[rPtr];
                    if (cs == targetSum)
                    {
                        combinations.Add(new int[] { currBaseVal, currSecBaseVal, array[lPtr], array[rPtr] });
                        lPtr++;
                    }
                    else if (cs < targetSum) lPtr++;
                    else rPtr--;
                }
            }
        }
        return new List<int[]>();


    }



}