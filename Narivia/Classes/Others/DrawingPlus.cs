using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;

namespace Narivia
{
    public class DrawingPlus
    {
        public static Color DarkenColor(Color clr, int value)
        {
            byte R = (byte)(Math.Max(0, Math.Min(clr.R - value, 255)));
            byte G = (byte)(Math.Max(0, Math.Min(clr.G - value, 255)));
            byte B = (byte)(Math.Max(0, Math.Min(clr.B - value, 255)));

            return Color.FromArgb(R, G, B);
        }
        public static Image LoadImage(string path, bool missingImageHandler = true)
        {
            if (File.Exists(path))
                return Image.FromFile(path);
            else
            {
                Log.WriteLine("Image '" + path + "' not found!");

                if (missingImageHandler)
                    return Properties.Resources.MissingTexture;
                else
                    return null;
            }
        }
        public static Image ResizeImage(Image imgOriginal, int width, int height)
        {
            Bitmap imgResized = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(imgResized))
            {
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;

                g.DrawImage(imgOriginal, new Rectangle(0, 0, width, height));
            }

            return imgResized;
        }
        public static void DrawBilinearHorizontalGradient(Graphics g, Rectangle area, Color color, float strength, bool flip = false)
        {
            Color color2 = DrawingPlus.DarkenColor(color, (int)(area.Height * strength));
            Point pt1 = new Point(area.X, area.Y);
            Point pt2 = new Point(area.X, area.Y + area.Height / 2);
            LinearGradientBrush grd = new LinearGradientBrush(pt2, pt1, color, color2);

            if (flip == true)
                grd = new LinearGradientBrush(pt1, pt2, color, color2);

            grd.WrapMode = WrapMode.TileFlipXY;
            g.FillRectangle(grd, area);
        }
        public static void DrawPanel(Graphics g, Rectangle area, Color color, int borderSize)
        {
            // Border
            g.FillRectangle(new SolidBrush(DrawingPlus.DarkenColor(color, 64)), area);

            // Base
            area = new Rectangle(area.X + 1, area.Y + 1, area.Width - 2, area.Height - 2);
            g.FillRectangle(new SolidBrush(color), area);

            // Top
            g.FillRectangle(new SolidBrush(DrawingPlus.DarkenColor(color, -24)),
                new Rectangle(area.X, area.Y, area.Width, borderSize));

            // Left
            g.FillRectangle(new SolidBrush(DrawingPlus.DarkenColor(color, -24)),
                new Rectangle(area.X, area.Y, borderSize, area.Height));

            // Bottom
            g.FillRectangle(new SolidBrush(DrawingPlus.DarkenColor(color, 24)),
                new Rectangle(area.X, area.Y + area.Height - borderSize, area.Width, borderSize));

            // Right
            g.FillRectangle(new SolidBrush(DrawingPlus.DarkenColor(color, 24)),
                new Rectangle(area.X + area.Width - borderSize, area.Y + borderSize, borderSize, area.Height - borderSize));
        }
        public static void DrawBorder(Graphics g, Rectangle area, Color color, int size)
        {
            if (size % 2 != 0)
                size -= 1;
            if (size < 2)
                size = 2;

            size -= 2;

            int b2size = 1;
            if (size == 0)
            {
                b2size = 0;
                size += 2;
            }

            g.FillRectangles(new SolidBrush(DrawingPlus.DarkenColor(color, 64)), new Rectangle[]
            {
                new Rectangle(area.X, area.Y, area.Width, b2size ),
                new Rectangle(area.X, area.Y + b2size  + size, area.Width, b2size ),

                new Rectangle(area.X, area.Y, b2size , area.Height),
                new Rectangle(area.X + b2size  + size, area.Y, b2size , area.Height),
                
                new Rectangle(area.X, area.Y + area.Height - b2size , area.Width, b2size ),
                new Rectangle(area.X, area.Y + area.Height - b2size * 2 - size, area.Width, b2size ),
                
                new Rectangle(area.X + area.Width - b2size , area.Y, b2size , area.Height),
                new Rectangle(area.X + area.Width - b2size * 2 - size, area.Y, b2size , area.Height)
            });

            g.FillRectangles(new SolidBrush(DrawingPlus.DarkenColor(color, -24)), new Rectangle[]
            {
                new Rectangle(area.X + b2size, area.Y + b2size, area.Width - b2size * 2, size/2),
                new Rectangle(area.X + b2size, area.Y + b2size, size/2, area.Height - b2size * 2),
                new Rectangle(area.X + b2size, area.Y + area.Height - b2size - size, area.Width - b2size * 2, size/2),
                new Rectangle(area.X + area.Width - b2size - size, area.Y + b2size, size/2, area.Height - b2size * 2 - size),
            });

            g.FillRectangles(new SolidBrush(DrawingPlus.DarkenColor(color, 24)), new Rectangle[]
            {
                new Rectangle(area.X + b2size +size/2, area.Y + b2size+size/2, area.Width - b2size * 2 - size/2, size/2),
                new Rectangle(area.X + b2size +size/2, area.Y + b2size+size/2, size/2, area.Height - b2size * 2 - size/2),
                new Rectangle(area.X + b2size +size/2, area.Y + area.Height - b2size - size/2, area.Width - b2size * 2 - size/2, size/2),
                new Rectangle(area.X + area.Width - b2size - size/2, area.Y + 1+size/2, size/2, area.Height - b2size * 2 - size/2)
            });
        }
        public static Bitmap OverlayImages(Bitmap original, Bitmap overlay)
        {
            Bitmap bmp = new Bitmap(original);
            Graphics g = Graphics.FromImage(bmp);

            g.DrawImage(overlay, new Rectangle(0, 0, bmp.Width, bmp.Height));
            return bmp;
        }
    }
}
