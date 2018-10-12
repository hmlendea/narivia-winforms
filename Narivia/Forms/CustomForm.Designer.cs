namespace Narivia
{
    partial class CustomForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MaximizeButton = new Narivia.CustomButton();
            this.ExitButton = new Narivia.CustomButton();
            this.MinimizeButton = new Narivia.CustomButton();
            this.FormBorder = new Narivia.CustomPanel();
            this.SuspendLayout();
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.AutoSizeBorder = false;
            this.MaximizeButton.BackColor = System.Drawing.Color.DarkRed;
            this.MaximizeButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.MaximizeButton.BorderSize = 2;
            this.MaximizeButton.Clicked = false;
            this.MaximizeButton.Font = new System.Drawing.Font("Palatino Linotype", 8F);
            this.MaximizeButton.ForeColor = System.Drawing.Color.Gold;
            this.MaximizeButton.Location = new System.Drawing.Point(568, 0);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Selected = false;
            this.MaximizeButton.ShadowColor = System.Drawing.Color.Black;
            this.MaximizeButton.Size = new System.Drawing.Size(36, 36);
            this.MaximizeButton.TabIndex = 3;
            this.MaximizeButton.Text = "☐";
            this.MaximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSizeBorder = false;
            this.ExitButton.BackColor = System.Drawing.Color.DarkRed;
            this.ExitButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.ExitButton.BorderSize = 2;
            this.ExitButton.Clicked = false;
            this.ExitButton.Font = new System.Drawing.Font("Palatino Linotype", 8F);
            this.ExitButton.ForeColor = System.Drawing.Color.Gold;
            this.ExitButton.Location = new System.Drawing.Point(604, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Selected = false;
            this.ExitButton.ShadowColor = System.Drawing.Color.Black;
            this.ExitButton.Size = new System.Drawing.Size(36, 36);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "X";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.AutoSizeBorder = false;
            this.MinimizeButton.BackColor = System.Drawing.Color.DarkRed;
            this.MinimizeButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.MinimizeButton.BorderSize = 2;
            this.MinimizeButton.Clicked = false;
            this.MinimizeButton.Font = new System.Drawing.Font("Palatino Linotype", 8F);
            this.MinimizeButton.ForeColor = System.Drawing.Color.Gold;
            this.MinimizeButton.Location = new System.Drawing.Point(532, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Selected = false;
            this.MinimizeButton.ShadowColor = System.Drawing.Color.Black;
            this.MinimizeButton.Size = new System.Drawing.Size(36, 36);
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.Text = "_";
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // FormBorder
            // 
            this.FormBorder.BackColor = System.Drawing.Color.DarkRed;
            this.FormBorder.Font = new System.Drawing.Font("Palatino Linotype", 18F);
            this.FormBorder.ForeColor = System.Drawing.Color.Gold;
            this.FormBorder.Location = new System.Drawing.Point(0, 0);
            this.FormBorder.Name = "FormBorder";
            this.FormBorder.ShadowColor = System.Drawing.Color.Black;
            this.FormBorder.Size = new System.Drawing.Size(532, 36);
            this.FormBorder.TabIndex = 0;
            this.FormBorder.TitleText = "DialogForm";
            this.FormBorder.TitleTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FormBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormBorder_MouseDown);
            // 
            // CustomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 384);
            this.Controls.Add(this.MaximizeButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.FormBorder);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "CustomForm";
            this.Padding = new System.Windows.Forms.Padding(6, 36, 6, 6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DialogForm";
            this.Load += new System.EventHandler(this.DialogForm_Load);
            this.SizeChanged += new System.EventHandler(this.DialogForm_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomPanel FormBorder;
        private CustomButton ExitButton;
        private CustomButton MinimizeButton;
        private CustomButton MaximizeButton;
    }
}