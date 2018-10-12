using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Xml;

namespace Narivia.Game
{
    public class Resource
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public Image Icon { get; set; }

        public void Load(string map, string assetsPack, int id)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(NarivianClass.MapsDirectory + map + "\\Resources.XML");
            XmlNode xmlNode = xml.SelectNodes("/Resources/Resource")[id];

            Name = xmlNode["Name"].InnerText;
            ID = id;
            Icon = DrawingPlus.LoadImage(NarivianClass.AssetsDirectory + assetsPack + "\\Icons\\Resources\\" + Name + ".PNG");
        }
    }
    public class ResourceCollection
    {
        public Resource this[string name]
        {
            get
            {
                for (int i = 0; i < Count; i++)
                    if (Resource[i].Name == name)
                        return Resource[i];

                return null;
            }
        }
        public Resource this[int index] { get { return Resource[index]; } }

        public Resource[] Resource
        {
            get { return resource; }
            set { resource = value; }
        } private Resource[] resource;
        public int Count { get { return Resource.Length; } }

        public ResourceCollection()
        {
            Resource = new Resource[0];
        }

        public void Add(Resource resource)
        {
            Array.Resize(ref this.resource, this.resource.Length + 1);
            Resource[Resource.Length - 1] = resource;
        }
        public void Remove(string resourceName)
        {
            int i = 0;
            while (i < Resource.Length)
            {
                if (Resource[i].Name == resourceName)
                {
                    for (int j = i + 1; j < this.resource.Length; j++)
                        Resource[j - 1] = Resource[j];

                    Array.Resize(ref this.resource, Resource.Length - 1);
                }

                i += 1;
            }
        }
        public void Clear()
        {
            Resource = new Resource[0];
        }
    }
}
