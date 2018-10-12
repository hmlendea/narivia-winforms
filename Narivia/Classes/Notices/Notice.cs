using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using WMPLib;

namespace Narivia
{
    public partial class Notice : Form
    {
        static Notice Me;
        static DialogResult dialogResult = DialogResult.No;

        bool dragging;
        Point startPoint = new Point(0, 0);

        public Notice()
        {
            InitializeComponent();
            InitializeStyles();
            InitializeButtons();
            InitializeDrag();

            BackgroundImage = DrawingPlus.LoadImage(NarivianClass.NoticesDirectory + "Background.PNG");
            Cursor = CustomCursor.Load("Default.CUR");

            Sound.Play("Notice\\Notice.MP3");
            
            BringToFront();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        public static DialogResult Show(string msg, string title, string imageSound)
        {
            Me = new Notice();

            Me.pbImage.Image = DrawingPlus.LoadImage(NarivianClass.NoticesDirectory + imageSound + ".PNG");

            Me.lblMessage.Text = msg;
            Me.lblTitle.Text = title;

            Sound.Play("Notice\\" + imageSound + ".MP3");

            Me.ShowDialog();

            return dialogResult;
        }

        #region Initializers
        private void InitializeStyles()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
        }
        private void InitializeButtons()
        {
            PopUpButton btnYes = new PopUpButton("Yes");
            PopUpButton btnNo = new PopUpButton("No");

            btnYes.Location = new Point(276, 464);
            btnNo.Location = new Point(321, 464);

            btnYes.Click += new System.EventHandler(this.btnYes_Click);
            btnNo.Click += new System.EventHandler(this.btnNo_Click);

            Controls.Add(btnYes);
            Controls.Add(btnNo);
        }
        private void InitializeDrag()
        {
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.base_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.base_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.base_MouseUp);

            InitializeDrag(Controls);
        }
        private void InitializeDrag(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                if (ctrl.GetType() != typeof(PopUpButton))
                {
                    ctrl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.base_MouseDown);
                    ctrl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.base_MouseMove);
                    ctrl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.base_MouseUp);

                    if (ctrl.Controls.Count > 0)
                        InitializeDrag(ctrl.Controls);
                }
            }
        }
        #endregion

        #region Button Events
        private void btnYes_Click(object sender, EventArgs e)
        {
            dialogResult = DialogResult.Yes;
            Close();
        }
        private void btnNo_Click(object sender, EventArgs e)
        {
            dialogResult = DialogResult.No;
            Close();
        }
        #endregion

        #region Form Drag and Drop
        private void base_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }
        private void base_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void base_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }
        #endregion

        private void PopUp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Y)
                btnYes_Click(this, e);
            else if (e.KeyCode == Keys.N)
                btnNo_Click(this, e);
        }
    }
}
