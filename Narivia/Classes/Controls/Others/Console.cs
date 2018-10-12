using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;

namespace Narivia.Custom_Controls
{
    class Console : TextBox
    {
        public Console()
        {
            BorderStyle = BorderStyle.Fixed3D;
            BackColor = Color.Black;
            ForeColor = Color.White;

            Size = new Size(418, 18);

            Font = new Font("Lucida Console", 8.25f);

            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Console_KeyDown);
        }

        private void Console_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendCommand(Text);
                Text = "";
            }
        }

        private void SendCommand(string cmd)
        {

        }
    }
}
