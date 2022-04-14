
namespace Search_Names
{
    partial class Frm_Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Favorite = new System.Windows.Forms.Button();
            this.CmbB_Origin = new System.Windows.Forms.ComboBox();
            this.GrpB_Genus = new System.Windows.Forms.GroupBox();
            this.RdB_Female = new System.Windows.Forms.RadioButton();
            this.RdB_Male = new System.Windows.Forms.RadioButton();
            this.Txtb_Name = new System.Windows.Forms.TextBox();
            this.TxtB_Meaning = new System.Windows.Forms.TextBox();
            this.Lst_Names = new System.Windows.Forms.ListBox();
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Lbl_Meaning = new System.Windows.Forms.Label();
            this.Lbl_Origin = new System.Windows.Forms.Label();
            this.Lbl_Name_Res = new System.Windows.Forms.Label();
            this.Lbl_Name_Res_Value = new System.Windows.Forms.Label();
            this.Lnk_Link_Value = new System.Windows.Forms.LinkLabel();
            this.Lbl_Origin_Res = new System.Windows.Forms.Label();
            this.Lbl_Origin_Res_Value = new System.Windows.Forms.Label();
            this.Lbl_Meaning_Res = new System.Windows.Forms.Label();
            this.Lbl_Link = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.favoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GprB_Search = new System.Windows.Forms.GroupBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.TxtB_Meaning_Res_Value = new System.Windows.Forms.TextBox();
            this.GrpB_Genus.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.GprB_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Favorite
            // 
            this.Btn_Favorite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Favorite.Location = new System.Drawing.Point(570, 466);
            this.Btn_Favorite.Name = "Btn_Favorite";
            this.Btn_Favorite.Size = new System.Drawing.Size(104, 36);
            this.Btn_Favorite.TabIndex = 0;
            this.Btn_Favorite.Text = "button1";
            this.Btn_Favorite.UseVisualStyleBackColor = true;
            this.Btn_Favorite.Click += new System.EventHandler(this.Btn_Favorite_Click);
            // 
            // CmbB_Origin
            // 
            this.CmbB_Origin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbB_Origin.FormattingEnabled = true;
            this.CmbB_Origin.Location = new System.Drawing.Point(308, 124);
            this.CmbB_Origin.Name = "CmbB_Origin";
            this.CmbB_Origin.Size = new System.Drawing.Size(169, 28);
            this.CmbB_Origin.TabIndex = 1;
            // 
            // GrpB_Genus
            // 
            this.GrpB_Genus.Controls.Add(this.RdB_Female);
            this.GrpB_Genus.Controls.Add(this.RdB_Male);
            this.GrpB_Genus.Location = new System.Drawing.Point(16, 101);
            this.GrpB_Genus.Name = "GrpB_Genus";
            this.GrpB_Genus.Size = new System.Drawing.Size(254, 54);
            this.GrpB_Genus.TabIndex = 5;
            this.GrpB_Genus.TabStop = false;
            this.GrpB_Genus.Text = "groupBox1";
            // 
            // RdB_Female
            // 
            this.RdB_Female.AutoSize = true;
            this.RdB_Female.Location = new System.Drawing.Point(109, 24);
            this.RdB_Female.Name = "RdB_Female";
            this.RdB_Female.Size = new System.Drawing.Size(117, 24);
            this.RdB_Female.TabIndex = 1;
            this.RdB_Female.Text = "radioButton2";
            this.RdB_Female.UseVisualStyleBackColor = true;
            // 
            // RdB_Male
            // 
            this.RdB_Male.AutoSize = true;
            this.RdB_Male.Location = new System.Drawing.Point(38, 24);
            this.RdB_Male.Name = "RdB_Male";
            this.RdB_Male.Size = new System.Drawing.Size(65, 24);
            this.RdB_Male.TabIndex = 0;
            this.RdB_Male.Text = "radio";
            this.RdB_Male.UseVisualStyleBackColor = true;
            // 
            // Txtb_Name
            // 
            this.Txtb_Name.Location = new System.Drawing.Point(16, 48);
            this.Txtb_Name.Name = "Txtb_Name";
            this.Txtb_Name.Size = new System.Drawing.Size(254, 27);
            this.Txtb_Name.TabIndex = 6;
            // 
            // TxtB_Meaning
            // 
            this.TxtB_Meaning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtB_Meaning.Location = new System.Drawing.Point(308, 48);
            this.TxtB_Meaning.Name = "TxtB_Meaning";
            this.TxtB_Meaning.Size = new System.Drawing.Size(295, 27);
            this.TxtB_Meaning.TabIndex = 7;
            // 
            // Lst_Names
            // 
            this.Lst_Names.FormattingEnabled = true;
            this.Lst_Names.ItemHeight = 20;
            this.Lst_Names.Location = new System.Drawing.Point(45, 218);
            this.Lst_Names.Name = "Lst_Names";
            this.Lst_Names.Size = new System.Drawing.Size(242, 284);
            this.Lst_Names.TabIndex = 8;
            this.Lst_Names.SelectedIndexChanged += new System.EventHandler(this.Lst_Names_SelectedIndexChanged);
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Location = new System.Drawing.Point(16, 25);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(50, 20);
            this.Lbl_Name.TabIndex = 9;
            this.Lbl_Name.Text = "label1";
            // 
            // Lbl_Meaning
            // 
            this.Lbl_Meaning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Meaning.AutoSize = true;
            this.Lbl_Meaning.Location = new System.Drawing.Point(308, 23);
            this.Lbl_Meaning.Name = "Lbl_Meaning";
            this.Lbl_Meaning.Size = new System.Drawing.Size(50, 20);
            this.Lbl_Meaning.TabIndex = 10;
            this.Lbl_Meaning.Text = "label2";
            // 
            // Lbl_Origin
            // 
            this.Lbl_Origin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Origin.AutoSize = true;
            this.Lbl_Origin.Location = new System.Drawing.Point(308, 101);
            this.Lbl_Origin.Name = "Lbl_Origin";
            this.Lbl_Origin.Size = new System.Drawing.Size(50, 20);
            this.Lbl_Origin.TabIndex = 11;
            this.Lbl_Origin.Text = "label3";
            // 
            // Lbl_Name_Res
            // 
            this.Lbl_Name_Res.AutoSize = true;
            this.Lbl_Name_Res.Location = new System.Drawing.Point(331, 218);
            this.Lbl_Name_Res.Name = "Lbl_Name_Res";
            this.Lbl_Name_Res.Size = new System.Drawing.Size(50, 20);
            this.Lbl_Name_Res.TabIndex = 12;
            this.Lbl_Name_Res.Text = "label4";
            // 
            // Lbl_Name_Res_Value
            // 
            this.Lbl_Name_Res_Value.AutoSize = true;
            this.Lbl_Name_Res_Value.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Name_Res_Value.Location = new System.Drawing.Point(397, 218);
            this.Lbl_Name_Res_Value.Name = "Lbl_Name_Res_Value";
            this.Lbl_Name_Res_Value.Size = new System.Drawing.Size(52, 22);
            this.Lbl_Name_Res_Value.TabIndex = 13;
            this.Lbl_Name_Res_Value.Text = "label5";
            // 
            // Lnk_Link_Value
            // 
            this.Lnk_Link_Value.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lnk_Link_Value.Location = new System.Drawing.Point(331, 430);
            this.Lnk_Link_Value.Name = "Lnk_Link_Value";
            this.Lnk_Link_Value.Size = new System.Drawing.Size(343, 22);
            this.Lnk_Link_Value.TabIndex = 15;
            this.Lnk_Link_Value.TabStop = true;
            this.Lnk_Link_Value.Text = "linkLabel1";
            // 
            // Lbl_Origin_Res
            // 
            this.Lbl_Origin_Res.AutoSize = true;
            this.Lbl_Origin_Res.Location = new System.Drawing.Point(331, 250);
            this.Lbl_Origin_Res.Name = "Lbl_Origin_Res";
            this.Lbl_Origin_Res.Size = new System.Drawing.Size(50, 20);
            this.Lbl_Origin_Res.TabIndex = 16;
            this.Lbl_Origin_Res.Text = "label6";
            // 
            // Lbl_Origin_Res_Value
            // 
            this.Lbl_Origin_Res_Value.AutoEllipsis = true;
            this.Lbl_Origin_Res_Value.AutoSize = true;
            this.Lbl_Origin_Res_Value.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Origin_Res_Value.Location = new System.Drawing.Point(397, 250);
            this.Lbl_Origin_Res_Value.Name = "Lbl_Origin_Res_Value";
            this.Lbl_Origin_Res_Value.Size = new System.Drawing.Size(52, 22);
            this.Lbl_Origin_Res_Value.TabIndex = 17;
            this.Lbl_Origin_Res_Value.Text = "label7";
            // 
            // Lbl_Meaning_Res
            // 
            this.Lbl_Meaning_Res.AutoSize = true;
            this.Lbl_Meaning_Res.Location = new System.Drawing.Point(331, 283);
            this.Lbl_Meaning_Res.Name = "Lbl_Meaning_Res";
            this.Lbl_Meaning_Res.Size = new System.Drawing.Size(50, 20);
            this.Lbl_Meaning_Res.TabIndex = 18;
            this.Lbl_Meaning_Res.Text = "label8";
            // 
            // Lbl_Link
            // 
            this.Lbl_Link.AutoSize = true;
            this.Lbl_Link.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Link.Location = new System.Drawing.Point(331, 396);
            this.Lbl_Link.Name = "Lbl_Link";
            this.Lbl_Link.Size = new System.Drawing.Size(60, 22);
            this.Lbl_Link.TabIndex = 20;
            this.Lbl_Link.Text = "label10";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.favoritesToolStripMenuItem,
            this.cacheToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(713, 28);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // favoritesToolStripMenuItem
            // 
            this.favoritesToolStripMenuItem.Name = "favoritesToolStripMenuItem";
            this.favoritesToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.favoritesToolStripMenuItem.Text = "Favorites";
            this.favoritesToolStripMenuItem.Click += new System.EventHandler(this.favoritesToolStripMenuItem_Click);
            // 
            // cacheToolStripMenuItem
            // 
            this.cacheToolStripMenuItem.Name = "cacheToolStripMenuItem";
            this.cacheToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.cacheToolStripMenuItem.Text = "Cache";
            // 
            // GprB_Search
            // 
            this.GprB_Search.Controls.Add(this.Btn_Search);
            this.GprB_Search.Controls.Add(this.Txtb_Name);
            this.GprB_Search.Controls.Add(this.GrpB_Genus);
            this.GprB_Search.Controls.Add(this.Lbl_Name);
            this.GprB_Search.Controls.Add(this.TxtB_Meaning);
            this.GprB_Search.Controls.Add(this.CmbB_Origin);
            this.GprB_Search.Controls.Add(this.Lbl_Meaning);
            this.GprB_Search.Controls.Add(this.Lbl_Origin);
            this.GprB_Search.Location = new System.Drawing.Point(45, 31);
            this.GprB_Search.Name = "GprB_Search";
            this.GprB_Search.Size = new System.Drawing.Size(629, 171);
            this.GprB_Search.TabIndex = 22;
            this.GprB_Search.TabStop = false;
            this.GprB_Search.Text = "groupBox1";
            // 
            // Btn_Search
            // 
            this.Btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Search.Location = new System.Drawing.Point(495, 101);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(108, 54);
            this.Btn_Search.TabIndex = 12;
            this.Btn_Search.Text = "button1";
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // TxtB_Meaning_Res_Value
            // 
            this.TxtB_Meaning_Res_Value.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TxtB_Meaning_Res_Value.Location = new System.Drawing.Point(331, 306);
            this.TxtB_Meaning_Res_Value.Multiline = true;
            this.TxtB_Meaning_Res_Value.Name = "TxtB_Meaning_Res_Value";
            this.TxtB_Meaning_Res_Value.ReadOnly = true;
            this.TxtB_Meaning_Res_Value.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtB_Meaning_Res_Value.Size = new System.Drawing.Size(343, 80);
            this.TxtB_Meaning_Res_Value.TabIndex = 23;
            this.TxtB_Meaning_Res_Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 534);
            this.Controls.Add(this.TxtB_Meaning_Res_Value);
            this.Controls.Add(this.GprB_Search);
            this.Controls.Add(this.Lbl_Link);
            this.Controls.Add(this.Lbl_Meaning_Res);
            this.Controls.Add(this.Lbl_Origin_Res_Value);
            this.Controls.Add(this.Lbl_Origin_Res);
            this.Controls.Add(this.Lnk_Link_Value);
            this.Controls.Add(this.Lbl_Name_Res_Value);
            this.Controls.Add(this.Lbl_Name_Res);
            this.Controls.Add(this.Lst_Names);
            this.Controls.Add(this.Btn_Favorite);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Names";
            this.GrpB_Genus.ResumeLayout(false);
            this.GrpB_Genus.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GprB_Search.ResumeLayout(false);
            this.GprB_Search.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Favorite;
        private System.Windows.Forms.ComboBox CmbB_Origin;
        private System.Windows.Forms.GroupBox GrpB_Genus;
        private System.Windows.Forms.TextBox Txtb_Name;
        private System.Windows.Forms.TextBox TxtB_Meaning;
        private System.Windows.Forms.ListBox Lst_Names;
        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.Label Lbl_Meaning;
        private System.Windows.Forms.Label Lbl_Origin;
        private System.Windows.Forms.Label Lbl_Name_Res;
        private System.Windows.Forms.Label Lbl_Name_Res_Value;
        private System.Windows.Forms.LinkLabel Lnk_Link_Value;
        private System.Windows.Forms.Label Lbl_Origin_Res;
        private System.Windows.Forms.Label Lbl_Origin_Res_Value;
        private System.Windows.Forms.Label Lbl_Meaning_Res;
        private System.Windows.Forms.Label Lbl_Link;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox GprB_Search;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.RadioButton RdB_Female;
        private System.Windows.Forms.RadioButton RdB_Male;
        private System.Windows.Forms.TextBox TxtB_Meaning_Res_Value;
        private System.Windows.Forms.ToolStripMenuItem favoritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cacheToolStripMenuItem;
    }
}

