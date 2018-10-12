using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

using Narivia.Game;

namespace Narivia
{
    class RegionToolTip : ToolTip
    {
        Game.Region Region;
        Faction Faction;
        Resource Resource;
        Religion Religion;
        Biome Biome;

        public RegionToolTip()
        {
            OwnerDraw = true;
            UseFading = false;

            Popup += new PopupEventHandler(this.OnPopup);
            Draw += new DrawToolTipEventHandler(this.OnDraw);
        }
        public void ShowTip(World world, int regID, IWin32Window window, int x, int y)
        {
            Region = world.Region[regID];
            Faction = world.Faction[Region.Faction];
            Resource = world.Resource[Region.Resource];
            Religion = world.Religion[Region.DominantReligion];
            Biome = world.Biome[Region.Biome];

            Show("Faction: " + Faction.Name + "\n" +
                "Troops: " + Faction.UnitsCount + "\n" +
                "Relations: " + NarivianClass.RelationsToString(world.relations[world.Player, Faction.ID]) + "\n" +
                "Regions: " + Faction.RegionCount + "\n" +
                "Resource: " + Resource.Name + "\n" +
                "Biome: " + Biome.Name, window, x, y);
        }

        #region Events
        private void OnPopup(object sender, PopupEventArgs e)
        {
            e.ToolTipSize = new Size(200, 70);
        }
        private void OnDraw(object sender, DrawToolTipEventArgs e)
        {
            Graphics g = e.Graphics;
            Color clrFaction = Faction.Color;
            int titleTextSpacer = 1;
            int borderSize = 1;

            Rectangle r = new Rectangle(1, 1, e.Bounds.Width - 2, e.Bounds.Height - 2);
            Rectangle rTitle = new Rectangle(r.X, r.Y, r.Width, 16);
            Rectangle rBody = new Rectangle(r.X, r.Y + rTitle.Height + borderSize, r.Width, r.Height - rTitle.Height - borderSize);

            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            g.Clear(Color.Black);

            // Header
            DrawingPlus.DrawBilinearHorizontalGradient(g, rTitle, clrFaction, 2);

            // Body
            g.FillRectangle(new LinearGradientBrush(e.Bounds, clrFaction, Color.White, 45f), rBody);

            // Faction Symbol
            g.DrawImage(DrawingPlus.ResizeImage(Faction.Symbol, 39, 39),
                new Point(1, rBody.Y + (rBody.Height - 39)/2));

            // Resource Icon
            if (Region.Resource != 0)
            {
                g.DrawImage((DrawingPlus.ResizeImage(Resource.Icon, 16, 16)),
                    new Point(titleTextSpacer, 1));

                titleTextSpacer += 17;
            }

            // Religion Icon
            if (Region.DominantReligion != 0)
            {
                g.DrawImage((DrawingPlus.ResizeImage(Religion.Icon, 16, 16)),
                    new Point(titleTextSpacer, 1));

                titleTextSpacer += 17;
            }

            // Capital Icon
            if (Region.Type == RegionType.Capital)
            {
                Image imgCapital;

                if (Region.State == RegionState.Free)
                    imgCapital = DrawingPlus.ResizeImage(DrawingPlus.LoadImage(NarivianClass.IconsDirectory + "Capital.PNG"), 16, 16);
                else
                    imgCapital = DrawingPlus.ResizeImage(DrawingPlus.LoadImage(NarivianClass.IconsDirectory + "Capital Other.PNG"), 16, 16);

                g.DrawImage(imgCapital, new Point(e.Bounds.Width - 17, 1));
            }

            // Title
            g.DrawString(Region.Name,  new Font("Microsoft Sans Serif", 10, FontStyle.Bold),
                Brushes.Black, new Point(rTitle.X + titleTextSpacer, rTitle.Y));

            // Message
            g.DrawString( e.ToolTipText, new Font("Microsoft Sans Serif", 8),
                Brushes.Black, new PointF(40, rBody.Y + 2));

            // Border
            //g.DrawRectangle(new Pen(Color.Black, borderSize * 2), new Rectangle(
                //e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height - 1));
            //g.DrawLine(new Pen(Color.Black, borderSize), new Point(0, 17), new Point(e.Bounds.Width, 17));
        }
        #endregion
    }
}