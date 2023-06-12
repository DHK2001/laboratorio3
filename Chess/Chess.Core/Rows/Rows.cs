public static class RowDictionary
{
    public static readonly Dictionary<string, int> RowName = new Dictionary<string, int>
    {
        { "1", 0},
        { "2", 1},
        { "3", 2},
        { "4", 3},
        { "5", 4},
        { "6", 5},
        { "7", 6},
        { "8", 7}
    };

    public static int GetRowIndex(string row)
    {
        try
        {
            return RowName[row];
        }
        catch (KeyNotFoundException)
        {
            return -1;
        }
    }
}
