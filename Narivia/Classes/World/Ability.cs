using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Xml;

namespace Narivia.Game
{
    public class Ability
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int IncomeBonus { get; set; }
        public int OutcomeBonus { get; set; }
        public int AttackBonus { get; set; }
        public int DefenceBonus { get; set; }
        public int RecruitmentBonus { get; set; }

        public void Load(string map, int id)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(NarivianClass.MapsDirectory + map + "\\Abilities.XML");
            XmlNode xmlNode = xml.SelectNodes("/Abilities/Ability")[id];

            Name = xmlNode["Name"].InnerText;
            ID = id;
            IncomeBonus = Convert.ToInt32(xmlNode["IncomeBonus"].InnerText);
            OutcomeBonus = Convert.ToInt32(xmlNode["OutcomeBonus"].InnerText);
            AttackBonus = Convert.ToInt32(xmlNode["AttackBonus"].InnerText);
            DefenceBonus = Convert.ToInt32(xmlNode["DefenceBonus"].InnerText);
            RecruitmentBonus = Convert.ToInt32(xmlNode["RecruitmentBonus"].InnerText);
        }
    }
    public class AbilityCollection
    {
        public Ability this[string name]
        {
            get
            {
                for (int i = 0; i < Count; i++)
                    if (Ability[i].Name == name)
                        return Ability[i];

                return null;
            }
        }
        public Ability this[int index] { get { return Ability[index]; } }

        public Ability[] Ability
        {
            get { return ability; }
            set { ability = value; }
        } private Ability[] ability;
        public int Count { get { return Ability.Length; } }

        public AbilityCollection()
        {
            Ability = new Ability[0];
        }

        public void Add(Ability ability)
        {
            Array.Resize(ref this.ability, this.ability.Length + 1);
            Ability[Ability.Length - 1] = ability;
        }
        public void Remove(string abilityName)
        {
            int i = 0;
            while (i < Ability.Length)
            {
                if (Ability[i].Name == abilityName)
                {
                    for (int j = i + 1; j < this.ability.Length; j++)
                        Ability[j - 1] = Ability[j];

                    Array.Resize(ref this.ability, Ability.Length - 1);
                }

                i += 1;
            }
        }
        public void Clear()
        {
            Ability = new Ability[0];
        }
    }
}
