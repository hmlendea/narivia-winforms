using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Narivia
{
    public enum CustomFormBorderStyle
    {
        None,
        Narivain
    }
    public partial class CustomForm : Form
    {
        #region Obsolete Properties
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        //[Obsolete("Don't use this", true)]
        public new FormBorderStyle FormBorderStyle
        {
            get { return formBorderStyle; }
            set { formBorderStyle = FormBorderStyle.None; }
        } FormBorderStyle formBorderStyle;
        //[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        //[Obsolete("Don't use this", true)]
        //public new Icon Icon { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Don't use this", true)]
        public new bool ShowIcon { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Don't use this", true)]
        public new SizeGripStyle SizeGripStyle { get; set; }
        #endregion

        #region New Properties
        public Color BorderColor
        {
            get { return FormBorder.BackColor; }
            set
            {
                FormBorder.BackColor = value;
                MinimizeButton.BackColor = value;
                MaximizeButton.BackColor = value;
                ExitButton.BackColor = value;

                Refresh();
            }
        }
        public Color BorderTextColor
        {
            get { return FormBorder.ForeColor; }
            set
            {
                FormBorder.ForeColor = value;

                MinimizeButton.ForeColor = value;
                MinimizeButton.BorderColor = value;

                MaximizeButton.ForeColor = value;
                MaximizeButton.BorderColor = value;

                ExitButton.ForeColor = value;
                ExitButton.BorderColor = value;

                Refresh();
            }
        }
        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = value; Refresh(); }
        } int borderSize;
        public bool Border
        {
            get
            {
                return FormBorder.Visible;
            }
            set
            {
                FormBorder.Visible = value;
                ExitButton.Visible = value;
                MaximizeButton.Visible = value;
                MinimizeButton.Visible = value;
                Refresh();
            }
        }
        public bool FullScreen
        {
            get { return fullScreen; }
            set
            {
                fullScreen = value;

                if (value == true)
                {
                    Border = false;
                    WindowState = FormWindowState.Maximized;
                }
                else
                {
                    Border = true;
                    WindowState = FormWindowState.Normal;

                    if (Program.IsRunning) // Ca sa nu mi-l centreze si in Design
                        CenterToScreen();
                }
            }
        } bool fullScreen;
        public new bool MaximizeBox
        {
            get { return MaximizeButton.Enabled; }
            set { MaximizeButton.Enabled = value; }
        }
        public new bool MinimizeBox
        {
            get { return MinimizeButton.Enabled; }
            set { MinimizeButton.Enabled = value; }
        }
        #endregion

        private bool dragging;
        private Point startPoint = new Point(0, 0);

        public CustomForm()
        {
            InitializeComponent();
            InitializeStyles();
            InitializeDragging();
            
            BackgroundImageLayout = ImageLayout.Tile;
            BackgroundImage = Properties.Resources.Stone_Bricks;
            Cursor = CustomCursor.Load("Default.CUR");

            TextChanged += delegate { FormBorder.TitleText = Text; FormBorder.Refresh(); };

            StartPosition = FormStartPosition.CenterScreen;
            base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            FormBorder.Parent = this;
            FormBorder.TitleText = Text;

            //BackColor = Color.DarkRed;
            BorderColor = Color.DarkRed;
            BorderTextColor = Color.Gold;

            BorderSize = 6;

            DoubleBuffered = true;

            MouseDown += delegate { Cursor = CustomCursor.Load("Default_Pressed.CUR"); };
            MouseUp += delegate { Cursor = CustomCursor.Load("Default.CUR"); };
        }
        private void DialogForm_Load(object sender, EventArgs e)
        {
            UpdateFormWindowState();
        }

        private void InitializeStyles()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
        }
        private void InitializeDragging()
        {
            FormBorder.MouseDown += delegate
            {
                if (FullScreen == false)
                {
                    dragging = true;
                    startPoint = FormBorder.PointToClient(Control.MousePosition);
                }
            };
            FormBorder.MouseUp += delegate
            {
                dragging = false;
            };
            FormBorder.MouseMove += delegate
            {
                if (dragging)
                    Location = new Point(
                        Control.MousePosition.X - startPoint.X,
                        Control.MousePosition.Y - startPoint.Y);
            };
        }

        public void UpdateFormWindowState()
        {
            if (Options.FullScreen)
                FullScreen = true;
            else
                FullScreen = false;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle r = new Rectangle(10, 10, 50, 50);
            Graphics g = e.Graphics;

            //base.OnPaint(e);

            if (FullScreen == false)
                DrawingPlus.DrawBorder(g, ClientRectangle, BorderColor, BorderSize);
        }
        protected override CreateParams CreateParams // Anti-Flicker
        {
            get
            {
                CreateParams cp = base.CreateParams;

                if (Program.IsRunning)
                    cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED

                return cp;
            }
        }

        #region Buttons
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Resize
        private void DialogForm_SizeChanged(object sender, EventArgs e)
        {
            FormBorder.Width = Width - ExitButton.Width - MaximizeButton.Width - MinimizeButton.Width;

            ExitButton.Location = new Point(Width - ExitButton.Width, 0);
            MaximizeButton.Location = new Point(ExitButton.Location.X - MaximizeButton.Width, 0);
            MinimizeButton.Location = new Point(MaximizeButton.Location.X - MinimizeButton.Width, 0);

            //Refresh();
        }

        // http://stackoverflow.com/questions/17748446/custom-resize-handle-in-border-less-form-c-sharp
        protected override void WndProc(ref Message m)
        {
            if (FullScreen == false)
            {
                const UInt32 WM_NCHITTEST = 0x0084;
                const UInt32 WM_MOUSEMOVE = 0x0200;

                const UInt32 HTLEFT = 10;
                const UInt32 HTRIGHT = 11;
                const UInt32 HTBOTTOMRIGHT = 17;
                const UInt32 HTBOTTOM = 15;
                const UInt32 HTBOTTOMLEFT = 16;
                const UInt32 HTTOP = 12;
                const UInt32 HTTOPLEFT = 13;
                const UInt32 HTTOPRIGHT = 14;

                const int RESIZE_HANDLE_SIZE = 10;
                bool handled = false;
                if (m.Msg == WM_NCHITTEST || m.Msg == WM_MOUSEMOVE)
                {
                    Size formSize = this.Size;
                    Point screenPoint = new Point(m.LParam.ToInt32());
                    Point clientPoint = this.PointToClient(screenPoint);

                    Dictionary<UInt32, Rectangle> boxes = new Dictionary<UInt32, Rectangle>()
                    {
                        {HTBOTTOMLEFT, new Rectangle(0, formSize.Height - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
                        {HTBOTTOM, new Rectangle(RESIZE_HANDLE_SIZE, formSize.Height - RESIZE_HANDLE_SIZE, formSize.Width - 2*RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
                        {HTBOTTOMRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, formSize.Height - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
                        {HTRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, formSize.Height - 2*RESIZE_HANDLE_SIZE)},
                        {HTTOPRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, 0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
                        {HTTOP, new Rectangle(RESIZE_HANDLE_SIZE, 0, formSize.Width - 2*RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
                        {HTTOPLEFT, new Rectangle(0, 0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
                        {HTLEFT, new Rectangle(0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, formSize.Height - 2*RESIZE_HANDLE_SIZE) }
                    };

                    foreach (KeyValuePair<UInt32, Rectangle> hitBox in boxes)
                    {
                        if (hitBox.Value.Contains(clientPoint))
                        {
                            m.Result = (IntPtr)hitBox.Key;
                            handled = true;
                            break;
                        }
                    }
                }

                if (!handled)
                    base.WndProc(ref m);
            }
            else
                base.WndProc(ref m);
        }
        #endregion

        #region DoubleClick Maximize
        Point mousePos;
        DateTime clickedTime;
        bool IsSecondClick = false;

        private void FormBorder_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                if (IsSecondClick)
                {
                    IsSecondClick = false;

                    if (e.X == mousePos.X && e.Y == mousePos.Y &&
                    (DateTime.Now - clickedTime).TotalMilliseconds < 1500)
                        if (WindowState == FormWindowState.Maximized)
                            WindowState = FormWindowState.Normal;
                        else
                            WindowState = FormWindowState.Maximized;
                }
                else
                {
                    IsSecondClick = true;
                    clickedTime = DateTime.Now;
                    mousePos = new Point(e.X, e.Y);
                }
        }
        #endregion
    }
}
