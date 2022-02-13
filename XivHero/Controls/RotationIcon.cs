using XivHero.Models;

namespace XivHero.Controls;

public class RotationIcon : AbilityIcon
{
    public RotationIcon(PaletteIcon paletteIcon) : base(paletteIcon.Name)
    {
        Margin = new(0, 0, 0, 0);
        MouseEnter += OnMouseEnter;
        MouseLeave += OnMouseLeave;
    }

    private void OnMouseEnter(object sender, EventArgs e)
    {
        Cursor = Cursors.Hand;
    }

    private void OnMouseLeave(object sender, EventArgs e)
    {
        Cursor = Cursors.Default;
    }

    public Ability Export()
    {
        return new()
        {
            X = Location.X,
            Y = Location.Y,
            Name = Name
        };
    }
}
