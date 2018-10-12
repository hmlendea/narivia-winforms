using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Xml;

public class Options
{
    static XmlDocument xml = new XmlDocument();
    public static string xmlPath = "Options.XML";

    public static string PlayerName = "";
    public static bool Sound = false;
    public static int SoundVolume = 100;
    public static bool FullScreen = false;
    public static Size Resolution = new Size(1024, 640);
    public static bool AutoSave = true;
    public static bool MapOverlay = true;

    public static void Load()
    {
        Log.WriteLine("Loading Options from '" + xmlPath + "'...");
        xml.Load(xmlPath);

        PlayerName = xml.SelectSingleNode("Options//PlayerName").InnerText;
        Sound = Convert.ToBoolean(xml.SelectSingleNode("Options//Sound").SelectSingleNode("Enabled").InnerText);
        SoundVolume = Convert.ToInt32(xml.SelectSingleNode("Options//Sound").SelectSingleNode("Volume").InnerText);
        FullScreen = Convert.ToBoolean(xml.SelectSingleNode("Options//FullScreen").InnerText);
        AutoSave = Convert.ToBoolean(xml.SelectSingleNode("Options//AutoSave").InnerText);
        MapOverlay = Convert.ToBoolean(xml.SelectSingleNode("Options//MapOverlay").InnerText);

        Resolution = new Size(
            Convert.ToInt32(xml.SelectSingleNode("Options//Resolution").SelectSingleNode("Width").InnerText),
            Convert.ToInt32(xml.SelectSingleNode("Options//Resolution").SelectSingleNode("Height").InnerText));
    }

    public static void Save()
    {
        Log.WriteLine("Saving Options to '" + xmlPath + "'...");
        xml.Load(xmlPath);

        xml.SelectSingleNode("Options//PlayerName").InnerText = PlayerName;
        xml.SelectSingleNode("Options//Sound//Enabled").InnerText = Sound.ToString();
        xml.SelectSingleNode("Options//Sound//Volume").InnerText = SoundVolume.ToString();
        xml.SelectSingleNode("Options//FullScreen").InnerText = FullScreen.ToString();
        xml.SelectSingleNode("Options//AutoSave").InnerText = AutoSave.ToString();
        xml.SelectSingleNode("Options//MapOverlay").InnerText = MapOverlay.ToString();

        xml.Save(xmlPath);
    }
}

