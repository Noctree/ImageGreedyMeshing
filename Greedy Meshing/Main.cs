using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Greedy_Meshing
{
    public partial class Main : Form
    {
        private Color color = Color.Black;
        private Bitmap origImage;
        private Bitmap meshedImage;
        private bool IsMeshing = false;
        private GreedyMesher mesher;
        private IEnumerator<Rectangle> mesherEnumerator;
        public Main()
        {
            InitializeComponent();
            GreedyMeshUpdateTimer.Interval = (int)MeshingUpdateRateSelector.Value;
        }

        private void OnLoadImage(object sender, EventArgs e)
        {
            if (SelectImageDialog.ShowDialog() == DialogResult.OK) {
                origImage = (Bitmap)Image.FromFile(SelectImageDialog.FileName);
                OriginalImageDisplay.Image = origImage;
            }
        }

        private void OnDoGreedyMeshing(object sender, EventArgs e)
        {
            if (origImage is null) {
                MessageBox.Show("Load an image first!");
                return;
            }

            mesher?.Dispose();
            mesher = new GreedyMesher(origImage, (int)MeshingTolerance.Value);
            GreedyMeshingDisplay.Image = mesher.TestPixelGetter();
            meshedImage = (Bitmap)origImage.Clone();
            if (ProgressiveProcessing.Checked) {
                mesherEnumerator = mesher.GetNextMesh();
                mesherEnumerator.MoveNext();
                IsMeshing = true;
                GreedyMeshUpdateTimer.Start();
            } else {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                var meshes = mesher.DoGreedyMeshing();
                stopwatch.Stop();
                Debug.WriteLine($"Greedy Meshing Time: {stopwatch.Elapsed}");
                foreach (Rectangle mesh in meshes) {
                    DrawMesh(meshedImage, mesh, UseRandomColor.Checked);
                }
                GreedyMeshingDisplay.Image = meshedImage;
            }
        }

        private void OnUpdateRefreshRate(object sender, EventArgs e)
        {
            GreedyMeshUpdateTimer.Interval = (int)MeshingUpdateRateSelector.Value;
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            if (IsMeshing) {
                GreedyMeshingDisplay.Image = DrawMesh(meshedImage, mesherEnumerator.Current, UseRandomColor.Checked);
                if (!mesherEnumerator.MoveNext()) {
                    IsMeshing = false;
                    GreedyMeshUpdateTimer.Stop();
                    meshedImage.Save(Environment.CurrentDirectory + "/meshedImage.png");
                }
            }
        }

        private Bitmap DrawMesh(Bitmap image, Rectangle mesh, bool RandomColor = false)
        {
            //Debug.WriteLine(mesh.ToString());
            var gfx = Graphics.FromImage(image);
            mesh.Width += 1;
            mesh.Height += 1;
            if (RandomColor)
                gfx.FillRectangle(CreatePenWithGeneratedColor().Brush, mesh);
            else {
                Point point = mesh.Location;
                gfx.FillRectangle(new Pen(origImage.GetPixel(point.X, point.Y)).Brush, mesh);
            }
            gfx.Flush(System.Drawing.Drawing2D.FlushIntention.Sync);
            return image;
        }

        private Pen CreatePenWithGeneratedColor()
        {
            int r, g, b;
            b = color.G >= 240 ? (color.B + 10 < 256? color.B + 10 : 0) : color.B;
            g = color.R >= 240 ? (color.G + 10 < 256? color.G + 10 : 0)  : color.G;
            r = color.R < 250 ? color.R + 10 : 0;
            color = Color.FromArgb(255, r, g, b);
            return new Pen(color);
        }

        private Pen CreatePenWithRandomColor()
        {
            var rng = new Random();
            var color = Color.FromArgb(255, rng.Next(0, 256), rng.Next(0, 256), rng.Next(0, 256));
            return new Pen(color);
        }

        private void OnStopGreedyMeshing(object sender, EventArgs e)
        {
            IsMeshing = false;
            GreedyMeshUpdateTimer.Stop();
        }
    }
}
