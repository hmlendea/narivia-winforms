using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Narivia.Customs
{
    public partial class BuildingsPaneffffl : Panel
    {
        frmGame frmGame = frmMain.frmGame;
        ToolTip Tip = new ToolTip();

        public new int Region
        {
            get { return reg; }
            set
            {
                reg = value;

                this.Clear();
                this.Tag = reg;

                if (frmGame.region[reg].IsCapital)
                    this.Add("Capital Pallace");
                else
                    this.Add("City Pallace");

                for (int i = 1; i < frmGame.region[reg].BuildingsCount; i++)
                    this.Add(frmGame.building[frmGame.region[reg].Building[i]].Name);

                if (frmGame.region[reg].Faction == frmGame.player)
                    Colorized = true;
                else
                    Colorized = false;
            }
        }
        public bool Colorized
        {
            get { return colorized; }
            set
            {
                colorized = value;

                foreach (Control ctrl in base.Controls)
                    ctrl.Enabled = value;
            }
        }
        public static int reg;
        public static bool colorized;

        public void Add(string bldName)
        {
            BuildingIcon icn = new BuildingIcon(bldName, reg);

            Tip.SetToolTip(icn, bldName);

            base.Controls.Add(icn);
            Arrange();
        }
        public void Remove(Control building)
        {
            base.Controls.Remove(building);
            building.Dispose();
            Arrange();
        }
        public void Clear()
        {
            foreach (Control building in base.Controls)
            {
                base.Controls.Remove(building);
                building.Dispose();
            }

            base.Controls.Clear();

            Tip.RemoveAll();
        }
        private void Arrange()
        {
            int i = 0;


            foreach (Control building in base.Controls)
            {
                building.Location = new Point(building.Width * i, 0);
                i += 1;
            }
        }   
    }
}
