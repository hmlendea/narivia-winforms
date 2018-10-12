using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

using Narivia.Game;

namespace Narivia
{
    class BuildingsPanel : Panel
    {
        World World { get; set; }
        CustomToolTip Tip = new CustomToolTip();

        public BuildingsPanel()
        {
        }
        public void SetWorld(ref World world)
        {
            World = world;
        }
        public void GetRegion(int reg)
        {
            this.Clear();

            if (World.Region[reg].Type == RegionType.Capital)
                Add("Capital Pallace", 0, reg);
            else
                Add("City Pallace", 0, reg);

            for (int i = 1; i < World.Region[reg].BuildingsCount; i++)
                Add(World.Region[reg].Building[i], reg);

            if (World.Region[reg].Faction == World.Player)
                Colorized = true;
            else
                Colorized = false;
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
        public bool colorized;

        public void Add(int buildingID, int regionID)
        {
            BuildingIcon icn = new BuildingIcon(World, buildingID, regionID);

            Tip.SetToolTip(icn, World.Building[buildingID].Name);

            base.Controls.Add(icn);
            Arrange();
        }
        public void Add(string buildingName, int buildingID, int regionID)
        {
            BuildingIcon icn = new BuildingIcon(World, buildingID, regionID);

            Tip.SetToolTip(icn, buildingName);

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
            int x = 0;


            foreach (Control building in base.Controls)
            {
                if (building.Location.X != x)
                    building.Location = new Point(x, 0);

                x += building.Width;
            }
        }
    }
}
