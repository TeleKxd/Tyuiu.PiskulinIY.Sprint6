using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PiskulinIY.Sprint6.Task3.V27.Lib
{
    public class DataService : ISprint6Task3V27
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            int[] col4 = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                col4[i] = matrix[i, 3];
            }
            Array.Sort(col4);

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                matrix[i, 3] = col4[i];
            }
            return matrix;
        }
    }
}
