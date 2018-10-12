using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.IO;
using System.Xml;

namespace Narivia
{
    public partial class frmDownloadMaps : CustomForm
    {
        int maps;

        string selLink;

        public frmDownloadMaps()
        {
            InitializeComponent();
            PopulateList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            Log.WriteLine("Opening folder '" + NarivianClass.MapsDirectory + "'");
            Process.Start(NarivianClass.MapsDirectory);
        }

        private void ClearList()
        {
            foreach (Control c in pnlMaps.Controls)
                c.Dispose();
            pnlMaps.Controls.Clear();

            btnDownload.Visible = false;
        }
        private void PopulateList()
        {
            try
            {
                string[,] ss = new string[500, 500];
                int rows = 0, cols = 0;

                using (WebClient wc = new WebClient())
                {
                    string[] sheet = wc.DownloadString("https://docs.google.com/spreadsheet/pub?key=0Am6tel9lYl4ydDEyZUhyYUtNYmFGY2MtODIxUHFxcUE&output=txt").Split('\n');
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

                maps = 0;
                for (int i = 1; i < rows; i++)
                    if(ss[i, 0] != string.Empty)
                    {
                        MapListItem mli = new MapListItem(ss[i, 0], ss[i, 1], ss[i, 2], ss[i, 3], ss[i, 4]);

                        mli.Width = pnlMaps.Width - 30;
                        mli.Location = new Point(0, maps * mli.Height + maps);
                        mli.Click += mli_Click;

                        if (Directory.Exists(NarivianClass.MapsDirectory + mli.MapInternalName))
                        {
                            mli.Installed = true;

                            XmlDocument xml = new XmlDocument();
                            xml.Load(NarivianClass.MapsDirectory + mli.MapInternalName + "\\World.XML");

                            string version = xml.SelectSingleNode("World/MapVersion").InnerText;
                            
                            if (VersionChecker.CompareVersions(version, mli.MapVersion) >= 0)
                                mli.UpToDate = true;
                            else
                                mli.UpToDate = false;
                        }
                        else
                        {
                            mli.Installed = false;
                            mli.UpToDate = false;
                        }

                        pnlMaps.Controls.Add(mli);
                        maps += 1;
                    }
            }
            catch
            {
                Notice.Show("Cannot access maps database\n\nPlease check your internet connection", "Error", "GameVersion");
            }
        }
        private void RefreshList()
        {
            ClearList();
            PopulateList();
        }

        void mli_Click(object sender, EventArgs e)
        {
            MapListItem mli = (MapListItem)sender;

            selLink = mli.MapLink;

            btnDownload.Visible = true;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            Process.Start(selLink);
            RefreshList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}
