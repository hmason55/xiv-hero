namespace XivHero.Forms;

partial class RotationEditor
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RotationEditor));
            this.AbilityContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.RotationScrollContainer = new System.Windows.Forms.Panel();
            this.RotationContainer = new System.Windows.Forms.Panel();
            this.JobComboBox = new System.Windows.Forms.ComboBox();
            this.JobContainer = new System.Windows.Forms.Panel();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CursorTimeStatus = new System.Windows.Forms.Label();
            this.SaveRotationDialog = new System.Windows.Forms.SaveFileDialog();
            this.LoadRotationDialog = new System.Windows.Forms.OpenFileDialog();
            this.RotationScrollContainer.SuspendLayout();
            this.JobContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // AbilityContainer
            // 
            this.AbilityContainer.AutoScroll = true;
            this.AbilityContainer.AutoSize = true;
            this.AbilityContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AbilityContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.AbilityContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AbilityContainer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AbilityContainer.Location = new System.Drawing.Point(0, 30);
            this.AbilityContainer.Margin = new System.Windows.Forms.Padding(0);
            this.AbilityContainer.MaximumSize = new System.Drawing.Size(0, 92);
            this.AbilityContainer.MinimumSize = new System.Drawing.Size(0, 92);
            this.AbilityContainer.Name = "AbilityContainer";
            this.AbilityContainer.Size = new System.Drawing.Size(792, 92);
            this.AbilityContainer.TabIndex = 6;
            // 
            // RotationScrollContainer
            // 
            this.RotationScrollContainer.AutoScroll = true;
            this.RotationScrollContainer.AutoSize = true;
            this.RotationScrollContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RotationScrollContainer.Controls.Add(this.RotationContainer);
            this.RotationScrollContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RotationScrollContainer.Location = new System.Drawing.Point(0, 123);
            this.RotationScrollContainer.Margin = new System.Windows.Forms.Padding(0);
            this.RotationScrollContainer.MaximumSize = new System.Drawing.Size(0, 138);
            this.RotationScrollContainer.MinimumSize = new System.Drawing.Size(0, 138);
            this.RotationScrollContainer.Name = "RotationScrollContainer";
            this.RotationScrollContainer.Size = new System.Drawing.Size(792, 138);
            this.RotationScrollContainer.TabIndex = 0;
            // 
            // RotationContainer
            // 
            this.RotationContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.RotationContainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RotationContainer.BackgroundImage")));
            this.RotationContainer.Location = new System.Drawing.Point(0, 0);
            this.RotationContainer.Margin = new System.Windows.Forms.Padding(0);
            this.RotationContainer.Name = "RotationContainer";
            this.RotationContainer.Size = new System.Drawing.Size(12000, 120);
            this.RotationContainer.TabIndex = 0;
            // 
            // JobComboBox
            // 
            this.JobComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.JobComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JobComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.JobComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.JobComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.JobComboBox.FormattingEnabled = true;
            this.JobComboBox.Location = new System.Drawing.Point(202, 2);
            this.JobComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.JobComboBox.Name = "JobComboBox";
            this.JobComboBox.Size = new System.Drawing.Size(121, 23);
            this.JobComboBox.TabIndex = 5;
            // 
            // JobContainer
            // 
            this.JobContainer.AutoSize = true;
            this.JobContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.JobContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.JobContainer.Controls.Add(this.LoadButton);
            this.JobContainer.Controls.Add(this.SaveButton);
            this.JobContainer.Controls.Add(this.CursorTimeStatus);
            this.JobContainer.Controls.Add(this.JobComboBox);
            this.JobContainer.Controls.Add(this.AbilityContainer);
            this.JobContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.JobContainer.Location = new System.Drawing.Point(0, 1);
            this.JobContainer.Margin = new System.Windows.Forms.Padding(0);
            this.JobContainer.MaximumSize = new System.Drawing.Size(0, 122);
            this.JobContainer.MinimumSize = new System.Drawing.Size(0, 122);
            this.JobContainer.Name = "JobContainer";
            this.JobContainer.Size = new System.Drawing.Size(792, 122);
            this.JobContainer.TabIndex = 7;
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(102, 2);
            this.LoadButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(90, 23);
            this.LoadButton.TabIndex = 10;
            this.LoadButton.Text = "Load Rotation";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(4, 2);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(90, 23);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Save Rotation";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CursorTimeStatus
            // 
            this.CursorTimeStatus.AutoSize = true;
            this.CursorTimeStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.CursorTimeStatus.Location = new System.Drawing.Point(326, 10);
            this.CursorTimeStatus.Name = "CursorTimeStatus";
            this.CursorTimeStatus.Size = new System.Drawing.Size(52, 15);
            this.CursorTimeStatus.TabIndex = 7;
            this.CursorTimeStatus.Text = "( - , 0.0s)";
            // 
            // RotationEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(792, 261);
            this.Controls.Add(this.JobContainer);
            this.Controls.Add(this.RotationScrollContainer);
            this.MinimumSize = new System.Drawing.Size(502, 300);
            this.Name = "RotationEditor";
            this.Text = "Rotation Editor";
            this.RotationScrollContainer.ResumeLayout(false);
            this.JobContainer.ResumeLayout(false);
            this.JobContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Panel RotationScrollContainer;
    private Panel RotationContainer;
    private FlowLayoutPanel AbilityContainer;
    private ComboBox JobComboBox;
    private Panel JobContainer;
    private Label CursorTimeStatus;
    private Button SaveButton;
    private Button LoadButton;
    private SaveFileDialog SaveRotationDialog;
    private OpenFileDialog LoadRotationDialog;
}
