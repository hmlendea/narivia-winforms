using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Xml;

namespace Narivia.Game
{
    public class Religion
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string Description { get; set; }
        public Image Icon { get; set; }

        public void Load(string map, string assetsPack, int id)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(NarivianClass.MapsDirectory + map + "\\Religions.XML");
            XmlNode xmlNode = xml.SelectNodes("/Religions/Religion")[id];

            Name = xmlNode["Name"].InnerText;
            ID = id;
            Description = xmlNode["Description"].InnerText;
            Icon = DrawingPlus.LoadImage(NarivianClass.AssetsDirectory + assetsPack + "\\Icons\\Religions\\" + Name + ".PNG");
        }
    }
    public class ReligionCollection
    {
        public Religion this[string name]
        {
            get
            {
                for (int i = 0; i < Count; i++)
                    if (Religion[i].Name == name)
                        return Religion[i];

                return null;
            }
        }
        public Religion this[int index] { get { return Religion[index]; } }

        public Religion[] Religion
        {
            get { return religion; }
            set { religion = value; }
        } private Religion[] religion;
        public int Count { get { return Religion.Length; } }

        public ReligionCollection()
        {
            Religion = new Religion[0];
        }

        public void Add(Religion religion)
        {
            Array.Resize(ref this.religion, this.religion.Length + 1);
            Religion[Religion.Length - 1] = religion;
        }
        public void Remove(string religionName)
        {
            int i = 0;
            while (i < Religion.Length)
            {
                if (Religion[i].Name == religionName)
                {
                    for (int j = i + 1; j < this.religion.Length; j++)
                        Religion[j - 1] = Religion[j];

                    Array.Resize(ref this.religion, Religion.Length - 1);
                }

                i += 1;
            }
        }
        public void Clear()
        {
            Religion = new Religion[0];
        }
    }
}
