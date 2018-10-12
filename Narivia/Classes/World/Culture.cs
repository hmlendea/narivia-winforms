using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Xml;

namespace Narivia.Game
{
    public class Culture
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string Description { get; set; }

        public void Load(string map, int id)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(NarivianClass.MapsDirectory + map + "\\Cultures.XML");
            XmlNode xmlNode = xml.SelectNodes("/Cultures/Culture")[id];

            Name = xmlNode["Name"].InnerText;
            ID = id;
            Description = xmlNode["Description"].InnerText;
        }
    }
    public class CultureCollection
    {
        public Culture this[string name]
        {
            get
            {
                for (int i = 0; i < Count; i++)
                    if (Culture[i].Name == name)
                        return Culture[i];

                return null;
            }
        }
        public Culture this[int index] { get { return Culture[index]; } }

        public Culture[] Culture
        {
            get { return culture; }
            set { culture = value; }
        } private Culture[] culture;
        public int Count { get { return Culture.Length; } }

        public CultureCollection()
        {
            Culture = new Culture[0];
        }

        public void Add(Culture culture)
        {
            Array.Resize(ref this.culture, this.culture.Length + 1);
            Culture[Culture.Length - 1] = culture;
        }
        public void Remove(string cultureName)
        {
            int i = 0;
            while (i < Culture.Length)
            {
                if (Culture[i].Name == cultureName)
                {
                    for (int j = i + 1; j < this.culture.Length; j++)
                        Culture[j - 1] = Culture[j];

                    Array.Resize(ref this.culture, Culture.Length - 1);
                }

                i += 1;
            }
        }
        public void Clear()
        {
            Culture = new Culture[0];
        }
    }
}
