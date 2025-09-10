namespace DataStructureAndAlgorithms.DataStructures.Matrizes;

public class manipular_matriz
{
    int [,] array2d = new int [3,4];
    /*
    {0,0,0,0},
    {0,0,0,0},
    {0,0,0,0};
    */
    int[,] _array2d = new int[,]
    {
        { 1, 2, 3 },
        { 4, 5, 6 },
        { 7, 8, 9 }
    };

    private int[][] matrix = new int[4][];
    // jagged array, matriz com colunas de tamanho flexivel
    
    private List<List<int>> arr = new List<List<int>>();
    // lista de listas, tamanho de linhas e de colunas flexivel
    
    
    // percorrer array
    public void Loop()
    {
        for (int i = 0; i < _array2d.GetLength(0); i++)
        {
            for (int j = 0; j < _array2d.GetLength(1); j++)
            {
                Console.WriteLine(_array2d[i,j]);
            }
        }
        // acessa os elementos da matriz como se fosse por um plano ortogonal, complexidade temporal O(N*M)

        // percorrer jagged array ao inves de multidimensional array [,]
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                Console.WriteLine(matrix[i][j]);
            }
        }
    }
}

