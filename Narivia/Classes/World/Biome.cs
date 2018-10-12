using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Xml;

namespace Narivia.Game
{
    public class Biome
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public Image Terrain { get; set; }

        public void Load(string map, string assetsPack, int id)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(NarivianClass.MapsDirectory + map + "\\Biomes.XML");
            XmlNode xmlNode = xml.SelectNodes("/Biomes/Biome")[id];

            Name = xmlNode["Name"].InnerText;
            ID = id;
            Terrain = DrawingPlus.LoadImage(NarivianClass.AssetsDirectory + assetsPack + "\\Biomes\\" + Name + ".PNG");
        }
    }
    public class BiomeCollection
    {
        public Biome this[string name]
        {
            get
            {
                for (int i = 0; i < Count; i++)
                    if (Biome[i].Name == name)
                        return Biome[i];

                return null;
            }
        }
        public Biome this[int index] { get { return Biome[index]; } }

        public Biome[] Biome
        {
            get { return biome; }
            set { biome = value; }
        } private Biome[] biome;
        public int Count { get { return Biome.Length; } }

        public BiomeCollection()
        {
            Biome = new Biome[0];
        }

        public void Add(Biome biome)
        {
            Array.Resize(ref this.biome, this.biome.Length + 1);
            Biome[Biome.Length - 1] = biome;
        }
        public void Remove(string biomeName)
        {
            int i = 0;
            while (i < Biome.Length)
            {
                if (Biome[i].Name == biomeName)
                {
                    for (int j = i + 1; j < this.biome.Length; j++)
                        Biome[j - 1] = Biome[j];

                    Array.Resize(ref this.biome, Biome.Length - 1);
                }

                i += 1;
            }
        }
        public void Clear()
        {
            Biome = new Biome[0];
        }
    }
}
