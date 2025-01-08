namespace LeetCodeSolutions.Solutions.ExcelSheetColumnNumber;

public class ExcelSheetColumnNumberSolution
{
    public int TitleToNumber(string columnTitle) {
        int result = 0;

        for(int i = 0; i < columnTitle.Length; i++)
        {
            char l = columnTitle[i];

            int x = (int)(l - 'A' + 1);

            result = result * 26 + x;
        }

        return result;
    }
}