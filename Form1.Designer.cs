namespace Screenz
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.screenBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.deleteBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.folderBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.showBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.closeBtn = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.saveBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.settingsBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.hotkeyLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // screenBtn
            // 
            this.screenBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(127)))));
            this.screenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(127)))));
            this.screenBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.screenBtn.BorderRadius = 0;
            this.screenBtn.ButtonText = "";
            this.screenBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.screenBtn.DisabledColor = System.Drawing.Color.Gray;
            this.screenBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.screenBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("screenBtn.Iconimage")));
            this.screenBtn.Iconimage_right = null;
            this.screenBtn.Iconimage_right_Selected = null;
            this.screenBtn.Iconimage_Selected = null;
            this.screenBtn.IconMarginLeft = 0;
            this.screenBtn.IconMarginRight = 0;
            this.screenBtn.IconRightVisible = true;
            this.screenBtn.IconRightZoom = 0D;
            this.screenBtn.IconVisible = true;
            this.screenBtn.IconZoom = 50D;
            this.screenBtn.IsTab = false;
            this.screenBtn.Location = new System.Drawing.Point(386, 20);
            this.screenBtn.Name = "screenBtn";
            this.screenBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(127)))));
            this.screenBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.screenBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.screenBtn.selected = false;
            this.screenBtn.Size = new System.Drawing.Size(36, 34);
            this.screenBtn.TabIndex = 3;
            this.screenBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.screenBtn.Textcolor = System.Drawing.Color.White;
            this.screenBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.screenBtn, "Takes a snapshot and copy it into your clipboard!");
            this.screenBtn.Click += new System.EventHandler(this.screenBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteBtn.BorderRadius = 0;
            this.deleteBtn.ButtonText = "";
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.DisabledColor = System.Drawing.Color.Gray;
            this.deleteBtn.Enabled = false;
            this.deleteBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.deleteBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Iconimage")));
            this.deleteBtn.Iconimage_right = null;
            this.deleteBtn.Iconimage_right_Selected = null;
            this.deleteBtn.Iconimage_Selected = null;
            this.deleteBtn.IconMarginLeft = 0;
            this.deleteBtn.IconMarginRight = 0;
            this.deleteBtn.IconRightVisible = true;
            this.deleteBtn.IconRightZoom = 0D;
            this.deleteBtn.IconVisible = true;
            this.deleteBtn.IconZoom = 75D;
            this.deleteBtn.IsTab = false;
            this.deleteBtn.Location = new System.Drawing.Point(344, 20);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.deleteBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.deleteBtn.selected = false;
            this.deleteBtn.Size = new System.Drawing.Size(36, 34);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteBtn.Textcolor = System.Drawing.Color.White;
            this.deleteBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // folderBtn
            // 
            this.folderBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(15)))));
            this.folderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(15)))));
            this.folderBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.folderBtn.BorderRadius = 0;
            this.folderBtn.ButtonText = "";
            this.folderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.folderBtn.DisabledColor = System.Drawing.Color.Gray;
            this.folderBtn.Enabled = false;
            this.folderBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.folderBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("folderBtn.Iconimage")));
            this.folderBtn.Iconimage_right = null;
            this.folderBtn.Iconimage_right_Selected = null;
            this.folderBtn.Iconimage_Selected = null;
            this.folderBtn.IconMarginLeft = 0;
            this.folderBtn.IconMarginRight = 0;
            this.folderBtn.IconRightVisible = true;
            this.folderBtn.IconRightZoom = 0D;
            this.folderBtn.IconVisible = true;
            this.folderBtn.IconZoom = 50D;
            this.folderBtn.IsTab = false;
            this.folderBtn.Location = new System.Drawing.Point(218, 20);
            this.folderBtn.Name = "folderBtn";
            this.folderBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(15)))));
            this.folderBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(255)))), ((int)(((byte)(97)))));
            this.folderBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.folderBtn.selected = false;
            this.folderBtn.Size = new System.Drawing.Size(36, 34);
            this.folderBtn.TabIndex = 3;
            this.folderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.folderBtn.Textcolor = System.Drawing.Color.White;
            this.folderBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderBtn.Click += new System.EventHandler(this.folderBtn_Click);
            // 
            // showBtn
            // 
            this.showBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(0)))));
            this.showBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(0)))));
            this.showBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showBtn.BorderRadius = 0;
            this.showBtn.ButtonText = "";
            this.showBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showBtn.DisabledColor = System.Drawing.Color.Gray;
            this.showBtn.Enabled = false;
            this.showBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.showBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("showBtn.Iconimage")));
            this.showBtn.Iconimage_right = null;
            this.showBtn.Iconimage_right_Selected = null;
            this.showBtn.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("showBtn.Iconimage_Selected")));
            this.showBtn.IconMarginLeft = 0;
            this.showBtn.IconMarginRight = 0;
            this.showBtn.IconRightVisible = true;
            this.showBtn.IconRightZoom = 0D;
            this.showBtn.IconVisible = true;
            this.showBtn.IconZoom = 50D;
            this.showBtn.IsTab = false;
            this.showBtn.Location = new System.Drawing.Point(260, 20);
            this.showBtn.Name = "showBtn";
            this.showBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(0)))));
            this.showBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(76)))));
            this.showBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.showBtn.selected = false;
            this.showBtn.Size = new System.Drawing.Size(36, 34);
            this.showBtn.TabIndex = 3;
            this.showBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showBtn.Textcolor = System.Drawing.Color.White;
            this.showBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.showBtn, "Upload your latest screenshot an generate a link\r\nwhat you can share with friends" +
        " or something!");
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSize = true;
            this.closeBtn.Location = new System.Drawing.Point(412, 1);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(14, 13);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "X";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.hotkeyLabel);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 16);
            this.panel1.TabIndex = 5;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(1, 1);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(78, 13);
            this.bunifuCustomLabel1.TabIndex = 6;
            this.bunifuCustomLabel1.Text = "ScreenZ - v1.0";
            // 
            // saveBtn
            // 
            this.saveBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.saveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveBtn.BorderRadius = 0;
            this.saveBtn.ButtonText = "";
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.DisabledColor = System.Drawing.Color.Gray;
            this.saveBtn.Enabled = false;
            this.saveBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.saveBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("saveBtn.Iconimage")));
            this.saveBtn.Iconimage_right = null;
            this.saveBtn.Iconimage_right_Selected = null;
            this.saveBtn.Iconimage_Selected = null;
            this.saveBtn.IconMarginLeft = 0;
            this.saveBtn.IconMarginRight = 0;
            this.saveBtn.IconRightVisible = true;
            this.saveBtn.IconRightZoom = 0D;
            this.saveBtn.IconVisible = true;
            this.saveBtn.IconZoom = 50D;
            this.saveBtn.IsTab = false;
            this.saveBtn.Location = new System.Drawing.Point(302, 20);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.saveBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(205)))), ((int)(((byte)(123)))));
            this.saveBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.saveBtn.selected = false;
            this.saveBtn.Size = new System.Drawing.Size(36, 34);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveBtn.Textcolor = System.Drawing.Color.White;
            this.saveBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(2, 41);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(0, 13);
            this.bunifuCustomLabel2.TabIndex = 6;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // settingsBtn
            // 
            this.settingsBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(127)))));
            this.settingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(127)))));
            this.settingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsBtn.BorderRadius = 0;
            this.settingsBtn.ButtonText = "";
            this.settingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsBtn.DisabledColor = System.Drawing.Color.Gray;
            this.settingsBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.settingsBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("settingsBtn.Iconimage")));
            this.settingsBtn.Iconimage_right = null;
            this.settingsBtn.Iconimage_right_Selected = null;
            this.settingsBtn.Iconimage_Selected = null;
            this.settingsBtn.IconMarginLeft = 0;
            this.settingsBtn.IconMarginRight = 0;
            this.settingsBtn.IconRightVisible = true;
            this.settingsBtn.IconRightZoom = 0D;
            this.settingsBtn.IconVisible = true;
            this.settingsBtn.IconZoom = 50D;
            this.settingsBtn.IsTab = false;
            this.settingsBtn.Location = new System.Drawing.Point(176, 20);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(127)))));
            this.settingsBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.settingsBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.settingsBtn.selected = false;
            this.settingsBtn.Size = new System.Drawing.Size(36, 34);
            this.settingsBtn.TabIndex = 3;
            this.settingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsBtn.Textcolor = System.Drawing.Color.White;
            this.settingsBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // hotkeyLabel
            // 
            this.hotkeyLabel.AutoSize = true;
            this.hotkeyLabel.Location = new System.Drawing.Point(339, 1);
            this.hotkeyLabel.Name = "hotkeyLabel";
            this.hotkeyLabel.Size = new System.Drawing.Size(47, 13);
            this.hotkeyLabel.TabIndex = 7;
            this.hotkeyLabel.Text = "Hotkey: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 58);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.folderBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.screenBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScreenZ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton screenBtn;
        private Bunifu.Framework.UI.BunifuFlatButton deleteBtn;
        private Bunifu.Framework.UI.BunifuFlatButton folderBtn;
        private Bunifu.Framework.UI.BunifuFlatButton showBtn;
        private System.Windows.Forms.Label closeBtn;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton saveBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        public System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuFlatButton settingsBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel hotkeyLabel;
    }
}

