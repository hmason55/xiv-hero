namespace XivHero.Forms;

partial class RotationSimulator
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RotationSimulator));
            this.StartButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.RotationContainer = new System.Windows.Forms.Panel();
            this.RotationBackground = new System.Windows.Forms.Panel();
            this.TargetLine = new System.Windows.Forms.PictureBox();
            this.RecastField = new System.Windows.Forms.NumericUpDown();
            this.RecastContainer = new System.Windows.Forms.Panel();
            this.RecastLabel = new System.Windows.Forms.Label();
            this.ButtonContainer = new System.Windows.Forms.Panel();
            this.ElapsedLabel = new System.Windows.Forms.Label();
            this.PinButton = new System.Windows.Forms.Button();
            this.EditorButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.StartDelayContainer = new System.Windows.Forms.Panel();
            this.StartDelayLabel = new System.Windows.Forms.Label();
            this.StartDelayTrackBar = new System.Windows.Forms.TrackBar();
            this.RotationContainer.SuspendLayout();
            this.RotationBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TargetLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecastField)).BeginInit();
            this.RecastContainer.SuspendLayout();
            this.ButtonContainer.SuspendLayout();
            this.StartDelayContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartDelayTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(101, 3);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(3, 3);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(92, 23);
            this.LoadButton.TabIndex = 5;
            this.LoadButton.Text = "Load Rotation";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // RotationContainer
            // 
            this.RotationContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RotationContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.RotationContainer.Controls.Add(this.RotationBackground);
            this.RotationContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RotationContainer.Location = new System.Drawing.Point(0, 35);
            this.RotationContainer.Margin = new System.Windows.Forms.Padding(0);
            this.RotationContainer.Name = "RotationContainer";
            this.RotationContainer.Size = new System.Drawing.Size(930, 130);
            this.RotationContainer.TabIndex = 6;
            // 
            // RotationBackground
            // 
            this.RotationBackground.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RotationBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.RotationBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RotationBackground.BackgroundImage")));
            this.RotationBackground.Controls.Add(this.TargetLine);
            this.RotationBackground.Location = new System.Drawing.Point(0, 5);
            this.RotationBackground.Margin = new System.Windows.Forms.Padding(0);
            this.RotationBackground.MaximumSize = new System.Drawing.Size(0, 120);
            this.RotationBackground.MinimumSize = new System.Drawing.Size(200, 120);
            this.RotationBackground.Name = "RotationBackground";
            this.RotationBackground.Size = new System.Drawing.Size(4096, 120);
            this.RotationBackground.TabIndex = 1;
            // 
            // TargetLine
            // 
            this.TargetLine.BackColor = System.Drawing.Color.Transparent;
            this.TargetLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TargetLine.ErrorImage = ((System.Drawing.Image)(resources.GetObject("TargetLine.ErrorImage")));
            this.TargetLine.Image = ((System.Drawing.Image)(resources.GetObject("TargetLine.Image")));
            this.TargetLine.Location = new System.Drawing.Point(160, 0);
            this.TargetLine.Margin = new System.Windows.Forms.Padding(0);
            this.TargetLine.Name = "TargetLine";
            this.TargetLine.Size = new System.Drawing.Size(1, 120);
            this.TargetLine.TabIndex = 0;
            this.TargetLine.TabStop = false;
            // 
            // RecastField
            // 
            this.RecastField.DecimalPlaces = 2;
            this.RecastField.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.RecastField.Location = new System.Drawing.Point(47, 0);
            this.RecastField.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            131072});
            this.RecastField.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.RecastField.Name = "RecastField";
            this.RecastField.Size = new System.Drawing.Size(51, 23);
            this.RecastField.TabIndex = 7;
            this.RecastField.Value = new decimal(new int[] {
            250,
            0,
            0,
            131072});
            // 
            // RecastContainer
            // 
            this.RecastContainer.Controls.Add(this.RecastLabel);
            this.RecastContainer.Controls.Add(this.RecastField);
            this.RecastContainer.Location = new System.Drawing.Point(263, 3);
            this.RecastContainer.Name = "RecastContainer";
            this.RecastContainer.Size = new System.Drawing.Size(100, 23);
            this.RecastContainer.TabIndex = 8;
            // 
            // RecastLabel
            // 
            this.RecastLabel.AutoSize = true;
            this.RecastLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.RecastLabel.Location = new System.Drawing.Point(3, 2);
            this.RecastLabel.Name = "RecastLabel";
            this.RecastLabel.Size = new System.Drawing.Size(41, 15);
            this.RecastLabel.TabIndex = 8;
            this.RecastLabel.Text = "Recast";
            // 
            // ButtonContainer
            // 
            this.ButtonContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ButtonContainer.Controls.Add(this.ElapsedLabel);
            this.ButtonContainer.Controls.Add(this.PinButton);
            this.ButtonContainer.Controls.Add(this.EditorButton);
            this.ButtonContainer.Controls.Add(this.ResetButton);
            this.ButtonContainer.Controls.Add(this.StartDelayContainer);
            this.ButtonContainer.Controls.Add(this.RecastContainer);
            this.ButtonContainer.Controls.Add(this.LoadButton);
            this.ButtonContainer.Controls.Add(this.StartButton);
            this.ButtonContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonContainer.Location = new System.Drawing.Point(0, 0);
            this.ButtonContainer.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonContainer.Name = "ButtonContainer";
            this.ButtonContainer.Size = new System.Drawing.Size(930, 35);
            this.ButtonContainer.TabIndex = 9;
            // 
            // ElapsedLabel
            // 
            this.ElapsedLabel.AutoSize = true;
            this.ElapsedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.ElapsedLabel.Location = new System.Drawing.Point(709, 7);
            this.ElapsedLabel.Name = "ElapsedLabel";
            this.ElapsedLabel.Size = new System.Drawing.Size(73, 15);
            this.ElapsedLabel.TabIndex = 15;
            this.ElapsedLabel.Text = "Elapsed: 0.5s";
            // 
            // PinButton
            // 
            this.PinButton.Location = new System.Drawing.Point(571, 3);
            this.PinButton.Name = "PinButton";
            this.PinButton.Size = new System.Drawing.Size(48, 23);
            this.PinButton.TabIndex = 14;
            this.PinButton.Text = "Pin";
            this.PinButton.UseVisualStyleBackColor = true;
            this.PinButton.Click += new System.EventHandler(this.PinButton_Click);
            // 
            // EditorButton
            // 
            this.EditorButton.Location = new System.Drawing.Point(625, 3);
            this.EditorButton.Name = "EditorButton";
            this.EditorButton.Size = new System.Drawing.Size(78, 23);
            this.EditorButton.TabIndex = 13;
            this.EditorButton.Text = "Open Editor";
            this.EditorButton.UseVisualStyleBackColor = true;
            this.EditorButton.Click += new System.EventHandler(this.EditorButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(182, 3);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 12;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // StartDelayContainer
            // 
            this.StartDelayContainer.Controls.Add(this.StartDelayLabel);
            this.StartDelayContainer.Controls.Add(this.StartDelayTrackBar);
            this.StartDelayContainer.Location = new System.Drawing.Point(366, 3);
            this.StartDelayContainer.Margin = new System.Windows.Forms.Padding(0);
            this.StartDelayContainer.Name = "StartDelayContainer";
            this.StartDelayContainer.Size = new System.Drawing.Size(202, 33);
            this.StartDelayContainer.TabIndex = 11;
            // 
            // StartDelayLabel
            // 
            this.StartDelayLabel.AutoSize = true;
            this.StartDelayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.StartDelayLabel.Location = new System.Drawing.Point(0, 4);
            this.StartDelayLabel.Margin = new System.Windows.Forms.Padding(0);
            this.StartDelayLabel.Name = "StartDelayLabel";
            this.StartDelayLabel.Size = new System.Drawing.Size(62, 15);
            this.StartDelayLabel.TabIndex = 10;
            this.StartDelayLabel.Text = "Start (0.0s)";
            // 
            // StartDelayTrackBar
            // 
            this.StartDelayTrackBar.LargeChange = 2;
            this.StartDelayTrackBar.Location = new System.Drawing.Point(62, 0);
            this.StartDelayTrackBar.Margin = new System.Windows.Forms.Padding(0);
            this.StartDelayTrackBar.Name = "StartDelayTrackBar";
            this.StartDelayTrackBar.Size = new System.Drawing.Size(142, 45);
            this.StartDelayTrackBar.TabIndex = 9;
            this.StartDelayTrackBar.Scroll += new System.EventHandler(this.StartDelayTrack_Scroll);
            // 
            // RotationSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(930, 165);
            this.Controls.Add(this.ButtonContainer);
            this.Controls.Add(this.RotationContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 204);
            this.Name = "RotationSimulator";
            this.Text = "Rotation Simulator";
            this.RotationContainer.ResumeLayout(false);
            this.RotationBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TargetLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecastField)).EndInit();
            this.RecastContainer.ResumeLayout(false);
            this.RecastContainer.PerformLayout();
            this.ButtonContainer.ResumeLayout(false);
            this.ButtonContainer.PerformLayout();
            this.StartDelayContainer.ResumeLayout(false);
            this.StartDelayContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartDelayTrackBar)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion
    private Button StartButton;
    private Button LoadButton;
    private Panel RotationContainer;
    private NumericUpDown RecastField;
    private Panel RecastContainer;
    private Label RecastLabel;
    private Panel RotationBackground;
    private PictureBox TargetLine;
    private Panel ButtonContainer;
    private Panel StartDelayContainer;
    private Label StartDelayLabel;
    private TrackBar StartDelayTrackBar;
    private Button ResetButton;
    private Button EditorButton;
    private Button PinButton;
    private Label ElapsedLabel;
}
