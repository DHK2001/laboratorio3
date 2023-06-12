public static class ColumnDictionary
{
    public static readonly Dictionary<string, int> ColumnName = new Dictionary<string, int>
    {
        { "a", 0},
        { "b", 1},
        { "c", 2},
        { "d", 3},
        { "e", 4},
        { "f", 5},
        { "g", 6},
        { "h", 7}
    };

    public static int GetColumnIndex(string column)
    {
        try
        {
            return ColumnName[column];
        }
        catch (KeyNotFoundException)
        {
            return -1;
        }
    }
}
