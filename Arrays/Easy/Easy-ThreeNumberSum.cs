class ThreeNumberSum{
    public static void Controller(){
        List<int[]> results = Solution(new int[]{12, 43, 1, 2, -6, 5, -8, 6}, 0);
    }
    public static List<int[]> Solution(int[] array, int targetSum){

        List<int[]> combinaations = new List<int[]>();
        Array.Sort(array);
        for(int i = 0; i < array.Length-2; i++){

            int currentBaseValue = array[i];
            int lPtr = i+1;
            int rPtr = array.Length-1;
            while(lPtr < rPtr){
                int currentSum = currentBaseValue + array[lPtr] + array[rPtr];
                if(currentSum == targetSum){
                    combinaations.Add(new int[]{currentBaseValue, array[lPtr], array[rPtr]});
                    lPtr++;
                }
                else if(currentSum < targetSum){
                    lPtr++;
                }
                else{
                    rPtr++;
                }
            }
        }
        return combinaations;

    }


}