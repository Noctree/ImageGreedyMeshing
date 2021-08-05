using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using System.Collections;

namespace Greedy_Meshing
{
    public class GreedyMesher : IDisposable
    {
        private Bitmap bitmap;
        private List<Rectangle> meshAreas = new List<Rectangle>();
        private int tolerance = 0;
        private bool disposedValue;

        public GreedyMesher(Bitmap image, int tolerance = 0)
        {
            bitmap = new Bitmap(image);
            this.tolerance = tolerance;
        }

        public List<Rectangle> GetMeshes()
        {
            return new List<Rectangle>(meshAreas);
        }

        public Bitmap TestPixelGetter()
        {
            var pixels = GetBitmapPixels();
            Bitmap bitmap = new Bitmap(this.bitmap);
            for (int y = 0; y < bitmap.Height; y++) {
                for (int x = 0; x < bitmap.Width; x++) {
                    bitmap.SetPixel(x, y, pixels[x + y * bitmap.Width]);
                }
            }
            return bitmap;
        }

        public List<Rectangle> DoGreedyMeshing()
        {
            var enumerator = GetNextMesh();
            while (enumerator.MoveNext()) {

            }
            Debug.WriteLine($"Meshes: {meshAreas.Count}");
            return GetMeshes();
        }

        public IEnumerator<Rectangle> GetNextMesh()
        {
            meshAreas.Clear();
            var pixels = GetBitmapPixels();
            Queue<Point> pointsX = new Queue<Point>();
            Queue<Point> pointsY = new Queue<Point>();
            BitArray visited = new BitArray(pixels.Length);
            pointsX.Enqueue(new Point(0, 0));


            while (pointsX.Count > 0 || pointsY.Count > 0) {
                Point start;
                if (pointsX.Count > 0)
                    start = pointsX.Dequeue();
                else
                    start = pointsY.Dequeue();
                if (visited[CoordsToIndex(start.X, start.Y)])
                    continue;
                int x = start.X;
                int y = start.Y;
                Color color = pixels[CoordsToIndex(x, y)];
                visited[CoordsToIndex(x, y)] = true;

                int index = CoordsToIndex(x + 1, y);
                while (x + 1 < bitmap.Width && ColorInRange(color, pixels[index], tolerance) && !visited[index]) {
                    ++x;
                    visited[index - 1] = true;
                    index = CoordsToIndex(x + 1, y);
                }

                bool scan = true;
                while (scan && y + 1 < bitmap.Height) {
                    for (int i = start.X; i <= x; i++) {
                        index = CoordsToIndex(i, y + 1);
                        visited[index - bitmap.Width] = true;
                        if (!ColorInRange(color, pixels[index], tolerance) || visited[index]) {
                            scan = false;
                            break;
                        }
                    }
                    if (x + 1 < bitmap.Width && !visited[CoordsToIndex(x + 1, y)])
                        pointsX.Enqueue(new Point(x + 1, y));
                    if (scan)
                        ++y;
                }
                if (y + 1 < bitmap.Height && !visited[CoordsToIndex(start.X, y + 1)]) {
                    pointsY.Enqueue(new Point(start.X, y + 1));
                }

                var mesh = CreateRectangle(start.X, start.Y, x, y);
                meshAreas.Add(mesh);
                yield return mesh;
            }
        }

        private int CoordsToIndex(int x, int y)
        {
            return x + y * bitmap.Width;
        }

        private bool ColorInRange(Color source, Color target, int tolerance)
        {
            return  (target.R <= source.R + tolerance && target.R >= source.R - tolerance) &&
                    (target.G <= source.G + tolerance && target.G >= source.G - tolerance) &&
                    (target.R <= source.B + tolerance && target.B >= source.B - tolerance);
        }

        private Rectangle CreateRectangle(int MinX, int MinY, int MaxX, int MaxY)
        {
            return new Rectangle(MinX, MinY, MaxX - MinX, MaxY - MinY);
        }

        private Color[] GetBitmapPixels()
        {
            BitmapData data = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            byte[] rawPixels = new byte[data.Stride * data.Height];
            Marshal.Copy(data.Scan0, rawPixels, 0, rawPixels.Length);
            bitmap.UnlockBits(data);

            Color[] pixels = new Color[bitmap.Width * bitmap.Height];
            for (int i = 0; i < rawPixels.Length; i += 4) {
                pixels[i / 4] = Color.FromArgb(rawPixels[i + 3], rawPixels[i + 2], rawPixels[i + 1], rawPixels[i + 0]);
            }
            return pixels;
        }

        private void DumpColorsToDrive()
        {
            var pixels = GetBitmapPixels();
            using (StreamWriter writer = new StreamWriter(Environment.CurrentDirectory + "/ColorDump.txt")) {
                for (int y = 0; y < bitmap.Height; y++) {
                    for (int x = 0; x < bitmap.Width; x++) {
                        writer.Write(pixels[CoordsToIndex(x, y)].ToString() + " ");
                    }
                    writer.WriteLine();
                }
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue) {
                if (disposing) {
                    // TODO: dispose managed state (managed objects)
                    meshAreas.Clear();
                }
                bitmap.Dispose();

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        ~GreedyMesher()
        {
             // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
             Dispose(disposing: false);
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
