using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Narivia
{
    class CustomToolTip : ToolTip
    {
        public Font Font { get; set; }
        public int Offset { get; set; }

        public CustomToolTip()
        {
            Font = new Font("Palatino Linotype", 9.75f, FontStyle.Bold);
            Offset = 6;

            BackColor = Color.DarkRed;
            ForeColor = Color.Gold;

            OwnerDraw = true;
            UseFading = false;

            InitialDelay = 0;

            Popup += new PopupEventHandler(this.OnPopup);
            Draw += new DrawToolTipEventHandler(this.OnDraw);
        }

        private void OnPopup(object sender, PopupEventArgs e)
        {
            Graphics g = Graphics.FromImage(new Bitmap(1, 1));
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            
            SizeF size = g.MeasureString(
                ((ToolTip)sender).GetToolTip(e.AssociatedControl),
                new Font(Font.FontFamily, 9.75f, Font.Style));

            e.ToolTipSize = new Size((int)size.Width + Offset, (int)size.Height + Offset);
        }

        private void OnDraw(object sender, DrawToolTipEventArgs e)
        {
            Graphics g = e.Graphics;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            // Body Color
            g.FillRectangle(new SolidBrush(BackColor), e.Bounds);

            // Message
            g.DrawString(e.ToolTipText, new Font(Font.FontFamily, 9.75f, Font.Style),
                new SolidBrush(ForeColor), e.Bounds, new StringFormat(){
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center});

            // 1px Border
            g.DrawRectangle(new Pen(new SolidBrush(ForeColor),1), new Rectangle(
                e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height - 1));
        }
    }
}
