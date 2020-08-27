namespace Gesk.Forms.Bases
{
    partial class Default
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Default));
            this.LBL_Title = new System.Windows.Forms.Label();
            this.CMP_BtnTopResize = new Gesk.Forms.Components.CmpBtnTopResize();
            this.CMP_BtnTopClose = new Gesk.Forms.Components.CmpBtnTopClose();
            this.CMP_BtnTopMinimize = new Gesk.Forms.Components.CmpBtnTopMinimize();
            this.SuspendLayout();
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Title.ForeColor = System.Drawing.SystemColors.Control;
            this.LBL_Title.Location = new System.Drawing.Point(12, 3);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(46, 23);
            this.LBL_Title.TabIndex = 1;
            this.LBL_Title.Text = "Title";
            this.LBL_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LBL_Title_MouseDown);
            // 
            // CMP_BtnTopResize
            // 
            this.CMP_BtnTopResize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CMP_BtnTopResize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.CMP_BtnTopResize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CMP_BtnTopResize.BackgroundImage")));
            this.CMP_BtnTopResize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CMP_BtnTopResize.Cursor = System.Windows.Forms.Cursors.Default;
            this.CMP_BtnTopResize.Location = new System.Drawing.Point(120, 0);
            this.CMP_BtnTopResize.Name = "CMP_BtnTopResize";
            this.CMP_BtnTopResize.Size = new System.Drawing.Size(50, 30);
            this.CMP_BtnTopResize.TabIndex = 3;
            this.CMP_BtnTopResize.Click += new System.EventHandler(this.CMP_BtnTopResize_Click);
            // 
            // CMP_BtnTopClose
            // 
            this.CMP_BtnTopClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CMP_BtnTopClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.CMP_BtnTopClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CMP_BtnTopClose.BackgroundImage")));
            this.CMP_BtnTopClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CMP_BtnTopClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.CMP_BtnTopClose.Location = new System.Drawing.Point(170, 0);
            this.CMP_BtnTopClose.Name = "CMP_BtnTopClose";
            this.CMP_BtnTopClose.Size = new System.Drawing.Size(50, 30);
            this.CMP_BtnTopClose.TabIndex = 2;
            this.CMP_BtnTopClose.Click += new System.EventHandler(this.CMPBtnTopClose_Click);
            // 
            // CMP_BtnTopMinimize
            // 
            this.CMP_BtnTopMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CMP_BtnTopMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.CMP_BtnTopMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CMP_BtnTopMinimize.BackgroundImage")));
            this.CMP_BtnTopMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CMP_BtnTopMinimize.Cursor = System.Windows.Forms.Cursors.Default;
            this.CMP_BtnTopMinimize.Location = new System.Drawing.Point(70, 0);
            this.CMP_BtnTopMinimize.Name = "CMP_BtnTopMinimize";
            this.CMP_BtnTopMinimize.Size = new System.Drawing.Size(50, 30);
            this.CMP_BtnTopMinimize.TabIndex = 4;
            this.CMP_BtnTopMinimize.Click += new System.EventHandler(this.CMP_BtnTopMinimize_Click);
            // 
            // Default
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.CMP_BtnTopMinimize);
            this.Controls.Add(this.CMP_BtnTopResize);
            this.Controls.Add(this.CMP_BtnTopClose);
            this.Controls.Add(this.LBL_Title);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Default";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Default";
            this.Load += new System.EventHandler(this.Default_Load);
            this.Resize += new System.EventHandler(this.Default_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.CmpBtnTopResize CMP_BtnTopResize;
        private System.Windows.Forms.Label LBL_Title;
        private Components.CmpBtnTopClose CMP_BtnTopClose;
        private Components.CmpBtnTopMinimize CMP_BtnTopMinimize;
    }
}