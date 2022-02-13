
using Newtonsoft.Json;
using System.Diagnostics;
using XivHero.Controls;
using XivHero.Models;

namespace XivHero.Forms;

public partial class RotationSimulator : Form
{
    public static bool IsRunning = false;
    public bool IsPinned = false;
    public int FramesPerSecond = 240;
    public Point HitPosition = new(160, 0);
    Stopwatch Stopwatch = new();

    public List<RotationSegment> RotationSegments = new() { new(), new(), new()};

    /// <summary>
    /// Enable double buffering for the form.
    /// </summary>
    protected override CreateParams CreateParams
    {
        get
        {
            CreateParams handleParam = base.CreateParams;
            handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
            return handleParam;
        }
    }

    public RotationSimulator()
    {
        CheckForIllegalCrossThreadCalls = false;
        InitializeComponent();
        foreach (RotationSegment segment in RotationSegments)
        {
            segment.Parent = RotationBackground;
            RotationBackground.Controls.Add(segment);
        }
    }

    private void StartButton_Click(object sender, EventArgs e)
    {
        if (!IsRunning)
        {
            IsRunning = true;
            StartButton.Text = "Stop";
            Stopwatch.Start();
            Task.Run(() => MoveRotation());
        }
        else
        {
            IsRunning = false;
            StartButton.Text = "Start";
            Stopwatch.Stop();
        }
    }

    private void InitializeRotation()
    {
        if (RotationSegments.Count == 0)
        {
            return;
        }

        Point loopPosition = new(HitPosition.X + RotationSegments.First().Width, HitPosition.Y);
        for (int i = 0; i < RotationSegments.Count; i++)
        {
            RotationSegment segment = RotationSegments[i];
            segment.StartPosition = new(HitPosition.X + RotationSegments.First().Width * i, 0);
            segment.ResetThreshold = new(HitPosition.X - RotationSegments.First().Width * (RotationSegments.Count-1), 0f);
            segment.LoopPosition = loopPosition;
        }

        Reset();
    }

    private void MoveRotation()
    {
        float pixelsPerSecond = AbilityIcon.DEFAULT_WIDTH / (float)RecastField.Value;
        long lastTimeStamp = Stopwatch.ElapsedMilliseconds;

        while (IsRunning)
        {
            Thread.Sleep(1000 / FramesPerSecond);
            long deltaMs = Stopwatch.ElapsedMilliseconds - lastTimeStamp;
            lastTimeStamp = Stopwatch.ElapsedMilliseconds;

            float deltaX = pixelsPerSecond * (deltaMs / 1000f);
            ElapsedLabel.Text = $"Elapsed: {((lastTimeStamp / 1000f) - (StartDelayTrackBar.Value / 2f)):0.00}s";

            foreach(RotationSegment segment in RotationSegments)
            {
                segment.Move(new(-deltaX, 0));
            }
        }
    }

    private void SpawnRotationIcon(int x, int y, string name)
    {
        foreach (RotationSegment segment in RotationSegments)
        {
            RotationIcon rotationIcon = new(new(name));
            segment.Controls.Add(rotationIcon);

            rotationIcon.Parent = segment;
            rotationIcon.Location = new(x, y);
            rotationIcon.BringToFront();
        }
    }

    public void ImportRotation(string json)
    {
        foreach(RotationSegment segment in RotationSegments)
        {
            segment.Controls?.Clear();
        }

        List<Ability> abilities = JsonConvert.DeserializeObject<List<Ability>>(json);
        foreach (Ability ability in abilities)
        {
            SpawnRotationIcon(ability.X, ability.Y, ability.Name);
        }

        InitializeRotation();
    }

    private void LoadButton_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new();
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            string json = File.ReadAllText(openFileDialog.FileName);
            try
            {
                ImportRotation(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    private void StartDelayTrack_Scroll(object sender, EventArgs e)
    {
        TrackBar trackBar = sender as TrackBar;
        float startDelay = trackBar.Value / 2f;
        StartDelayLabel.Text = $"Start ({startDelay:0.0}s)";

        Reset();
    }

    private void ResetButton_Click(object sender, EventArgs e)
    {
        Reset();
    }

    public void Reset()
    {
        IsRunning = false;
        Point offset = new(8 * StartDelayTrackBar.Value, 0);
        foreach(RotationSegment segment in RotationSegments)
        {
            segment.Reset(offset);
        }
    }

    private void EditorButton_Click(object sender, EventArgs e)
    {
        RotationEditor editor = new();
        editor.ShowDialog();
    }

    private void PinButton_Click(object sender, EventArgs e)
    {
        Button button = sender as Button;

        IsPinned = !IsPinned;
        button.Text = IsPinned ? "Unpin" : "Pin";

        TopMost = IsPinned;
    }
}
