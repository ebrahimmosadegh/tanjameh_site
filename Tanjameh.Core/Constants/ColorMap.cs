
namespace Tanjameh.Core.Constants;

public static class ColorMap
{
    private static Dictionary<string, string> colors = new()
        {
            { "alpine snow", "rgb(255, 250, 250)" },
            { "black", "rgb(0, 0, 0)" },
            { "bleach wash", "rgb(240, 240, 255)" },
            { "blue", "rgb(0, 0, 255)" },
            { "brown", "rgb(165, 42, 42)" },
            { "brown and white", "rgb(165, 42, 42) and rgb(255, 255, 255)" },
            { "brown check", "rgb(139, 69, 19)" },
            { "charcoal", "rgb(54, 69, 79)" },
            { "charcoal grey", "rgb(64, 64, 64)" },
            { "cream", "rgb(255, 253, 208)" },
            { "cream stripe", "rgb(255, 253, 208) and rgb(240, 240, 240)" },
            { "dgreen", "rgb(0, 100, 0)" },
            { "dusty blue", "rgb(70, 130, 180)" },
            { "ecru", "rgb(194, 178, 128)" },
            { "green", "rgb(0, 128, 0)" },
            { "grey", "rgb(128, 128, 128)" },
            { "grey wash", "rgb(169, 169, 169)" },
            { "indigo", "rgb(75, 0, 130)" },
            { "khaki", "rgb(195, 176, 145)" },
            { "light grey", "rgb(211, 211, 211)" },
            { "mblue", "rgb(0, 0, 139)" },
            { "mink", "rgb(160, 82, 45)" },
            { "moonbeam", "rgb(230, 230, 250)" },
            { "multi", "rgb(255, 165, 0) and rgb(0, 128, 128) and rgb(128, 0, 128)" },
            { "oat", "rgb(245, 222, 179)" },
            { "off white", "rgb(255, 248, 240)" },
            { "over ombre navy", "rgb(0, 0, 128)" },
            { "pink", "rgb(255, 192, 203)" },
            { "puma black", "rgb(10, 10, 10)" },
            { "red", "rgb(255, 0, 0)" },
            { "stone - light", "rgb(220, 220, 210)" },
            { "tan", "rgb(210, 180, 140)" },
            { "white", "rgb(255, 255, 255)" },
            { "yellow", "rgb(255, 255, 0)" },
            { "blush pink", "rgb(255, 182, 193)" },
            { "cinnamon", "rgb(210, 105, 30)" },
            { "cloud grey", "rgb(200, 200, 200)" },
            { "desert sand", "rgb(237, 201, 175)" },
            { "forest green", "rgb(34, 139, 34)" },
            { "frost blue", "rgb(176, 224, 230)" },
            { "goldenrod", "rgb(218, 165, 32)" },
            { "honey", "rgb(240, 180, 80)" },
            { "lavender blush", "rgb(255, 240, 245)" },
            { "maroon", "rgb(128, 0, 0)" },
            { "midnight blue", "rgb(25, 25, 112)" },
            { "nude", "rgb(255, 228, 196)" },
            { "olive", "rgb(128, 128, 0)" },
            { "peach", "rgb(255, 229, 180)" },
            { "plum", "rgb(142, 69, 133)" },
            { "rose gold", "rgb(183, 110, 121)" },
            { "sage green", "rgb(158, 169, 123)" },
            { "sky blue", "rgb(135, 206, 235)" },
            { "terracotta", "rgb(204, 102, 0)" },
            { "wine red", "rgb(114, 47, 55)" },
            { "winter white", "rgb(250, 250, 250)" }
        };

    public static string GetColor(string colorName)
    {
        if (colors.ContainsKey(colorName))
        {
            string colorValue = colors[colorName];

            // Check if the value contains multiple colors (comma-separated or 'and')
            if (colorValue.Contains("and"))
            {
                // Split colors either by comma or 'and'
                string[] colorParts = colorValue.Split("and");

                // Trim whitespace and create a CSS linear-gradient
                for (int i = 0; i < colorParts.Length; i++)
                {
                    colorParts[i] = colorParts[i].Trim();
                }
                return $"linear-gradient(90deg, {string.Join(", ", colorParts)})";
            }

            // Return the single color if no gradient
            return colorValue;
        }

        // If not found, return white
        return "rgb(255, 255, 255)";
    }
}
