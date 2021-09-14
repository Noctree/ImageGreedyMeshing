
namespace Greedy_Meshing
{
    partial class Main
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
            if (disposing && (components != null)) {
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
            this.components = new System.ComponentModel.Container();
            this.LoadImageButton = new System.Windows.Forms.Button();
            this.GreedyMeshButton = new System.Windows.Forms.Button();
            this.MeshingUpdateRateSelector = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.GreedyMeshUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.SelectImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.MeshingTolerance = new System.Windows.Forms.NumericUpDown();
            this.ProgressiveProcessing = new System.Windows.Forms.CheckBox();
            this.StopButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.MeshSizeThresholdInput = new System.Windows.Forms.NumericUpDown();
            this.SaveOutput = new System.Windows.Forms.Button();
            this.UseRandomColor = new System.Windows.Forms.RadioButton();
            this.UseGeneratedColor = new System.Windows.Forms.RadioButton();
            this.UseSampledColor = new System.Windows.Forms.RadioButton();
            this.SaveOutputDialog = new System.Windows.Forms.SaveFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.MeshesPerTick = new System.Windows.Forms.NumericUpDown();
            this.GreedyMeshingDisplay = new System.Windows.Forms.PictureBox();
            this.OriginalImageDisplay = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.UseOldColorTolerance = new System.Windows.Forms.CheckBox();
            this.StatusDisplay = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.UseCustomTexture = new System.Windows.Forms.RadioButton();
            this.CustomSamplerTexPathDisplay = new System.Windows.Forms.Label();
            this.UnloadCustomSamplerTexButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MeshingUpdateRateSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeshingTolerance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeshSizeThresholdInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeshesPerTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreedyMeshingDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImageDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadImageButton
            // 
            this.LoadImageButton.Location = new System.Drawing.Point(3, 12);
            this.LoadImageButton.Name = "LoadImageButton";
            this.LoadImageButton.Size = new System.Drawing.Size(75, 23);
            this.LoadImageButton.TabIndex = 0;
            this.LoadImageButton.Text = "Load Image";
            this.LoadImageButton.UseVisualStyleBackColor = true;
            this.LoadImageButton.Click += new System.EventHandler(this.OnLoadImage);
            // 
            // GreedyMeshButton
            // 
            this.GreedyMeshButton.Location = new System.Drawing.Point(333, 12);
            this.GreedyMeshButton.Name = "GreedyMeshButton";
            this.GreedyMeshButton.Size = new System.Drawing.Size(95, 23);
            this.GreedyMeshButton.TabIndex = 1;
            this.GreedyMeshButton.Text = "Greedy Meshing";
            this.GreedyMeshButton.UseVisualStyleBackColor = true;
            this.GreedyMeshButton.Click += new System.EventHandler(this.OnDoGreedyMeshing);
            // 
            // MeshingUpdateRateSelector
            // 
            this.MeshingUpdateRateSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MeshingUpdateRateSelector.Location = new System.Drawing.Point(916, 15);
            this.MeshingUpdateRateSelector.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.MeshingUpdateRateSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MeshingUpdateRateSelector.Name = "MeshingUpdateRateSelector";
            this.MeshingUpdateRateSelector.Size = new System.Drawing.Size(54, 20);
            this.MeshingUpdateRateSelector.TabIndex = 2;
            this.MeshingUpdateRateSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MeshingUpdateRateSelector.ValueChanged += new System.EventHandler(this.OnUpdateRefreshRate);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(801, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Meshing Update rate:";
            // 
            // GreedyMeshUpdateTimer
            // 
            this.GreedyMeshUpdateTimer.Tick += new System.EventHandler(this.OnTimerTick);
            // 
            // SelectImageDialog
            // 
            this.SelectImageDialog.FileName = "image";
            this.SelectImageDialog.Filter = "Image Files|*.jpg;*.png;*.bmp";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(988, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Greedy Meshing Color Tolerance";
            // 
            // MeshingTolerance
            // 
            this.MeshingTolerance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MeshingTolerance.Location = new System.Drawing.Point(1156, 40);
            this.MeshingTolerance.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.MeshingTolerance.Name = "MeshingTolerance";
            this.MeshingTolerance.Size = new System.Drawing.Size(55, 20);
            this.MeshingTolerance.TabIndex = 7;
            // 
            // ProgressiveProcessing
            // 
            this.ProgressiveProcessing.AutoSize = true;
            this.ProgressiveProcessing.Location = new System.Drawing.Point(12, 54);
            this.ProgressiveProcessing.Name = "ProgressiveProcessing";
            this.ProgressiveProcessing.Size = new System.Drawing.Size(136, 17);
            this.ProgressiveProcessing.TabIndex = 8;
            this.ProgressiveProcessing.Text = "Progressive Processing";
            this.ProgressiveProcessing.UseVisualStyleBackColor = true;
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(434, 12);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(47, 23);
            this.StopButton.TabIndex = 10;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.OnStopGreedyMeshing);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(976, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mesh Size Threshold:";
            // 
            // MeshSizeThresholdInput
            // 
            this.MeshSizeThresholdInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MeshSizeThresholdInput.Location = new System.Drawing.Point(1091, 17);
            this.MeshSizeThresholdInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.MeshSizeThresholdInput.Name = "MeshSizeThresholdInput";
            this.MeshSizeThresholdInput.Size = new System.Drawing.Size(120, 20);
            this.MeshSizeThresholdInput.TabIndex = 12;
            // 
            // SaveOutput
            // 
            this.SaveOutput.Location = new System.Drawing.Point(487, 12);
            this.SaveOutput.Name = "SaveOutput";
            this.SaveOutput.Size = new System.Drawing.Size(75, 23);
            this.SaveOutput.TabIndex = 13;
            this.SaveOutput.Text = "Save Result";
            this.SaveOutput.UseVisualStyleBackColor = true;
            this.SaveOutput.Click += new System.EventHandler(this.OnSaveOutput);
            // 
            // UseRandomColor
            // 
            this.UseRandomColor.AutoSize = true;
            this.UseRandomColor.Location = new System.Drawing.Point(576, 53);
            this.UseRandomColor.Name = "UseRandomColor";
            this.UseRandomColor.Size = new System.Drawing.Size(114, 17);
            this.UseRandomColor.TabIndex = 14;
            this.UseRandomColor.Text = "Use Random Color";
            this.UseRandomColor.UseVisualStyleBackColor = true;
            // 
            // UseGeneratedColor
            // 
            this.UseGeneratedColor.AutoSize = true;
            this.UseGeneratedColor.Location = new System.Drawing.Point(696, 53);
            this.UseGeneratedColor.Name = "UseGeneratedColor";
            this.UseGeneratedColor.Size = new System.Drawing.Size(118, 17);
            this.UseGeneratedColor.TabIndex = 15;
            this.UseGeneratedColor.Text = "UseGeneratedColor";
            this.UseGeneratedColor.UseVisualStyleBackColor = true;
            // 
            // UseSampledColor
            // 
            this.UseSampledColor.AutoSize = true;
            this.UseSampledColor.Checked = true;
            this.UseSampledColor.Location = new System.Drawing.Point(328, 53);
            this.UseSampledColor.Name = "UseSampledColor";
            this.UseSampledColor.Size = new System.Drawing.Size(115, 17);
            this.UseSampledColor.TabIndex = 16;
            this.UseSampledColor.TabStop = true;
            this.UseSampledColor.Text = "Use Sampled Color";
            this.UseSampledColor.UseVisualStyleBackColor = true;
            // 
            // SaveOutputDialog
            // 
            this.SaveOutputDialog.DefaultExt = "png";
            this.SaveOutputDialog.FileName = "GreedyMeshingOutput";
            this.SaveOutputDialog.Filter = "Image files|*.png";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(832, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Meshes Per Tick:";
            // 
            // MeshesPerTick
            // 
            this.MeshesPerTick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MeshesPerTick.Location = new System.Drawing.Point(928, 40);
            this.MeshesPerTick.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.MeshesPerTick.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MeshesPerTick.Name = "MeshesPerTick";
            this.MeshesPerTick.Size = new System.Drawing.Size(54, 20);
            this.MeshesPerTick.TabIndex = 17;
            this.MeshesPerTick.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // GreedyMeshingDisplay
            // 
            this.GreedyMeshingDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GreedyMeshingDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GreedyMeshingDisplay.Location = new System.Drawing.Point(3, -3);
            this.GreedyMeshingDisplay.Name = "GreedyMeshingDisplay";
            this.GreedyMeshingDisplay.Size = new System.Drawing.Size(586, 478);
            this.GreedyMeshingDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GreedyMeshingDisplay.TabIndex = 19;
            this.GreedyMeshingDisplay.TabStop = false;
            // 
            // OriginalImageDisplay
            // 
            this.OriginalImageDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OriginalImageDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OriginalImageDisplay.Location = new System.Drawing.Point(0, -3);
            this.OriginalImageDisplay.Name = "OriginalImageDisplay";
            this.OriginalImageDisplay.Size = new System.Drawing.Size(607, 478);
            this.OriginalImageDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OriginalImageDisplay.TabIndex = 4;
            this.OriginalImageDisplay.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 87);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.OriginalImageDisplay);
            this.splitContainer1.Panel1MinSize = 50;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.GreedyMeshingDisplay);
            this.splitContainer1.Panel2MinSize = 50;
            this.splitContainer1.Size = new System.Drawing.Size(1199, 475);
            this.splitContainer1.SplitterDistance = 606;
            this.splitContainer1.TabIndex = 20;
            // 
            // UseOldColorTolerance
            // 
            this.UseOldColorTolerance.AutoSize = true;
            this.UseOldColorTolerance.Location = new System.Drawing.Point(154, 54);
            this.UseOldColorTolerance.Name = "UseOldColorTolerance";
            this.UseOldColorTolerance.Size = new System.Drawing.Size(168, 17);
            this.UseOldColorTolerance.TabIndex = 21;
            this.UseOldColorTolerance.Text = "Use Alternate Color Tolerance";
            this.UseOldColorTolerance.UseVisualStyleBackColor = true;
            // 
            // StatusDisplay
            // 
            this.StatusDisplay.AutoSize = true;
            this.StatusDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusDisplay.Location = new System.Drawing.Point(568, 12);
            this.StatusDisplay.Name = "StatusDisplay";
            this.StatusDisplay.Size = new System.Drawing.Size(102, 20);
            this.StatusDisplay.TabIndex = 22;
            this.StatusDisplay.Text = "Status: Idle";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Load Custom Sample Texture";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnLoadCustomSampler);
            // 
            // UseCustomTexture
            // 
            this.UseCustomTexture.AutoSize = true;
            this.UseCustomTexture.Location = new System.Drawing.Point(449, 53);
            this.UseCustomTexture.Name = "UseCustomTexture";
            this.UseCustomTexture.Size = new System.Drawing.Size(121, 17);
            this.UseCustomTexture.TabIndex = 24;
            this.UseCustomTexture.TabStop = true;
            this.UseCustomTexture.Text = "Use Custom Texture";
            this.UseCustomTexture.UseVisualStyleBackColor = true;
            // 
            // CustomSamplerTexPathDisplay
            // 
            this.CustomSamplerTexPathDisplay.AutoSize = true;
            this.CustomSamplerTexPathDisplay.Location = new System.Drawing.Point(12, 38);
            this.CustomSamplerTexPathDisplay.Name = "CustomSamplerTexPathDisplay";
            this.CustomSamplerTexPathDisplay.Size = new System.Drawing.Size(245, 13);
            this.CustomSamplerTexPathDisplay.TabIndex = 26;
            this.CustomSamplerTexPathDisplay.Text = "Custom Sampler Texture Path: No Texture Loaded";
            // 
            // UnloadCustomSamplerTexButton
            // 
            this.UnloadCustomSamplerTexButton.Location = new System.Drawing.Point(252, 12);
            this.UnloadCustomSamplerTexButton.Name = "UnloadCustomSamplerTexButton";
            this.UnloadCustomSamplerTexButton.Size = new System.Drawing.Size(75, 23);
            this.UnloadCustomSamplerTexButton.TabIndex = 27;
            this.UnloadCustomSamplerTexButton.Text = "Unload";
            this.UnloadCustomSamplerTexButton.UseVisualStyleBackColor = true;
            this.UnloadCustomSamplerTexButton.Click += new System.EventHandler(this.OnUnloadCustomSampler);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 574);
            this.Controls.Add(this.UnloadCustomSamplerTexButton);
            this.Controls.Add(this.CustomSamplerTexPathDisplay);
            this.Controls.Add(this.UseCustomTexture);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StatusDisplay);
            this.Controls.Add(this.UseOldColorTolerance);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MeshesPerTick);
            this.Controls.Add(this.UseSampledColor);
            this.Controls.Add(this.UseGeneratedColor);
            this.Controls.Add(this.UseRandomColor);
            this.Controls.Add(this.SaveOutput);
            this.Controls.Add(this.MeshSizeThresholdInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.ProgressiveProcessing);
            this.Controls.Add(this.MeshingTolerance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MeshingUpdateRateSelector);
            this.Controls.Add(this.GreedyMeshButton);
            this.Controls.Add(this.LoadImageButton);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Greedy Meshing";
            ((System.ComponentModel.ISupportInitialize)(this.MeshingUpdateRateSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeshingTolerance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeshSizeThresholdInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeshesPerTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreedyMeshingDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImageDisplay)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadImageButton;
        private System.Windows.Forms.Button GreedyMeshButton;
        private System.Windows.Forms.NumericUpDown MeshingUpdateRateSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer GreedyMeshUpdateTimer;
        private System.Windows.Forms.OpenFileDialog SelectImageDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown MeshingTolerance;
        private System.Windows.Forms.CheckBox ProgressiveProcessing;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown MeshSizeThresholdInput;
        private System.Windows.Forms.Button SaveOutput;
        private System.Windows.Forms.RadioButton UseRandomColor;
        private System.Windows.Forms.RadioButton UseGeneratedColor;
        private System.Windows.Forms.RadioButton UseSampledColor;
        private System.Windows.Forms.SaveFileDialog SaveOutputDialog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown MeshesPerTick;
        private System.Windows.Forms.PictureBox GreedyMeshingDisplay;
        private System.Windows.Forms.PictureBox OriginalImageDisplay;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox UseOldColorTolerance;
        private System.Windows.Forms.Label StatusDisplay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton UseCustomTexture;
        private System.Windows.Forms.Label CustomSamplerTexPathDisplay;
        private System.Windows.Forms.Button UnloadCustomSamplerTexButton;
    }
}

