using System.Reflection;
using System.Resources;

namespace XivHero.Controls;

public class AbilityIcon : PictureBox
{
    public readonly ResourceManager AssetManager = new ("XivHero.Resources.AbilityIcons", Assembly.GetExecutingAssembly());
    public const int DEFAULT_WIDTH = 40;
    public const int DEFAULT_HEIGHT = 40;

    public AbilityIcon(string iconName)
    {
        Width = DEFAULT_WIDTH;
        Height = DEFAULT_HEIGHT;
        Image = AssetManager.GetObject("border") as Image;
        BackgroundImage = AssetManager.GetObject(iconName) as Image;
        Name = iconName;
    }
}
