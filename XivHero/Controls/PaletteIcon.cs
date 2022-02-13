namespace XivHero.Controls;

public class PaletteIcon : AbilityIcon
{
    public PaletteIcon(string abilityName) : base(abilityName)
    {
        Name = abilityName;
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
}