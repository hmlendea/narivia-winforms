using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.Threading;
using System.Reflection;

namespace Narivia
{
    static class VersionChecker
    {
        public static void CheckVersion(bool silent = false)
        {
            new Thread((ThreadStart)delegate
            {
                try
                {
                    string[,] ss = new string[500, 500];
                    int rows = 0, cols = 0;

                    bool ok = false;

                    using (WebClient wc = new WebClient())
                    {
                        string[] sheet = wc.DownloadString("https://docs.google.com/spreadsheet/pub?key=0Am6tel9lYl4ydERWZ3Vwak1LUGxfUmxFX1ljQllZblE&single=true&gid=0&output=txt").Split('\n');
                        rows = sheet.Length;

                        for (int i = 0; i < rows; i++)
                        {
                            string[] col = sheet[i].Split('\t');

                            for (int j = 0; j < col.Length; j++)
                                ss[i, j] = col[j];

                            if (col.Length > cols)
                                cols = col.Length;
                        }
                    }

                    for (int i = 0; i <= rows; i++)
                        if (ss[i, 0] == Assembly.GetExecutingAssembly().GetName().Name)
                        {
                            string ver = ss[i, 1];
                            string link = ss[i, 2];

                            ok = true;

                            if (CompareVersions(Application.ProductVersion.ToString(), ver) < 0)
                            {
                                ShowUpdateDialog(ver, link);
                                Log.WriteLine("INFO: New version availabile (" + ver + ") at " + link);
                            }
                            else if (!silent)
                                Notice.Show("Congratulations, you have the latest version!\n\nUpdate not necessary",
                                "No update avalabile!", "GameVersion");
                        }

                    if (ok == false)
                        if (silent == false)
                            ShowErrorDialog(new Exception());
                }
                catch (Exception ex)
                {
                    if (silent == false)
                        ShowErrorDialog(ex);

                }
            }).Start();
        }

        public static void ShowUpdateDialog(string ver, string url)
        {
            if (Notice.Show(
                "A new version is avalibile! Do you want to download it now?" + Environment.NewLine + Environment.NewLine +
                "Your version: " + Application.ProductVersion + Environment.NewLine +
                "New version: " + ver,
                "Update avalabile!", "GameVersion")
            == DialogResult.Yes)
            {
                Process.Start(url);
                Application.Exit();
            }
        }
        public static void ShowErrorDialog(Exception ex)
        {
            Notice.Show("Cannot check for new version.\n\nPlease check your internet connection!",
                "Cannot check version", "GameVersion");

            Log.WriteLine("ERROR: Cannot check for new version. " + ex.Message);
        }

        public static int CompareVersions(String strA, String strB)
        {
            Version vA = new Version(strA.Replace(",", "."));
            Version vB = new Version(strB.Replace(",", "."));

            return vA.CompareTo(vB);
        }
    }
}