
namespace ChipeleganiProject
{
    partial class List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List));
            this.listView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.makepayment = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.memberlist = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbmonths = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxactual = new System.Windows.Forms.TextBox();
            this.txtBoxtotalAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.labeltotalMAmount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelmemberRecv = new System.Windows.Forms.Label();
            this.txtBoxusername = new System.Windows.Forms.TextBox();
            this.txtBoxmrcvng = new System.Windows.Forms.TextBox();
            this.btnAcc = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.PictureBox();
            this.profile = new System.Windows.Forms.PictureBox();
            this.settings = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.line = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).BeginInit();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.BackgroundColor = System.Drawing.Color.White;
            this.listView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listView.Location = new System.Drawing.Point(39, 160);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(625, 257);
            this.listView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of paid members and Chipeleganyu members";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.search.Location = new System.Drawing.Point(439, 134);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(154, 20);
            this.search.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Marlett", 8.95F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(587, 132);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Marlett", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(39, 134);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // makepayment
            // 
            this.makepayment.BackColor = System.Drawing.Color.Gold;
            this.makepayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.makepayment.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.makepayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.makepayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makepayment.Location = new System.Drawing.Point(717, 423);
            this.makepayment.Name = "makepayment";
            this.makepayment.Size = new System.Drawing.Size(131, 35);
            this.makepayment.TabIndex = 9;
            this.makepayment.Text = "Make Payment";
            this.makepayment.UseVisualStyleBackColor = false;
            this.makepayment.Click += new System.EventHandler(this.makepayment_Click);
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(9, 51);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(35, 23);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // memberlist
            // 
            this.memberlist.BackgroundColor = System.Drawing.Color.White;
            this.memberlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberlist.Location = new System.Drawing.Point(670, 160);
            this.memberlist.Name = "memberlist";
            this.memberlist.Size = new System.Drawing.Size(178, 257);
            this.memberlist.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(684, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "List Of Members";
            // 
            // cbbmonths
            // 
            this.cbbmonths.BackColor = System.Drawing.SystemColors.Menu;
            this.cbbmonths.FormattingEnabled = true;
            this.cbbmonths.Location = new System.Drawing.Point(99, 423);
            this.cbbmonths.Name = "cbbmonths";
            this.cbbmonths.Size = new System.Drawing.Size(130, 21);
            this.cbbmonths.TabIndex = 51;
            this.cbbmonths.SelectedIndexChanged += new System.EventHandler(this.cbbmonths_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(253, 490);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 49;
            this.label7.Text = "(mwk)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(241, 461);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 50;
            this.label8.Text = "(mwk)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(313, 460);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 48;
            this.label9.Text = "Username:";
            // 
            // txtBoxactual
            // 
            this.txtBoxactual.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBoxactual.Location = new System.Drawing.Point(159, 489);
            this.txtBoxactual.Name = "txtBoxactual";
            this.txtBoxactual.ReadOnly = true;
            this.txtBoxactual.Size = new System.Drawing.Size(88, 20);
            this.txtBoxactual.TabIndex = 46;
            // 
            // txtBoxtotalAmount
            // 
            this.txtBoxtotalAmount.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBoxtotalAmount.Location = new System.Drawing.Point(147, 458);
            this.txtBoxtotalAmount.Name = "txtBoxtotalAmount";
            this.txtBoxtotalAmount.ReadOnly = true;
            this.txtBoxtotalAmount.Size = new System.Drawing.Size(88, 20);
            this.txtBoxtotalAmount.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 489);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 20);
            this.label10.TabIndex = 44;
            this.label10.Text = "Actual Amount:\r\n";
            // 
            // labeltotalMAmount
            // 
            this.labeltotalMAmount.AutoSize = true;
            this.labeltotalMAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltotalMAmount.Location = new System.Drawing.Point(35, 458);
            this.labeltotalMAmount.Name = "labeltotalMAmount";
            this.labeltotalMAmount.Size = new System.Drawing.Size(106, 20);
            this.labeltotalMAmount.TabIndex = 45;
            this.labeltotalMAmount.Text = "Total amount:\r\n";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(35, 423);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 20);
            this.label11.TabIndex = 42;
            this.label11.Text = "Month:";
            // 
            // labelmemberRecv
            // 
            this.labelmemberRecv.AutoSize = true;
            this.labelmemberRecv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmemberRecv.Location = new System.Drawing.Point(313, 424);
            this.labelmemberRecv.Name = "labelmemberRecv";
            this.labelmemberRecv.Size = new System.Drawing.Size(137, 20);
            this.labelmemberRecv.TabIndex = 43;
            this.labelmemberRecv.Text = "Member receiving:";
            // 
            // txtBoxusername
            // 
            this.txtBoxusername.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBoxusername.Location = new System.Drawing.Point(406, 458);
            this.txtBoxusername.Name = "txtBoxusername";
            this.txtBoxusername.ReadOnly = true;
            this.txtBoxusername.Size = new System.Drawing.Size(143, 20);
            this.txtBoxusername.TabIndex = 40;
            // 
            // txtBoxmrcvng
            // 
            this.txtBoxmrcvng.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBoxmrcvng.Location = new System.Drawing.Point(456, 424);
            this.txtBoxmrcvng.Name = "txtBoxmrcvng";
            this.txtBoxmrcvng.ReadOnly = true;
            this.txtBoxmrcvng.Size = new System.Drawing.Size(170, 20);
            this.txtBoxmrcvng.TabIndex = 41;
            // 
            // btnAcc
            // 
            this.btnAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAcc.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Menu;
            this.btnAcc.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu;
            this.btnAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcc.Location = new System.Drawing.Point(764, 76);
            this.btnAcc.Name = "btnAcc";
            this.btnAcc.Size = new System.Drawing.Size(60, 26);
            this.btnAcc.TabIndex = 53;
            this.btnAcc.Text = "Account";
            this.btnAcc.UseVisualStyleBackColor = true;
            this.btnAcc.Click += new System.EventHandler(this.btnAcc_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Menu;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(791, 490);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(60, 26);
            this.btnLogout.TabIndex = 54;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // logout
            // 
            this.logout.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.Location = new System.Drawing.Point(755, 490);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(30, 28);
            this.logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logout.TabIndex = 55;
            this.logout.TabStop = false;
            // 
            // profile
            // 
            this.profile.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.profile.Image = global::ChipeleganiProject.Properties.Resources.images_removebg_preview;
            this.profile.Location = new System.Drawing.Point(718, 76);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(40, 28);
            this.profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profile.TabIndex = 52;
            this.profile.TabStop = false;
            // 
            // settings
            // 
            this.settings.Image = ((System.Drawing.Image)(resources.GetObject("settings.Image")));
            this.settings.Location = new System.Drawing.Point(656, 490);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(30, 28);
            this.settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settings.TabIndex = 56;
            this.settings.TabStop = false;
            // 
            // btnSettings
            // 
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Menu;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Location = new System.Drawing.Point(688, 490);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(61, 28);
            this.btnSettings.TabIndex = 57;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // line
            // 
            this.line.AutoSize = true;
            this.line.Location = new System.Drawing.Point(101, 9);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(657, 13);
            this.line.TabIndex = 58;
            this.line.Text = "__________________________________________________Money__________________________" +
    "___________________________";
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(876, 534);
            this.Controls.Add(this.line);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAcc);
            this.Controls.Add(this.profile);
            this.Controls.Add(this.cbbmonths);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBoxactual);
            this.Controls.Add(this.txtBoxtotalAmount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labeltotalMAmount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelmemberRecv);
            this.Controls.Add(this.txtBoxusername);
            this.Controls.Add(this.txtBoxmrcvng);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.memberlist);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.makepayment);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "List";
            this.Text = "List of Members";
            this.Load += new System.EventHandler(this.List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button makepayment;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView memberlist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbmonths;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxactual;
        private System.Windows.Forms.TextBox txtBoxtotalAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labeltotalMAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelmemberRecv;
        private System.Windows.Forms.TextBox txtBoxusername;
        private System.Windows.Forms.TextBox txtBoxmrcvng;
        private System.Windows.Forms.PictureBox profile;
        private System.Windows.Forms.Button btnAcc;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox logout;
        private System.Windows.Forms.PictureBox settings;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label line;
    }
}