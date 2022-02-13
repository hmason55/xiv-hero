using Newtonsoft.Json;
using XivHero.Controls;
using XivHero.Models;

namespace XivHero.Forms;

public partial class RotationEditor : Form
{
    RotationIcon currentIcon = null;
    AbilityIcon previewIcon = null;
    Point lastPosition = new(-40, 0);

    Rect rotationContainerBounds = new();
    public static Point Grid = new(AbilityIcon.DEFAULT_WIDTH / 5, AbilityIcon.DEFAULT_HEIGHT);

    public Dictionary<string, PaletteIcon> AbilitiesByName = new();

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

    public RotationEditor()
    {
        InitializeComponent();

        JobComboBox.Items.AddRange(Ability.AbilityNamesByJob.Keys.ToArray());
        LoadJobAbilities(JobComboBox.SelectedItem?.ToString());
        JobComboBox.SelectedIndexChanged += SelectJob;

        RotationContainer.MouseMove += panel_MouseMove;
        RotationContainer.MouseUp += PlaceIcon;

        rotationContainerBounds = new(0, RotationContainer.Width, 0, RotationContainer.Height);

        previewIcon = new("Fast_Blade");
        previewIcon.Enabled = false;

        Update();
    }

    private void PaletteIcon_Click(object sender, EventArgs e)
    {
        PaletteIcon paletteIcon = sender as PaletteIcon;
        SpawnRotationIcon(lastPosition.X + AbilityIcon.DEFAULT_WIDTH, lastPosition.Y, paletteIcon.Name);
    }
    
    private void SpawnRotationIcon(int x, int y, string name)
    {
        RotationIcon rotationIcon = new(new(name));
        RotationContainer.Controls.Add(rotationIcon);

        rotationIcon.Location = new(x, y);
        rotationIcon.MouseDown += PickupIcon;
        rotationIcon.BringToFront();

        lastPosition = rotationIcon.Location;
    }

    public static Point SnapToGrid(Point point, int snapX, int snapY, Rect bounds)
    {
        return bounds.ClampPosition(new(point.X / snapX * snapX, point.Y / snapY * snapY));
    }

    private void panel_MouseMove(object sender, MouseEventArgs e)
    {
        if (currentIcon != null)
        {
            RotationContainer.Cursor = Cursors.NoMove2D;
            previewIcon.Location = SnapToGrid(new(e.Location.X - currentIcon.Width / 2, e.Location.Y), Grid.X, Grid.Y, rotationContainerBounds);
            CursorTimeStatus.Text = $"({currentIcon.Name}, {previewIcon.Location.X / 16f:0.0}s)";
            CursorTimeStatus.Update();

            if(!CheckEdgeScroll(e.Location))
            {
                RotationContainer.Update();
            }
        }
        else
        {
            RotationContainer.Cursor = Cursors.Default;
        }
    }

    private void PlaceIcon(object sender, MouseEventArgs e)
    {
        if (currentIcon != null)
        {
            currentIcon.Location = SnapToGrid(new(e.Location.X - currentIcon.Width / 2, e.Location.Y), Grid.X, Grid.Y, rotationContainerBounds);
            currentIcon.BringToFront();
            currentIcon.Visible = true;
            currentIcon.Enabled = true;
            lastPosition = currentIcon.Location;
            currentIcon = null;

            EnableAll();

            previewIcon.Parent = this;
            previewIcon.Visible = false;
            previewIcon.Location = new();
            RotationContainer.Update(); 
        }
    }


    private void PickupIcon(object sender, MouseEventArgs e)
    {
        RotationIcon icon = sender as RotationIcon;

        if (currentIcon == null)
        {
            if (e.Button == MouseButtons.Left)
            {
                icon.Visible = false;
                icon.Enabled = false;
                currentIcon = icon;

                previewIcon.BackgroundImage = icon.BackgroundImage;
                previewIcon.Parent = RotationContainer;
                previewIcon.Location = SnapToGrid(new(e.Location.X - currentIcon.Width / 2, e.Location.Y), Grid.X, Grid.Y, rotationContainerBounds);
                previewIcon.BringToFront();
                previewIcon.Visible = true;
                previewIcon.Update();

                DisableAll();

                RotationContainer.Cursor = Cursors.NoMove2D;
            }
            else if (e.Button == MouseButtons.Right)
            {
                RotationContainer.Controls.Remove(icon);
            }

            RotationContainer.Update();
        }
    }

    private void EnableAll(RotationIcon except = null)
    {
        foreach(RotationIcon icon in RotationContainer.Controls.OfType<RotationIcon>())
        {
            if (icon == except)
            {
                continue;
            }

            // If it's out of bounds.
            if (!rotationContainerBounds.Contains(icon.Location))
            {
                RotationContainer.Controls.Remove(icon);
                continue;
            }

            icon.Enabled = true;
        }
    }

    private void DisableAll(RotationIcon except = null)
    {
        foreach (RotationIcon icon in RotationContainer.Controls.OfType<RotationIcon>())
        {
            if(icon == except)
            {
                continue;
            }

            icon.Enabled = false;
        }
    }

    private void SelectJob(object sender, EventArgs e)
    {
        if(JobComboBox.SelectedItem == null)
        {
            return;
        }

        LoadJobAbilities(JobComboBox.SelectedItem.ToString());
    }

    private void LoadJobAbilities(string job)
    {
        if(job == null)
        {
            return;
        }

        if (!Ability.AbilityNamesByJob.ContainsKey(job))
        {
            return;
        }

        AbilityContainer?.Controls.Clear();

        foreach (string ability in Ability.AbilityNamesByJob[job])
        {
            PaletteIcon paletteIcon = new(ability);
            paletteIcon.Parent = AbilityContainer;
            paletteIcon.MouseClick += PaletteIcon_Click;

            if (!AbilitiesByName.ContainsKey(paletteIcon.Name))
            {
                AbilitiesByName.Add(paletteIcon.Name, paletteIcon);
            }
        }
    }

    private bool CheckEdgeScroll(Point mousePosition)
    {
        int edgeSize = AbilityIcon.DEFAULT_WIDTH * 2;
        int leftEdge = RotationScrollContainer.HorizontalScroll.Value;
        int rightEdge = leftEdge + RotationScrollContainer.Width;
        int deltaX = 0;

        if (mousePosition.X > rightEdge - edgeSize)
        {
            deltaX = (edgeSize - (rightEdge - mousePosition.X));
        }
        else if(mousePosition.X < leftEdge + edgeSize)
        {
            deltaX = -(leftEdge - mousePosition.X + edgeSize);
        }

        if(deltaX != 0)
        {
            EdgeScroll(new(deltaX, 0));
        }

        return deltaX != 0;
    }

    private void EdgeScroll(Point scrollVector)
    {
        HScrollProperties hScroll = RotationScrollContainer.HorizontalScroll;
        int lookAheadX = hScroll.Value + scrollVector.X;
        if (lookAheadX >= hScroll.Minimum && lookAheadX <= hScroll.Maximum)
        {
            hScroll.Value = lookAheadX;
        }
    }

    private string ExportRotation()
    {
        IEnumerable<Ability> rotationIcons = RotationContainer.Controls.OfType<RotationIcon>().Select(r => r.Export()).Reverse();
        return JsonConvert.SerializeObject(rotationIcons);
    }

    public void ImportRotation(string json)
    {
        RotationContainer.Controls?.Clear();

        List<Ability> abilities = JsonConvert.DeserializeObject<List<Ability>>(json);
        foreach(Ability ability in abilities)
        {
            SpawnRotationIcon(ability.X, ability.Y, ability.Name);
        }
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog = new();
        saveFileDialog.DefaultExt = ".json";
        saveFileDialog.FileName = "Rotation";
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            File.WriteAllText(saveFileDialog.FileName, ExportRotation());
        }
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
}
