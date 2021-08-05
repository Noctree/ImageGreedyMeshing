
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
            this.OriginalImageDisplay = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.GreedyMeshingDisplay = new System.Windows.Forms.PictureBox();
            this.GreedyMeshUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.SelectImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.MeshingTolerance = new System.Windows.Forms.NumericUpDown();
            this.ProgressiveProcessing = new System.Windows.Forms.CheckBox();
            this.UseRandomColor = new System.Windows.Forms.CheckBox();
            this.StopButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MeshingUpdateRateSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImageDisplay)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GreedyMeshingDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeshingTolerance)).BeginInit();
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
            this.GreedyMeshButton.Location = new System.Drawing.Point(84, 12);
            this.GreedyMeshButton.Name = "GreedyMeshButton";
            this.GreedyMeshButton.Size = new System.Drawing.Size(95, 23);
            this.GreedyMeshButton.TabIndex = 1;
            this.GreedyMeshButton.Text = "Greedy Meshing";
            this.GreedyMeshButton.UseVisualStyleBackColor = true;
            this.GreedyMeshButton.Click += new System.EventHandler(this.OnDoGreedyMeshing);
            // 
            // MeshingUpdateRateSelector
            // 
            this.MeshingUpdateRateSelector.Location = new System.Drawing.Point(332, 15);
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
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Meshing Update rate:";
            // 
            // OriginalImageDisplay
            // 
            this.OriginalImageDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OriginalImageDisplay.Location = new System.Drawing.Point(3, 3);
            this.OriginalImageDisplay.Name = "OriginalImageDisplay";
            this.OriginalImageDisplay.Size = new System.Drawing.Size(400, 400);
            this.OriginalImageDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OriginalImageDisplay.TabIndex = 4;
            this.OriginalImageDisplay.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.OriginalImageDisplay);
            this.flowLayoutPanel1.Controls.Add(this.GreedyMeshingDisplay);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 41);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(813, 409);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // GreedyMeshingDisplay
            // 
            this.GreedyMeshingDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GreedyMeshingDisplay.Location = new System.Drawing.Point(409, 3);
            this.GreedyMeshingDisplay.Name = "GreedyMeshingDisplay";
            this.GreedyMeshingDisplay.Size = new System.Drawing.Size(400, 400);
            this.GreedyMeshingDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GreedyMeshingDisplay.TabIndex = 5;
            this.GreedyMeshingDisplay.TabStop = false;
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
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Greedy Meshing Tolerance";
            // 
            // MeshingTolerance
            // 
            this.MeshingTolerance.Location = new System.Drawing.Point(533, 15);
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
            this.ProgressiveProcessing.Location = new System.Drawing.Point(594, 16);
            this.ProgressiveProcessing.Name = "ProgressiveProcessing";
            this.ProgressiveProcessing.Size = new System.Drawing.Size(136, 17);
            this.ProgressiveProcessing.TabIndex = 8;
            this.ProgressiveProcessing.Text = "Progressive Processing";
            this.ProgressiveProcessing.UseVisualStyleBackColor = true;
            // 
            // UseRandomColor
            // 
            this.UseRandomColor.AutoSize = true;
            this.UseRandomColor.Location = new System.Drawing.Point(736, 16);
            this.UseRandomColor.Name = "UseRandomColor";
            this.UseRandomColor.Size = new System.Drawing.Size(93, 17);
            this.UseRandomColor.TabIndex = 9;
            this.UseRandomColor.Text = "Random Color";
            this.UseRandomColor.UseVisualStyleBackColor = true;
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(185, 12);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(47, 23);
            this.StopButton.TabIndex = 10;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.OnStopGreedyMeshing);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 459);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.UseRandomColor);
            this.Controls.Add(this.ProgressiveProcessing);
            this.Controls.Add(this.MeshingTolerance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MeshingUpdateRateSelector);
            this.Controls.Add(this.GreedyMeshButton);
            this.Controls.Add(this.LoadImageButton);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Greedy Meshing";
            ((System.ComponentModel.ISupportInitialize)(this.MeshingUpdateRateSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImageDisplay)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GreedyMeshingDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeshingTolerance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadImageButton;
        private System.Windows.Forms.Button GreedyMeshButton;
        private System.Windows.Forms.NumericUpDown MeshingUpdateRateSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox OriginalImageDisplay;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox GreedyMeshingDisplay;
        private System.Windows.Forms.Timer GreedyMeshUpdateTimer;
        private System.Windows.Forms.OpenFileDialog SelectImageDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown MeshingTolerance;
        private System.Windows.Forms.CheckBox ProgressiveProcessing;
        private System.Windows.Forms.CheckBox UseRandomColor;
        private System.Windows.Forms.Button StopButton;
    }
}

