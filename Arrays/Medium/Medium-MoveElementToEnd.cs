

using System.Diagnostics.Contracts;

class MoveElementToEnd{

    public static void Controller(){
        List<int> list = new List<int>(){2, 1, 2, 2, 2, 3, 4, 2};
        ImprovedSolution(list, 2);
        Console.ReadLine();
    }

    public static List<int> Solution(List<int> array, int toMove){
        int lPtr = 0;
        int rPtr = array.Count-1;

        while(lPtr < rPtr){
            if(array[rPtr] == toMove){
                rPtr--;
                continue;
            }
            if(array[lPtr] != toMove){
                lPtr++;
                continue;
            }
            if(array[lPtr] == toMove && array[rPtr] != toMove){
                int temp = array[rPtr];
                array[rPtr] = array[lPtr];
                array[lPtr] = temp;
            }

        }
        return array;
    }

    public static List<int> ImprovedSolution(List<int> array, int toMove){

        int lPtr = 0;
        int rPtr = array.Count-1;

        while(lPtr < rPtr){

            while(lPtr < rPtr && array[rPtr] == toMove){
                rPtr--;
            }

            if(array[lPtr] == toMove){
                (array[lPtr], array[rPtr]) = (array[rPtr], array[lPtr]);
            }
            lPtr++;
        }
        return array;
    }


}