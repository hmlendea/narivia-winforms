using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Narivia.Game
{
    public class World
    {
        public Image Image { get; set; }
        public Image Overlay { get; set; }
        public int Width { get { return 640; } }
        public int Height { get { return 640; } }
        public int LoadingProgress { get { return loadingProgress; } }
        public bool Loaded { get; private set; }
        private int loadingProgress
        {
            get { return _loadingProgress; }
            set
            {
                _loadingProgress = value;
                LoadingProgressChanged(this, new WorldLoadingProgressEventArgs(value));
            }
        }int _loadingProgress;

        public int Player { get; set; }

        public string DisplayName { get; set; }
        public string InternalName { get; set; }
        public string AssetsPack { get; private set; }

        #region GameRules
        public int BaseRegionIncome { get; set; }
        public int BaseRegionRecruitment { get; set; }
        public int StartingMoney { get; set; }
        public int StartingTroops { get; set; }
        public int StartingReligion { get; set; }
        public MinMax RecruitmentRate { get; set; }
        public MinMax AttackerBonus { get; set; }
        public MinMax DefenderBonus { get; set; }
        public int MinTroopsAttack { get; set; }
        public float HealingRate { get; set; }
        #endregion

        public int[,] world;
        public bool[,] border;
        public int[,] relations;

        public RegionCollection Region { get; set; }
        public FactionCollection Faction { get; set; }
        public UnitCollection Unit { get; set; }
        public AbilityCollection Ability { get; set; }
        public CultureCollection Culture { get; set; }
        public ReligionCollection Religion { get; set; }
        public ResourceCollection Resource { get; set; }
        public BuildingCollection Building { get; set; }
        public BiomeCollection Biome { get; set; }

        public World()
        {
            LoadingProgressChanged += new WorldLoadingProgressEventHandler(world_LoadingProgressChanged);
            loadingProgress = 0;

            Region = new RegionCollection();
            Faction = new FactionCollection();
            Unit = new UnitCollection(); 
            Ability = new AbilityCollection(); 
            Culture = new CultureCollection(); 
            Religion = new ReligionCollection(); 
            Resource = new ResourceCollection(); 
            Building = new BuildingCollection();
            Biome = new BiomeCollection();
        }

        public void Load(string map)
        {
            world = new int[640, 640];
            InternalName = map;

            loadingProgress = 0;
            Log.WriteLine("Loading Map '" + map + "'...");
            XmlDocument xml = new XmlDocument();

            try
            {
                #region World.XML
                xml.Load(NarivianClass.MapsDirectory + map + "\\World.XML");

                DisplayName = xml.SelectSingleNode("World/DisplayName").InnerText;
                AssetsPack = xml.SelectSingleNode("World/Assets").InnerText;
                
                BaseRegionIncome = Convert.ToInt32(xml.SelectSingleNode("World/BaseRegionIncome").InnerText);
                BaseRegionRecruitment = Convert.ToInt32(xml.SelectSingleNode("World/BaseRegionRecruitment").InnerText);
                
                StartingMoney = Convert.ToInt32(xml.SelectSingleNode("World/StartingMoney").InnerText);
                StartingTroops = Convert.ToInt32(xml.SelectSingleNode("World/StartingTroops").InnerText);
                StartingReligion = Convert.ToInt32(xml.SelectSingleNode("World/StartingReligion").InnerText);

                RecruitmentRate = new MinMax(
                    Convert.ToInt32(xml.SelectSingleNode("World/RecruitmentRate").Attributes["Min"].InnerText),
                    Convert.ToInt32(xml.SelectSingleNode("World/RecruitmentRate").Attributes["Max"].InnerText));

                AttackerBonus = new MinMax(
                    Convert.ToInt32(xml.SelectSingleNode("World/AttackerBonus").Attributes["Min"].InnerText),
                    Convert.ToInt32(xml.SelectSingleNode("World/AttackerBonus").Attributes["Max"].InnerText));

                DefenderBonus = new MinMax(
                    Convert.ToInt32(xml.SelectSingleNode("World/DefenderBonus").Attributes["Min"].InnerText),
                    Convert.ToInt32(xml.SelectSingleNode("World/DefenderBonus").Attributes["Max"].InnerText));
                
                MinTroopsAttack = Convert.ToInt32(xml.SelectSingleNode("World/MinTroopsAttack").InnerText);
                HealingRate = Convert.ToSingle(xml.SelectSingleNode("World/HealingRate").InnerText);
                #endregion
                loadingProgress += 1;
                #region Abilities.XML
                xml.Load(NarivianClass.MapsDirectory + InternalName + "\\Abilities.XML");

                for (int abl = 0; abl < xml.SelectNodes("/Abilities/Ability").Count; abl++)
                {
                    Ability ability = new Ability();
                    ability.Load(InternalName, abl);

                    Ability.Add(ability);
                }
                #endregion
                loadingProgress += 1;
                #region Biomes.XML
                xml.Load(NarivianClass.MapsDirectory + InternalName + "\\Biomes.XML");

                for (int bio = 0; bio < xml.SelectNodes("/Biomes/Biome").Count; bio++)
                {
                    Biome biome = new Biome();
                    biome.Load(InternalName, AssetsPack, bio);
                    
                    Biome.Add(biome);
                }
                #endregion
                loadingProgress += 1;
                #region Resources.XML
                xml.Load(NarivianClass.MapsDirectory + map + "\\Resources.XML");

                for (int res = 0; res < xml.SelectNodes("/Resources/Resource").Count; res++)
                {
                    Resource resource = new Resource();
                    resource.Load(InternalName, AssetsPack, res);

                    Resource.Add(resource);
                }
                #endregion
                loadingProgress += 1;
                #region Cultures.XML
                xml.Load(NarivianClass.MapsDirectory + map + "\\Cultures.XML");

                for (int cul = 0; cul < xml.SelectNodes("/Cultures/Culture").Count; cul++)
                {
                    Culture culture = new Culture();
                    culture.Load(map, cul);

                    Culture.Add(culture);
                }
                #endregion
                loadingProgress += 1;
                #region Religions.XML
                xml.Load(NarivianClass.MapsDirectory + map + "\\Religions.XML");

                for (int rel = 0; rel < xml.SelectNodes("/Religions/Religion").Count; rel++)
                {
                    Religion religion = new Religion();
                    religion.Load(InternalName, AssetsPack, rel);

                    Religion.Add(religion);
                }
                #endregion
                loadingProgress += 1;
                #region Buildings.XML
                xml.Load(NarivianClass.MapsDirectory + InternalName + "\\Buildings.XML");

                for (int bld = 0; bld < xml.SelectNodes("/Buildings/Building").Count; bld++)
                {
                    Building building = new Building();
                    building.Load(InternalName, bld);

                    building.Icon = new Image[Culture.Count];
                    building.Preview = new Image[Culture.Count];

                    for (int clt = 0; clt < Culture.Count; clt++)
                    {
                        building.Icon[clt] = DrawingPlus.LoadImage(NarivianClass.AssetsDirectory + AssetsPack + "\\Buildings\\" + Culture[clt].Name + "\\Small\\" + building.Name + ".PNG", false);
                        building.Preview[clt] = DrawingPlus.LoadImage(NarivianClass.AssetsDirectory + AssetsPack + "\\Buildings\\" + Culture[clt].Name + "\\Large\\" + building.Name + ".PNG", false);

                        if (building.Icon[clt] == null)
                            building.Icon[clt] = DrawingPlus.LoadImage(NarivianClass.AssetsDirectory + AssetsPack + "\\Buildings\\" + Culture[0].Name + "\\Small\\" + building.Name + ".PNG");
                        if (building.Preview[clt] == null)
                        {
                            building.Preview[clt] = DrawingPlus.LoadImage(NarivianClass.AssetsDirectory + AssetsPack + "\\Buildings\\" + Culture[0].Name + "\\Large\\" + building.Name + ".PNG", false);
                            
                            if (building.Preview[clt] == null)
                                building.Preview[clt] = building.Icon[clt];
                        }
                    }

                    Building.Add(building);
                }
                #endregion
                loadingProgress += 1;
                #region Units.XML
                xml.Load(NarivianClass.MapsDirectory + map + "\\Units.XML");

                for (int unt = 0; unt < xml.SelectNodes("/Units/Unit").Count; unt++)
                {
                    Unit unit = new Unit();
                    unit.Load(map, AssetsPack, unt);

                    Unit.Add(unit);
                }
                #endregion
                loadingProgress += 1;
                #region Factions.XML
                xml.Load(NarivianClass.MapsDirectory + InternalName + "\\Factions.XML");

                for (int fct = 0; fct < xml.SelectNodes("/Factions/Faction").Count; fct++)
                {
                    Faction faction = new Faction();
                    faction.Load(InternalName, AssetsPack, fct);

                    Faction.Add(faction);
                }

                #endregion
                loadingProgress += 1;
                #region Regions.XML
                xml.Load(NarivianClass.MapsDirectory + map + "\\Regions.XML");

                for (int reg = 0; reg < xml.SelectNodes("/Regions/Region").Count; reg++)
                {
                    Region region = new Region();
                    region.Load(map, reg);

                    Faction[region.Faction].Region[Faction[region.Faction].RegionCount] = reg;
                    Faction[region.Faction].RegionCount += 1;

                    if (Faction[region.Faction].RegionCount == 1)
                        region.Type = RegionType.Capital;
                    else
                        region.Type = RegionType.Province;

                    Region.Add(region);
                }
                #endregion
                loadingProgress += 1;

                #region Load Map.PNG
                Bitmap bmp = new Bitmap(NarivianClass.MapsDirectory + InternalName + "\\Map.PNG");
                FastBitmap fastBmp = new FastBitmap(bmp);

                fastBmp.LockBits();
                for (int i = 0; i < Width; i++)
                {
                    for (int j = 0; j < Height; j++)
                    {
                        Color clr = fastBmp.GetPixel(i, j);

                        for (int k = 0; k < Region.Count; k++)
                            if (clr == Region[k].Color)
                            {
                                world[i, j] = k;
                                break;
                            }
                    }

                    if (i % 80 == 0)
                        loadingProgress += 64 / (Width / 80);
                }
                fastBmp.UnlockBits();

                Image = bmp;
                #endregion
                loadingProgress += 3;
                #region Load Overlay.PNG
                if (File.Exists(NarivianClass.MapsDirectory + InternalName + "\\Overlay.PNG"))
                    Overlay = Image.FromFile(NarivianClass.MapsDirectory + InternalName + "\\Overlay.PNG");
                else
                    Overlay = new Bitmap(Width, Height);
                #endregion
                loadingProgress += 2;

                border = new bool[Region.Count, Region.Count];
                relations = new int[Region.Count, Region.Count];

                #region Detect Borders
                int[] dx = new int[24] { -1, -1, 0, 1, 1, 1, 0, -1, -2, -2, -2, -2, -1, 0, 1, 2, 2, 2, 2, 2, 1, 0, -1, -2 };
                int[] dy = new int[24] { 0, 1, 1, 1, 0, -1, -1, -1, -1, 0, 1, 2, 2, 2, 2, 2, 1, 0, -1, -2, -2, -2, -2, -2 };

                for (int x = 0; x < Width; x++)
                {
                    for (int y = 0; y < Height; y++)
                        for (int dir = 23; dir >= 0; dir--)
                            if (x + dx[dir] >= 0 && x + dx[dir] < Width &&
                                y + dy[dir] >= 0 && y + dy[dir] < Height)
                            {
                                int reg = world[x + dx[dir], y + dy[dir]];

                                if (reg != world[x, y])
                                {
                                    border[world[x, y], reg] = true;
                                    border[reg, world[x, y]] = true;
                                }
                            }

                    if (x % 40 == 0)
                        loadingProgress += 16 / (Width / 40);
                }
                #endregion

                InitializeFactions();
                loadingProgress += 1;

                InitializeRegions();
                loadingProgress += 1;

                loadingProgress = 100;
                Loaded = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading map!" + Environment.NewLine + Environment.NewLine + ex,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Log.WriteLine("ERROR: Error loading Map! " + ex);
            }
        }
        public void Save()
        {
            XmlDocument xml = new XmlDocument();
            XmlNodeList xmlNodeList;

            #region Regions
            Log.WriteLine("Writing Regions.XML...");

            xml.Load(NarivianClass.MapsDirectory + InternalName + "\\Regions.XML");
            xmlNodeList = xml.SelectNodes("Regions/Region");

            for (int reg = 0; reg < Region.Count; reg++)
            {
                xmlNodeList[reg].SelectSingleNode("Name").InnerText = Region[reg].Name;
                xmlNodeList[reg].SelectSingleNode("Faction").InnerText = Region[reg].Faction.ToString();
                xmlNodeList[reg].SelectSingleNode("Biome").InnerText = Region[reg].Biome.ToString();
                xmlNodeList[reg].SelectSingleNode("Resource").InnerText = Region[reg].Resource.ToString();
            }

            xml.Save(NarivianClass.MapsDirectory + InternalName + "\\Regions.XML");
            #endregion
            #region Factions
            Log.WriteLine("Writing Factions.XML...");

            xml.Load(NarivianClass.MapsDirectory + InternalName + "\\Factions.XML");
            xmlNodeList = xml.SelectNodes("Factions/Faction");

            for (int fct = 0; fct < Faction.Count; fct++)
            {
                xmlNodeList[fct].SelectSingleNode("Name").InnerText = Faction[fct].Name;
                xmlNodeList[fct].SelectSingleNode("Description").InnerText = Faction[fct].Description;
                xmlNodeList[fct].SelectSingleNode("Ability").InnerText = Faction[fct].Ability.ToString();
                xmlNodeList[fct].SelectSingleNode("Culture").InnerText = Faction[fct].Culture.ToString();
                xmlNodeList[fct].SelectSingleNode("Religion").InnerText = Faction[fct].Religion.ToString();
            }

            xml.Save(NarivianClass.MapsDirectory + InternalName + "\\Factions.XML");
            #endregion
            #region Abilities
            Log.WriteLine("Writing Abilities.XML...");

            xml.Load(NarivianClass.MapsDirectory + InternalName + "\\Abilities.XML");
            xmlNodeList = xml.SelectNodes("Abilities/Ability");

            for (int abl = 0; abl < Ability.Count; abl++)
            {
                xmlNodeList[abl].SelectSingleNode("Name").InnerText = Ability[abl].Name;
                xmlNodeList[abl].SelectSingleNode("IncomeBonus").InnerText = Ability[abl].IncomeBonus.ToString();
                xmlNodeList[abl].SelectSingleNode("OutcomeBonus").InnerText = Ability[abl].OutcomeBonus.ToString();
                xmlNodeList[abl].SelectSingleNode("AttackBonus").InnerText = Ability[abl].AttackBonus.ToString();
                xmlNodeList[abl].SelectSingleNode("DefenceBonus").InnerText = Ability[abl].DefenceBonus.ToString();
                xmlNodeList[abl].SelectSingleNode("RecruitmentBonus").InnerText = Ability[abl].RecruitmentBonus.ToString();
            }

            xml.Save(NarivianClass.MapsDirectory + InternalName + "\\Abilities.XML");
            #endregion
            #region Religion
            Log.WriteLine("Writing Religions.XML...");

            xml.Load(NarivianClass.MapsDirectory + InternalName + "\\Religions.XML");
            xmlNodeList = xml.SelectNodes("Religions/Religion");

            for (int rel = 0; rel < Religion.Count; rel++)
            {
                xmlNodeList[rel].SelectSingleNode("Name").InnerText = Religion[rel].Name;
                xmlNodeList[rel].SelectSingleNode("Description").InnerText = Religion[rel].Description;
            }

            xml.Save(NarivianClass.MapsDirectory + InternalName + "\\Religions.XML");
            #endregion

            //NoticeBoard.Add("Map '" + Name + "' has been sucessfully saved!", "Map Saved", "Saved");
        }

        public void DrawMap(Control ctrl)
        {
            int i, j, dir;
            int bordersColorValue = 16;
            Bitmap bmpMap = new Bitmap(640, 640);

            if (Options.MapOverlay)
                bordersColorValue = 48;

            ctrl.BackColor = Faction[0].Color;

            Graphics g = Graphics.FromImage(bmpMap);
            #region Drawing
            {
                for (i = 0; i < 640; i++)
                    for (j = 0; j < 640; j++)
                    {
                        g.FillRectangle(
                            new SolidBrush(Faction[Region[world[i, j]].Faction].Color),
                            new Rectangle(i, j, 1, 1));

                        if (Region[world[i, j]].Faction == 0)
                            g.FillRectangle(
                                new SolidBrush(Region[world[i, j]].Color),
                                new Rectangle(i, j, 1, 1));
                    }

                int[] dx = new int[4] { -1, 0, 1, 0 }; //int[] dx = new int[8] { -1, -1, -1, 0, 1, 1, 1, 0 };
                int[] dy = new int[4] { 0, 1, 0, -1 }; //int[] dy = new int[8] { -1, 0, 1, 1, 1, 0, -1, -1 };

                for (i = 1; i < Height - 1; i++)
                    for (j = 1; j < Width - 1; j++)
                        for (dir = 0; dir < Math.Min(dx.Length, dy.Length); dir++)
                            if (Region[world[i, j]].Faction != 0)
                            {
                                if (world[i, j] != world[i + dx[dir], j + dy[dir]] && world[i + dx[dir], j + dy[dir]] != 0)
                                    g.FillRectangle(
                                        new SolidBrush(DrawingPlus.DarkenColor(Faction[Region[world[i, j]].Faction].Color, bordersColorValue)),
                                        new Rectangle(i, j, 1, 1));

                                if (Region[world[i, j]].Faction != Region[world[i + dx[dir], j + dy[dir]]].Faction && Region[world[i + dx[dir], j + dy[dir]]].Faction != 0)
                                    for (int k = 0; k < 2; k++)
                                        g.FillRectangle(Brushes.Black, new Rectangle(i, j, 1, 1));
                            }
            }
            #endregion

            if (Options.MapOverlay)
                bmpMap = DrawingPlus.OverlayImages(bmpMap, (Bitmap)Overlay);

            Image = bmpMap;
            ctrl.BackgroundImage = Image;
        }

        public bool HasBorder(int fct, int reg)
        {
            for (int regPos = 0; regPos < Faction[fct].RegionCount; regPos++)
                if (border[Faction[fct].Region[regPos], reg])
                    return true;

            return false;
        }

        private void InitializeFactions()
        {
            for (int fct = 1; fct < Faction.Count; fct++)
            {
                Faction[fct].Money = StartingMoney;
                Faction[fct].Income = GetIncome(fct);
                Faction[fct].Outcome = GetOutcome(fct);

                for (int i = 0; i < Unit.Count; i++)
                    Faction[fct].Units[i] = StartingTroops;
            }
        }
        private void InitializeRegions()
        {
            for (int reg = 0; reg < Region.Count; reg++)
            {
                Region[reg].OriginalFaction = Region[reg].Faction;
                Region[reg].Building = new int[Building.Count];
                Region[reg].BuildingCulture = new int[Region[reg].Building.Length];
                Region[reg].BuildingCulture[0] = Faction[Region[reg].Faction].Culture;
                Region[reg].BuildingsCount = 1;
                Region[reg].Religion = new int[Religion.Count];
                Region[reg].Religion[Faction[Region[reg].Faction].Religion] = StartingReligion;
            }
        }

        #region Events
        public event WorldLoadingProgressEventHandler LoadingProgressChanged;
        private void world_LoadingProgressChanged(object sender, WorldLoadingProgressEventArgs e)
        { }
        #endregion

        #region Get Faction/Region Infos
        public int GetBaseRegionsIncome(int fct)
        {
            int income = Faction[fct].RegionCount * BaseRegionIncome;

            for (int regSlot = 0; regSlot < Faction[fct].RegionCount; regSlot++)
                if (Region[Faction[fct].Region[regSlot]].Type == RegionType.Capital)
                    income += BaseRegionIncome;

            return income;
        }
        public int GetBuildingsIncome(int fct)
        {
            int buildingIncome = 0;

            for (int regSlot = 0; regSlot < Faction[fct].RegionCount; regSlot++)
            {
                int reg = Faction[fct].Region[regSlot];

                for (int i = 1; i < Region[reg].BuildingsCount; i++)
                    buildingIncome += Building[Region[reg].Building[i]].Income;
            }

            return buildingIncome;
        }
        public int GetBuildingsMaintenance(int fct)
        {
            int buildingMaintenance = 0;

            for (int regSlot = 0; regSlot < Faction[fct].RegionCount; regSlot++)
            {
                int reg = Faction[fct].Region[regSlot];

                for (int i = 1; i < Region[reg].BuildingsCount; i++)
                    buildingMaintenance += Building[Region[reg].Building[i]].Maintenance;
            }

            return buildingMaintenance;
        }
        public int GetUnitsMaintenance(int fct)
        {
            int unitsMaintenance = 0;

            for (int unt = 0; unt < Unit.Count; unt++)
                unitsMaintenance += Faction[fct].Units[unt] * Unit[unt].Maintenance;

            return unitsMaintenance;
        }
        public int GetAttackBonus(int fct)
        {
            int attackBonus = Ability[Faction[fct].Ability].AttackBonus;

            for (int regPos = 0; regPos < Faction[fct].RegionCount; regPos++)
            {
                int reg = Faction[fct].Region[regPos];

                for (int i = 1; i < Region[reg].BuildingsCount; i++)
                    if (Region[reg].Building[i] != 0)
                        attackBonus += Building[Region[reg].Building[i]].AttackBonus;
                    else
                        break;
            }

            return attackBonus;
        }
        public int GetDefenceBonus(int fct)
        {
            int defenceBonus = Ability[Faction[fct].Ability].DefenceBonus;

            for (int regPos = 0; regPos < Faction[fct].RegionCount; regPos++)
            {
                int reg = Faction[fct].Region[regPos];

                for (int i = 1; i < Region[reg].BuildingsCount; i++)
                    if (Region[reg].Building[i] != 0)
                        defenceBonus += Building[Region[reg].Building[i]].DefenceBonus;
            }

            return defenceBonus;
        }
        public int GetRecruitmentBonus(int fct)
        {
            int recruitmentBonus = 0;

            for (int reg = 0; reg < Region.Count; reg++)
                if (Region[reg].Faction == fct)
                    for (int i = 1; i < Region[reg].BuildingsCount; i++)
                        if (Region[reg].Building[i] != 0)
                            recruitmentBonus += Building[Region[reg].Building[i]].RecruitmentBonus;

            recruitmentBonus += (int)(Ability[Faction[fct].Ability].RecruitmentBonus * recruitmentBonus / 100);

            return recruitmentBonus;
        }
        public int GetIncome(int fct)
        {
            int income = 0;

            income += GetBaseRegionsIncome(fct);
            income += GetBuildingsIncome(fct);
            //income += (int)(Ability[Faction[fct].Ability].IncomeBonus * income / 100);

            return income;
        }
        public int GetOutcome(int fct)
        {
            int outcome = 0;

            outcome += GetBuildingsMaintenance(fct);
            outcome += GetUnitsMaintenance(fct);
            //outcome += (int)(Ability[Faction[fct].Ability].OutcomeBonus * outcome / 100);

            return outcome;
        }
        public int GetAttackPower(int fct)
        {
            int pwr = 0;

            for (int unt = 0; unt < Unit.Count; unt++)
                pwr += Faction[fct].Units[unt] * (Unit[unt].Attack + 1);

            pwr += (int)(GetAttackBonus(fct) * pwr / 100);

            return pwr;
        }
        public int GetDefencePower(int fct)
        {
            int pwr = 0;

            for (int unt = 0; unt < Unit.Count; unt++)
                pwr += Faction[fct].Units[unt] * (Unit[unt].Attack + 1);

            pwr += (int)(GetDefenceBonus(fct) * pwr / 100);

            return pwr;
        }
        #endregion
    }
    #region Event Class
    public delegate void WorldLoadingProgressEventHandler(object sender, WorldLoadingProgressEventArgs e);
    public class WorldLoadingProgressEventArgs : EventArgs
    {
        public int Progress { get; set; }

        public WorldLoadingProgressEventArgs(int progress)
        {
            Progress = progress;
        }
        public int GetInfo()
        {
            return Progress;
        }
    }
    #endregion
}
