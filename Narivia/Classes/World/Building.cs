using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Xml;

namespace Narivia.Game
{
    public class Building
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string Description { get; set; }
        public Image[] Icon { get; set; }
        public Image[] Preview { get; set; }
        public int Price { get; set; }
        public int Maintenance { get; set; }
        public int RequiredResource { get; set; }
        public int Income { get; set; }
        public int AttackBonus { get; set; }
        public int DefenceBonus { get; set; }
        public int RecruitmentBonus { get; set; }
        public int ReligionInfluence { get; set; }

        public void Load(string map, int id)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(NarivianClass.MapsDirectory + map + "\\Buildings.XML");
            XmlNode xmlNode = xml.SelectNodes("/Buildings/Building")[id];

            Name = xmlNode["Name"].InnerText;
            ID = id;
            Description = xmlNode["Description"].InnerText;
            Price = Convert.ToInt32(xmlNode["Price"].InnerText);
            Maintenance = Convert.ToInt32(xmlNode["Maintenance"].InnerText);
            RequiredResource = Convert.ToInt32(xmlNode["RequiredResource"].InnerText);
            //RequiredReligion = Convert.ToInt32(xmlNode["RequiredReligion"].InnerText);
            Income = Convert.ToInt32(xmlNode["Income"].InnerText);
            AttackBonus = Convert.ToInt32(xmlNode["AttackBonus"].InnerText);
            DefenceBonus = Convert.ToInt32(xmlNode["DefenceBonus"].InnerText);
            RecruitmentBonus = Convert.ToInt32(xmlNode["RecruitmentBonus"].InnerText);
            ReligionInfluence = Convert.ToInt32(xmlNode["ReligionInfluence"].InnerText);
        }
    }
    public class BuildingCollection
    {
        public Building this[string name]
        {
            get
            {
                for (int i = 0; i < Count; i++)
                    if (Building[i].Name == name)
                        return Building[i];

                return null;
            }
        }
        public Building this[int index] { get { return Building[index]; } }

        public Building[] Building
        {
            get { return building; }
            set { building = value; }
        } private Building[] building;
        public int Count { get { return Building.Length; } }

        public BuildingCollection()
        {
            Building = new Building[0];
        }

        public void Add(Building building)
        {
            Array.Resize(ref this.building, this.building.Length + 1);
            Building[Building.Length - 1] = building;
        }
        public void Remove(string buildingName)
        {
            int i = 0;
            while (i < Building.Length)
            {
                if (Building[i].Name == buildingName)
                {
                    for (int j = i + 1; j < this.building.Length; j++)
                        Building[j - 1] = Building[j];

                    Array.Resize(ref this.building, Building.Length - 1);
                }

                i += 1;
            }
        }
        public void Clear()
        {
            Building = new Building[0];
        }
    }
}
