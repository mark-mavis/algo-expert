
class FirstDuplicateValue{


    public static void Controller(){
        int[] array = new int[]{2, 1, 5, 2, 3, 3, 4};
        Solution1(array);
    }

    public static int Solution1(int[] array){
        Dictionary<int, int> numberCounts = new Dictionary<int, int>(array.Length);
        foreach(int i in array){
            if(!numberCounts.ContainsKey(i)){
                numberCounts.Add(i, 0);
                continue;
            }
            return i;
        }
        return -1;
    }
}