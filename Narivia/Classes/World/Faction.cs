using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Xml;

namespace Narivia.Game
{
    public class Faction
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string Description { get; set; }
        public Color Color { get; set; }
        public Image Symbol { get; set; }
        public int Ability { get; set; }
        public int Culture { get; set; }
        public int Religion { get; set; }
        public bool Alive
        {
            get
            {
                if (RegionCount > 0 && ID > 0)
                    return true;
                else
                    return false;
            }
        }
        public int[] Region { get; set; }
        public int[] Units { get; set; }
        public int RegionCount { get; set; }
        public int UnitsCount
        {
            get
            {
                int uc = 0;

                for (int unt = 0; unt < Units.Length; unt++)
                    uc += Units[unt];

                return uc;
            }
        }
        public double Money { get; set; }
        public int Income { get; set; }
        public int Outcome { get; set; }

        public void Load(string map, string assetsPack, int id)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(NarivianClass.MapsDirectory + map + "\\Factions.XML");
            XmlNode xmlNode = xml.SelectNodes("/Factions/Faction")[id];

            Name = xmlNode["Name"].InnerText;
            ID = id;
            Description = xmlNode["Description"].InnerText;
            Color = ColorTranslator.FromHtml(xmlNode["Color"].InnerText);
            Symbol = DrawingPlus.LoadImage(NarivianClass.AssetsDirectory + assetsPack + "\\Symbols\\" + Name + ".PNG");
            Ability = Convert.ToInt32(xmlNode["Ability"].InnerText);
            Culture = Convert.ToInt32(xmlNode["Culture"].InnerText);
            Religion = Convert.ToInt32(xmlNode["Religion"].InnerText);
            Units = new int[16];
            Region = new int[256];
            RegionCount = 0;
        }
    }
    public class FactionCollection
    {
        public Faction this[string name]
        {
            get
            {
                for (int i = 0; i < Count; i++)
                    if (Faction[i].Name == name)
                        return Faction[i];

                return null;
            }
        }
        public Faction this[int index] { get { return Faction[index]; } }

        public Faction[] Faction
        {
            get { return faction; }
            set { faction = value; }
        } private Faction[] faction;
        public int Count { get { return Faction.Length; } }

        public FactionCollection()
        {
            Faction = new Faction[0];
        }

        public void Add(Faction faction)
        {
            Array.Resize(ref this.faction, this.faction.Length + 1);
            Faction[Faction.Length - 1] = faction;
        }
        public void Remove(string factionName)
        {
            int i = 0;
            while (i < Faction.Length)
            {
                if (Faction[i].Name == factionName)
                {
                    for (int j = i + 1; j < this.faction.Length; j++)
                        Faction[j - 1] = Faction[j];

                    Array.Resize(ref this.faction, Faction.Length - 1);
                }

                i += 1;
            }
        }
        public void Clear()
        {
            Faction = new Faction[0];
        }
    }
}
