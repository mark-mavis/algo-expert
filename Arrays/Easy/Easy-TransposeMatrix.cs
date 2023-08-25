
class TransposeMatrix{

    public static void Controller(){
        int[,] array = new int[4, 2]{
            {4, 2},
            {5, 4},
            {2, 9},
            {7, 6}
        };
        Solution(array);

    }

    public static int[,] Solution(int[,] matrix){

        int x_dim = matrix.GetLength(0);
        int y_dim = matrix.GetLength(1);

        int[,] transpose = new int[y_dim, x_dim];

        for(int i = 0; i < x_dim; i++){
            for(int j = 0; j < y_dim; j++){
                transpose[j,i] = matrix[i, j];
            }
        }

        return transpose;
    }

}