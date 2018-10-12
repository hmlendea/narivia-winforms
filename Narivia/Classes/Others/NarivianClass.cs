using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Narivia
{
    public class NarivianClass
    {
        public static string AssetsDirectory { get { return Environment.CurrentDirectory + @"\Data\World\Assets\"; } }
        public static string CursorsDirectory { get { return Environment.CurrentDirectory + @"\Data\Cursors\"; } }
        public static string IconsDirectory { get { return Environment.CurrentDirectory + @"\Data\GFX\Icons\"; } }
        public static string NoticesDirectory { get { return Environment.CurrentDirectory + @"\Data\GFX\Notice\"; } }
        public static string MapsDirectory { get { return Environment.CurrentDirectory + @"\Data\World\Maps\"; } }
        public static string PanelsDirectory { get { return Environment.CurrentDirectory + @"\Data\GFX\Panels\"; } }
        public static string SoundsDirectory { get { return Environment.CurrentDirectory + @"\Data\Sound\"; } }

        public static float NumToPercent(float nr, float total)
        {
            if (total >= 0)
                return (nr / total) * 100;
            else
                return 0;
        }
        public static bool ChancePercentage(int chances)
        {
            Random rnd = new Random();
            int rndNumber = rnd.Next(1, 101);

            if (rndNumber <= chances)
                return true;
            else
                return false;
        }
        public static string RelationsToString(int val)
        {
            if (val < -75)
                return "Abysmal";
            else if (val < -50)
                return "Terrible";
            else if (val < -25)
                return "Very Poor";
            else if (val < 0)
                return "Poor";
            else if (val == 0)
                return "Neutral";
            else if (val <= 25)
                return "Good";
            else if (val <= 50)
                return "Very Good";
            else if (val <= 75)
                return "Excellent";
            else if (val <= 100)
                return "Outstanding";
            else
                return "[INVALID_RELATIONS]";
        }
    }
}
