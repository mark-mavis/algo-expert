using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class MonoTonicArray{


    public static void Controller(){
        int[] array = new int[]{-1, -5, -10, -1100, -900, -1101, -1102, -9001};
        Solution(array);
        Console.ReadLine();
    }

    public static bool Solution(int[] array){
        bool up_monotonic = true;
        bool down_monotonic = true;
        
        for(int i = 0; i < array.Length-1; i++){
            if(up_monotonic){
                if(array[i] <= array[i+1]) up_monotonic = true;
                else up_monotonic = false;
            }
            
            if(down_monotonic){
                if(array[i] >= array[i+1]) down_monotonic = true;
                else down_monotonic = false; 
            } 
        }
        return up_monotonic || down_monotonic;
    }
}