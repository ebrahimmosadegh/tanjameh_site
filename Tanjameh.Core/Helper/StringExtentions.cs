namespace Tanjameh.Core.Helper;

public static class StringExtentions
{
    public static string ToSafeString(this object? str, bool spaceAtStart = false)
    {
        if (str == null)
            return string.Empty;
        
        if (spaceAtStart)
            return " " + str.ToString();
            
        return str.ToString() ?? string.Empty;
    }
}