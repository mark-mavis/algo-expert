
using System.Runtime.InteropServices;

class SmallestDifference{
    public static void Controller(){
        ImprovedSolution(new int[]{-1, 5, 10, 20, 28, 3}, new int[]{26, 134, 135, 15, 17});
    }

    public static int[] BruteForce(int[] arrayOne, int[] arrayTwo){
        int smallestDelta = Int32.MaxValue;
        int arrayOneIdx = -1;
        int arrayTwoIdx = -1;

        for(int i1 = 0; i1 < arrayOne.Length; i1++){
            for(int i2 = 0; i2 < arrayTwo.Length; i2++){
                int delta = Math.Abs(arrayOne[i1] - arrayTwo[i2]);
                if(delta < smallestDelta) {
                    smallestDelta = delta;
                    arrayOneIdx = i1;
                    arrayTwoIdx = i2;
                }
            }
        }
        return new int[]{arrayOne[arrayOneIdx], arrayTwo[arrayTwoIdx]};
    }

    public static int[] ImprovedSolution(int[] arrayOne, int[] arrayTwo){
        Array.Sort(arrayOne);
        Array.Sort(arrayTwo);

        int idxOne = 0;
        int idxTwo = 0;

        int smallestDelta = Int32.MaxValue;
        int currentDelta = Int32.MaxValue;

        int[] currentLeaders = new int[0];

        while((idxOne < arrayOne.Length) && (idxTwo < arrayTwo.Length)){
            int firstNum = arrayOne[idxOne];
            int secondNum = arrayTwo[idxTwo];

            if(firstNum < secondNum) {
                currentDelta = Math.Abs(firstNum - secondNum);
                idxOne++;
            }
            else if(secondNum < firstNum){
                currentDelta = Math.Abs(firstNum-secondNum);
                idxTwo++;
            }
            else{
                return new int[]{firstNum, secondNum};
            }
            
            if(smallestDelta > currentDelta){
                smallestDelta = currentDelta;
                currentLeaders = new int[]{firstNum, secondNum};
            }
        }
        return currentLeaders;
    }
}