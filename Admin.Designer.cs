
namespace ChipeleganiProject
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.addpayment = new System.Windows.Forms.Button();
            this.txtBoxtotalAmount = new System.Windows.Forms.TextBox();
            this.labeltotalMAmount = new System.Windows.Forms.Label();
            this.labelmemberRecv = new System.Windows.Forms.Label();
            this.mRcvng = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Admingv = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.btnmList = new System.Windows.Forms.Button();
            this.labelmwk = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.memberlist = new System.Windows.Forms.DataGridView();
            this.labelmonth = new System.Windows.Forms.Label();
            this.labelest = new System.Windows.Forms.Label();
            this.txtBoxactual = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbmonths = new System.Windows.Forms.ComboBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAcc = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.PictureBox();
            this.profile = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.PictureBox();
            this.line = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Admingv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            this.SuspendLayout();
            // 
            // addpayment
            // 
            this.addpayment.BackColor = System.Drawing.Color.Gold;
            this.addpayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addpayment.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addpayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addpayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addpayment.Location = new System.Drawing.Point(774, 397);
            this.addpayment.Name = "addpayment";
            this.addpayment.Size = new System.Drawing.Size(75, 33);
            this.addpayment.TabIndex = 19;
            this.addpayment.Text = "Payment";
            this.addpayment.UseVisualStyleBackColor = false;
            this.addpayment.Click += new System.EventHandler(this.addpayment_Click);
            // 
            // txtBoxtotalAmount
            // 
            this.txtBoxtotalAmount.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBoxtotalAmount.Location = new System.Drawing.Point(144, 432);
            this.txtBoxtotalAmount.Name = "txtBoxtotalAmount";
            this.txtBoxtotalAmount.ReadOnly = true;
            this.txtBoxtotalAmount.Size = new System.Drawing.Size(88, 20);
            this.txtBoxtotalAmount.TabIndex = 18;
            // 
            // labeltotalMAmount
            // 
            this.labeltotalMAmount.AutoSize = true;
            this.labeltotalMAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltotalMAmount.Location = new System.Drawing.Point(32, 432);
            this.labeltotalMAmount.Name = "labeltotalMAmount";
            this.labeltotalMAmount.Size = new System.Drawing.Size(106, 20);
            this.labeltotalMAmount.TabIndex = 17;
            this.labeltotalMAmount.Text = "Total amount:\r\n";
            // 
            // labelmemberRecv
            // 
            this.labelmemberRecv.AutoSize = true;
            this.labelmemberRecv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmemberRecv.Location = new System.Drawing.Point(310, 398);
            this.labelmemberRecv.Name = "labelmemberRecv";
            this.labelmemberRecv.Size = new System.Drawing.Size(137, 20);
            this.labelmemberRecv.TabIndex = 16;
            this.labelmemberRecv.Text = "Member receiving:";
            // 
            // mRcvng
            // 
            this.mRcvng.BackColor = System.Drawing.SystemColors.Menu;
            this.mRcvng.Location = new System.Drawing.Point(453, 398);
            this.mRcvng.Name = "mRcvng";
            this.mRcvng.ReadOnly = true;
            this.mRcvng.Size = new System.Drawing.Size(170, 20);
            this.mRcvng.TabIndex = 15;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Marlett", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(36, 108);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Marlett", 8.95F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(586, 106);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.search.Location = new System.Drawing.Point(438, 108);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(154, 20);
            this.search.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "List of paid members and Chipeleganyu members";
            // 
            // Admingv
            // 
            this.Admingv.BackgroundColor = System.Drawing.Color.White;
            this.Admingv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Admingv.Location = new System.Drawing.Point(36, 134);
            this.Admingv.Name = "Admingv";
            this.Admingv.Size = new System.Drawing.Size(625, 257);
            this.Admingv.TabIndex = 10;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(12, 33);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(35, 23);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Username:";
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.SystemColors.Menu;
            this.userName.Location = new System.Drawing.Point(403, 432);
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            this.userName.Size = new System.Drawing.Size(143, 20);
            this.userName.TabIndex = 15;
            // 
            // btnmList
            // 
            this.btnmList.BackColor = System.Drawing.Color.Gold;
            this.btnmList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmList.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnmList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmList.Location = new System.Drawing.Point(685, 397);
            this.btnmList.Name = "btnmList";
            this.btnmList.Size = new System.Drawing.Size(83, 33);
            this.btnmList.TabIndex = 23;
            this.btnmList.Text = "Members";
            this.btnmList.UseVisualStyleBackColor = false;
            this.btnmList.Click += new System.EventHandler(this.btnmList_Click);
            // 
            // labelmwk
            // 
            this.labelmwk.AutoSize = true;
            this.labelmwk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmwk.Location = new System.Drawing.Point(238, 435);
            this.labelmwk.Name = "labelmwk";
            this.labelmwk.Size = new System.Drawing.Size(41, 15);
            this.labelmwk.TabIndex = 24;
            this.labelmwk.Text = "(mwk)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(681, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "List Of Members";
            // 
            // memberlist
            // 
            this.memberlist.BackgroundColor = System.Drawing.Color.White;
            this.memberlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberlist.Location = new System.Drawing.Point(667, 134);
            this.memberlist.Name = "memberlist";
            this.memberlist.Size = new System.Drawing.Size(182, 257);
            this.memberlist.TabIndex = 25;
            // 
            // labelmonth
            // 
            this.labelmonth.AutoSize = true;
            this.labelmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmonth.Location = new System.Drawing.Point(32, 397);
            this.labelmonth.Name = "labelmonth";
            this.labelmonth.Size = new System.Drawing.Size(58, 20);
            this.labelmonth.TabIndex = 16;
            this.labelmonth.Text = "Month:";
            // 
            // labelest
            // 
            this.labelest.AutoSize = true;
            this.labelest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelest.Location = new System.Drawing.Point(32, 467);
            this.labelest.Name = "labelest";
            this.labelest.Size = new System.Drawing.Size(118, 20);
            this.labelest.TabIndex = 17;
            this.labelest.Text = "Actual Amount:\r\n";
            // 
            // txtBoxactual
            // 
            this.txtBoxactual.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBoxactual.Location = new System.Drawing.Point(156, 467);
            this.txtBoxactual.Name = "txtBoxactual";
            this.txtBoxactual.ReadOnly = true;
            this.txtBoxactual.Size = new System.Drawing.Size(88, 20);
            this.txtBoxactual.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(250, 468);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "(mwk)";
            // 
            // cbbmonths
            // 
            this.cbbmonths.BackColor = System.Drawing.SystemColors.Menu;
            this.cbbmonths.FormattingEnabled = true;
            this.cbbmonths.Location = new System.Drawing.Point(123, 397);
            this.cbbmonths.Name = "cbbmonths";
            this.cbbmonths.Size = new System.Drawing.Size(121, 21);
            this.cbbmonths.TabIndex = 27;
            this.cbbmonths.SelectedIndexChanged += new System.EventHandler(this.cbbmonths_SelectedIndexChanged_1);
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Menu;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(786, 463);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(60, 26);
            this.btnLogout.TabIndex = 56;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAcc
            // 
            this.btnAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAcc.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Menu;
            this.btnAcc.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu;
            this.btnAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcc.Location = new System.Drawing.Point(771, 51);
            this.btnAcc.Name = "btnAcc";
            this.btnAcc.Size = new System.Drawing.Size(60, 27);
            this.btnAcc.TabIndex = 59;
            this.btnAcc.Text = "Account";
            this.btnAcc.UseVisualStyleBackColor = true;
            this.btnAcc.Click += new System.EventHandler(this.btnAcc_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Menu;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Location = new System.Drawing.Point(683, 464);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(61, 28);
            this.btnSettings.TabIndex = 63;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // settings
            // 
            this.settings.Image = ((System.Drawing.Image)(resources.GetObject("settings.Image")));
            this.settings.Location = new System.Drawing.Point(649, 464);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(30, 28);
            this.settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settings.TabIndex = 62;
            this.settings.TabStop = false;
            // 
            // profile
            // 
            this.profile.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.profile.Image = global::ChipeleganiProject.Properties.Resources.images_removebg_preview;
            this.profile.Location = new System.Drawing.Point(725, 30);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(40, 28);
            this.profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profile.TabIndex = 58;
            this.profile.TabStop = false;
            // 
            // logout
            // 
            this.logout.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.Location = new System.Drawing.Point(750, 464);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(30, 28);
            this.logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logout.TabIndex = 57;
            this.logout.TabStop = false;
            // 
            // line
            // 
            this.line.AutoSize = true;
            this.line.Location = new System.Drawing.Point(111, 9);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(657, 13);
            this.line.TabIndex = 64;
            this.line.Text = "__________________________________________________Money__________________________" +
    "___________________________";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(876, 499);
            this.Controls.Add(this.line);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.btnAcc);
            this.Controls.Add(this.profile);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.cbbmonths);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.memberlist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelmwk);
            this.Controls.Add(this.btnmList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.addpayment);
            this.Controls.Add(this.txtBoxactual);
            this.Controls.Add(this.txtBoxtotalAmount);
            this.Controls.Add(this.labelest);
            this.Controls.Add(this.labeltotalMAmount);
            this.Controls.Add(this.labelmonth);
            this.Controls.Add(this.labelmemberRecv);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.mRcvng);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Admingv);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Admingv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addpayment;
        private System.Windows.Forms.TextBox txtBoxtotalAmount;
        private System.Windows.Forms.Label labeltotalMAmount;
        private System.Windows.Forms.Label labelmemberRecv;
        private System.Windows.Forms.TextBox mRcvng;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Admingv;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Button btnmList;
        private System.Windows.Forms.Label labelmwk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView memberlist;
        private System.Windows.Forms.Label labelmonth;
        private System.Windows.Forms.Label labelest;
        private System.Windows.Forms.TextBox txtBoxactual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbmonths;
        private System.Windows.Forms.PictureBox logout;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAcc;
        private System.Windows.Forms.PictureBox profile;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.PictureBox settings;
        private System.Windows.Forms.Label line;
    }
}