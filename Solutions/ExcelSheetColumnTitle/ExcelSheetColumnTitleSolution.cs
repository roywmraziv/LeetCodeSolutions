namespace LeetCodeSolutions.Solutions.ExcelSheetColumnTitle;

public class ExcelSheetColumnTitleSolution
{
    public string ConvertToTitle(int columnNumber) {
        
        Dictionary<int, string> map = new Dictionary<int, string>();
        string s = "";
        for (int i = 1; i <= 26; i++)
        {
            map[i] = ((char)(i + 'A' - 1)).ToString();
        }

        while(columnNumber > 0)
        {
            if(columnNumber <= 26){
                s = map[columnNumber] + s;
                columnNumber = (columnNumber - 1) / 26;
            }
            else
            {
                if(columnNumber % 26 == 0){
                    s = map[26] + s;
                }
                else
                {
                    s = map[columnNumber % 26] + s;
                }
                columnNumber = (columnNumber - 1) / 26;
            }
        }

        return s;


    }
}