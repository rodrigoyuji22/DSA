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
    }
}

