namespace LeetCodeSolutions.Solutions.ZigZagConversion;

public class ZigZagConversionSolution
{
    public string Convert(string s, int numRows) {
        if(numRows == 1)
        {
            return s;
        }
        char [,] zig = new char[numRows, s.Length];

        int column = 0;
        int row = 0;
        int direction = 1;
        string sol = "";

        foreach( char c in s)
        {
            zig[row, column] = c;

            if(row == numRows - 1)
            {
                direction = -1;
            }
            else if(row == 0)
            {
                direction = 1;
            }

            row = row + direction;

            if(direction == -1)
            {
                column ++;
            }

        }

        for(int r = 0; r < zig.GetLength(0); r++)
        {
            for(int c = 0; c < zig.GetLength(1); c++)
            {
                if(zig[r, c] != '\0')
                {
                    sol = sol + zig[r, c].ToString();
                }
            }
        }
        
        return sol;
    }
}