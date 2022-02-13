using XivHero.Models;

namespace XivHero.Controls;

public class RotationSegment : Panel
{
    public Point LastPosition = new();
    public Point StartPosition = new();
    public Point LoopPosition = new();
    public Vector2 ResetThreshold = new(160f, 0f);
    public Vector2 RealPosition = new(0f, 0f);

    public RotationSegment()
    {
        AutoSize = true;
        AutoSizeMode = AutoSizeMode.GrowAndShrink;
        MinimumSize = new(AbilityIcon.DEFAULT_WIDTH, AbilityIcon.DEFAULT_HEIGHT * 3);
        MaximumSize = new(0, AbilityIcon.DEFAULT_HEIGHT * 3);
        Margin = new(0, 0, 0, 0);
        BackColor = Color.Transparent;
    }

    public void Reset(Point offset)
    {
        Location = new(StartPosition.X + offset.X, StartPosition.Y + offset.Y);
        RealPosition = new(Location.X, Location.Y);
    }

    public void Loop()
    {
        float overflow = ResetThreshold.X - RealPosition.X;
        Location = LoopPosition;
        RealPosition = new(Location.X - overflow, Location.Y);
    }

    public void CheckResetThreshold()
    {
        if(RealPosition.X <= ResetThreshold.X)
        {
            Loop();
        }
    }

    public void Move(Vector2 moveVector)
    {
        RealPosition.X += moveVector.X;
        RealPosition.Y += moveVector.Y;

        if ((int)RealPosition.X != LastPosition.X)
        {
            Location = new((int)RealPosition.X, (int)RealPosition.Y);
            CheckResetThreshold();
            LastPosition = Location;
        }
    }
}
