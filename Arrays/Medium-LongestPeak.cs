

using System.Security;

class LongestPeak{


    public static void Controller(){
        int[] array = new int[]{1, 2, 3, 3, 4, 0, 10, 6, 5, -1, -3, 2, 3};
        Solution1(array);

    }

    public static int Solution1(int[] arr){
        int peakSize = 0;
        for(int i = 0; i < arr.Length; i++){
            int size = PeakCount(arr, i);
            if(size > peakSize) peakSize = size;
        }
        return peakSize;
    }

    public static int Solution2(int[] array){
        int maxPeak = 0;
        for(int i = 0; i < array.Length; i++){
            int leftIt = i;
            int rightIt = i;
            bool leftAccent = true;
            bool rightAccent = true;
            int count = 0;
            while((leftIt > 0 && rightIt < array.Length-1) && (leftAccent && rightAccent)){
                if(array[leftIt-1] >= array[leftIt]){
                    leftAccent = false;
                }
                if(array[rightIt] <= array[rightIt+1]){
                    rightAccent = false;
                }
                if(leftAccent && rightAccent) count += 2;
                if(maxPeak < count) maxPeak = count;
                leftIt--;
                rightIt++;
            }
        }
        return maxPeak;

    }

    public static int PeakCount(int[] arr, int currIdx){
        int leftIt = currIdx;
        int rightIt = currIdx;
        bool leftAccent = false;
        bool rightAccent = false;
        int count = 1;

        while(leftIt > 0 && (arr[leftIt-1] < arr[leftIt])){
            count++;
            leftIt--;
            leftAccent = true;
        }   
        while(rightIt < arr.Length-1 && (arr[rightIt] > arr[rightIt+1])){
            count++;
            rightIt++;
            rightAccent = true;
        }
        return (leftAccent && rightAccent) ? count : 0;
    }
}