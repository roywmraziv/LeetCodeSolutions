namespace LeetCodeSolutions.Solutions.PascalsTriangle;

public class PascalsTriangleSolution
{
    public IList<IList<int>> Generate(int numRows) {
        if(numRows == 1){return [[1]];}
        if(numRows == 2){return [[1], [1,1]];}

        int[][] arr = new int[numRows][];
        arr[0] = [1];
        arr[1] = [1,1];

        for(int i = 2; i < numRows; i++)
        {
            int[] row = new int[i+1];

            for(int j = 0; j < i+1; j++)
            {
                if(j == 0 || j == row.Length - 1)
                {
                    row[j] = 1;
                }
                else
                {
                    row[j] = arr[i-1][j-1] + arr[i-1][j];
                }
            }
            arr[i] = row;
        }
        return arr;
    }
}