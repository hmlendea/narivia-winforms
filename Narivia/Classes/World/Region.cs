using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Xml;

namespace Narivia.Game
{
    public enum RegionType
    {
        Province,
        Capital,
    }
    public enum RegionState
    {
        Free,
        Occupied
    }
    public class Region
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public Color Color { get; set; }
        public int OriginalFaction { get; set; }
        public int Faction { get; set; }
        public bool IsProtected { get; set; }
        public int Resource { get; set; }
        public int Biome { get; set; }
        public int[] Building { get; set; }
        public int[] BuildingCulture { get; set; }
        public int BuildingsCount { get; set; }
        public int[] Neighbour { get; set; }
        public int NeighbourCount { get; set; }
        public int[] Religion { get; set; }
        public int DominantReligion
        {
            get
            {
                int dr = 0;

                for (int rel = 1; rel < Religion.Length; rel++)
                    if (Religion[rel] > Religion[dr])
                        dr = rel;

                return dr;
            }
        }
        public RegionType Type { get; set; }
        public RegionState State
        {
            get
            {
                if (Faction == OriginalFaction)
                    return RegionState.Free;
                else
                    return RegionState.Occupied;
            }
        }

        public void Load(string map, int id)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(NarivianClass.MapsDirectory + map + "\\Regions.XML");
            XmlNode xmlNode = xml.SelectNodes("/Regions/Region")[id];

            Name = xmlNode["Name"].InnerText;
            ID = id;
            Color = ColorTranslator.FromHtml(xmlNode["Color"].InnerText);
            Resource = Convert.ToInt32(xmlNode["Resource"].InnerText);
            Biome = Convert.ToInt32(xmlNode["Biome"].InnerText);
            Faction = Convert.ToInt32(xmlNode["Faction"].InnerText);
        }
        public void AddReligion(int religion, int influence)
        {
            Religion[religion] += influence;
        }
    }
    public class RegionCollection
    {
        public Region this[string name]
        {
            get
            {
                for (int i = 0; i < Count; i++)
                    if (Region[i].Name == name)
                        return Region[i];

                return null;
            }
        }
        public Region this[int index] { get { return Region[index]; } }

        public Region[] Region
        {
            get { return region; }
            set { region = value; }
        } private Region[] region;
        public int Count { get { return Region.Length; } }

        public RegionCollection()
        {
            Region = new Region[0];
        }

        public void Add(Region region)
        {
            Array.Resize(ref this.region, this.region.Length + 1);
            Region[Region.Length - 1] = region;
        }
        public void Remove(string regionName)
        {
            int i = 0;
            while (i < Region.Length)
            {
                if (Region[i].Name == regionName)
                {
                    for (int j = i + 1; j < this.region.Length; j++)
                        Region[j - 1] = Region[j];

                    Array.Resize(ref this.region, Region.Length - 1);
                }

                i += 1;
            }
        }
        public void Clear()
        {
            Region = new Region[0];
        }
    }
}
