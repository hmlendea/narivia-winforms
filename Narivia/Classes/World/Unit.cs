using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Xml;

namespace Narivia.Game
{
    public class Unit
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string Description { get; set; }
        public Image Icon { get; set; }
        public int Price { get; set; }
        public int Maintenance { get; set; }
        public int Attack { get; set; }
        public int Health { get; set; }

        public void Load(string map, string assetsPack, int id)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(NarivianClass.MapsDirectory + map + "\\Units.XML");
            XmlNode xmlNode = xml.SelectNodes("/Units/Unit")[id];

            Name = xmlNode["Name"].InnerText;
            ID = id;
            Description = xmlNode["Description"].InnerText;
            Price = Convert.ToInt32(xmlNode["Price"].InnerText);
            Maintenance = Convert.ToInt32(xmlNode["Maintenance"].InnerText);
            Icon = DrawingPlus.LoadImage(NarivianClass.AssetsDirectory + assetsPack + "\\Units\\" + Name + ".PNG");
            Attack = Convert.ToInt32(xmlNode["Attack"].InnerText);
            Health = Convert.ToInt32(xmlNode["Health"].InnerText);
        }
    }
    public class UnitCollection
    {
        public Unit this[string name]
        {
            get
            {
                for (int i = 0; i < Count; i++)
                    if (Unit[i].Name == name)
                        return Unit[i];

                return null;
            }
        }
        public Unit this[int index] { get { return Unit[index]; } }

        public Unit[] Unit
        {
            get { return unit; }
            set { unit = value; }
        } private Unit[] unit;
        public int Count { get { return Unit.Length; } }

        public UnitCollection()
        {
            Unit = new Unit[0];
        }

        public void Add(Unit unit)
        {
            Array.Resize(ref this.unit, this.unit.Length + 1);
            Unit[Unit.Length - 1] = unit;
        }
        public void Remove(string regionName)
        {
            int i = 0;
            while (i < Unit.Length)
            {
                if (Unit[i].Name == regionName)
                {
                    for (int j = i + 1; j < this.unit.Length; j++)
                        Unit[j - 1] = Unit[j];

                    Array.Resize(ref this.unit, Unit.Length - 1);
                }

                i += 1;
            }
        }
        public void Clear()
        {
            Unit = new Unit[0];
        }
    }
}
