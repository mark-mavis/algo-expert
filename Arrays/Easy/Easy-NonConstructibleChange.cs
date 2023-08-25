

class NonConstructableChange{

    public static void Controller(){
        int[] change = new int[]{5, 7, 1, 1, 2, 3, 22};
        Solution(change);
    }

    public static int Solution(int[] coins){
        if (coins.Length == 0) return 1;
        Array.Sort(coins);
        int changeSum = 0;
        for(int i = 0; i < coins.Length; i++){
            if(coins[i] > changeSum + 1){
                return changeSum + 1;
            }
            changeSum += coins[i];
        }
        return changeSum - 1;
    }

}