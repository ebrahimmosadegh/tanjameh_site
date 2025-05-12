
using System.Text.RegularExpressions;

namespace Tanjameh.Core.Helper;

public static class FileExtentions
{
    public static string? FilePathToUrl(this string? filePath, string? fileName = null)
    {
        if (filePath == null) return null;

        if (fileName != null)
        {
            filePath = Path.Combine(filePath, fileName);
        }

        string result = filePath.Replace("wwwroot", "")
                                .Replace("\\", "/")
                                .Replace("//", "/")
                                .TrimStart('/');

        return "/" + result;
    }

    public static string? ToSlug(this string? name)
    {
        return name == null ? null : Regex.Replace(name.ToLower().Replace('/', '-'), @"\s+", "-");
    }
}