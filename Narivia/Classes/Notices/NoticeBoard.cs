using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Narivia
{
    class NoticeBoard : Panel
    {
        CustomToolTip Tip = new CustomToolTip();

        public void Add(string msg, string title, string imageSound)
        {
            NoticeIcon icn = new NoticeIcon(imageSound);

            Tip.SetToolTip(icn, title);

            icn.Click += delegate
            {
                Notice.Show(msg, title, imageSound);
                RemoveNotice(icn);
            };

            icn.Disposed += delegate
            {
                base.Controls.Remove(icn);
                ArrangeNotices();
            };

            base.Controls.Add(icn);
            ArrangeNotices();
        }
        public void RemoveNotice(Control notice)
        {
            base.Controls.Remove(notice);
            notice.Dispose();
            ArrangeNotices();
        }
        public void Clear()
        {
            base.Visible = false;

            foreach (Control notice in base.Controls)
            {
                base.Controls.Remove(notice);
                notice.Dispose();
            }

            base.Controls.Clear();

            Tip.RemoveAll();
            base.Height = 0;

            base.Visible = true;
        }

        private void ArrangeNotices()
        {
            base.Visible = false;

            int i = 0;
            int noticeHeight = 0;

            foreach (Control notice in base.Controls)
            {
                notice.Location = new Point(0, notice.Height * i);
                i += 1;
                noticeHeight = notice.Height;
            }

            base.Height = i * noticeHeight;

            if (this.Size.Height == this.MaximumSize.Height)
                this.Width = 65;
            else
                this.Width = 48;

            base.Visible = true;
        }
    }
}
