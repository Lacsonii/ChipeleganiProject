
namespace ChipeleganiProject
{
    partial class group
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
            this.groupname = new System.Windows.Forms.Label();
            this.adminusername = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.btnfinish = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxgroupname = new System.Windows.Forms.TextBox();
            this.txtBoxadminusername = new System.Windows.Forms.TextBox();
            this.txtBoxpassword = new System.Windows.Forms.TextBox();
            this.gname = new System.Windows.Forms.Label();
            this.labelrequest = new System.Windows.Forms.Label();
            this.labeldistrict = new System.Windows.Forms.Label();
            this.district = new System.Windows.Forms.ComboBox();
            this.gID = new System.Windows.Forms.Label();
            this.txtBoxgID = new System.Windows.Forms.TextBox();
            this.checkBoxshow = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // groupname
            // 
            this.groupname.AutoSize = true;
            this.groupname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupname.Location = new System.Drawing.Point(188, 156);
            this.groupname.Name = "groupname";
            this.groupname.Size = new System.Drawing.Size(104, 20);
            this.groupname.TabIndex = 0;
            this.groupname.Text = "Group Name:";
            // 
            // adminusername
            // 
            this.adminusername.AutoSize = true;
            this.adminusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminusername.Location = new System.Drawing.Point(188, 290);
            this.adminusername.Name = "adminusername";
            this.adminusername.Size = new System.Drawing.Size(136, 20);
            this.adminusername.TabIndex = 1;
            this.adminusername.Text = "Admin Username:";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(188, 330);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(82, 20);
            this.password.TabIndex = 2;
            this.password.Text = "Password:";
            // 
            // btnfinish
            // 
            this.btnfinish.BackColor = System.Drawing.Color.Silver;
            this.btnfinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfinish.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnfinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfinish.Location = new System.Drawing.Point(650, 435);
            this.btnfinish.Name = "btnfinish";
            this.btnfinish.Size = new System.Drawing.Size(56, 27);
            this.btnfinish.TabIndex = 4;
            this.btnfinish.Text = "Finish";
            this.btnfinish.UseVisualStyleBackColor = false;
            this.btnfinish.Click += new System.EventHandler(this.btnfinish_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Please click \'Finish\' to finalise creating your member account. Note that Admin u" +
    "sername \r\nand member username should be different.";
            // 
            // txtBoxgroupname
            // 
            this.txtBoxgroupname.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBoxgroupname.Location = new System.Drawing.Point(345, 156);
            this.txtBoxgroupname.Name = "txtBoxgroupname";
            this.txtBoxgroupname.Size = new System.Drawing.Size(233, 20);
            this.txtBoxgroupname.TabIndex = 6;
            // 
            // txtBoxadminusername
            // 
            this.txtBoxadminusername.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBoxadminusername.Location = new System.Drawing.Point(345, 290);
            this.txtBoxadminusername.Name = "txtBoxadminusername";
            this.txtBoxadminusername.Size = new System.Drawing.Size(233, 20);
            this.txtBoxadminusername.TabIndex = 7;
            // 
            // txtBoxpassword
            // 
            this.txtBoxpassword.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBoxpassword.Location = new System.Drawing.Point(345, 330);
            this.txtBoxpassword.Name = "txtBoxpassword";
            this.txtBoxpassword.Size = new System.Drawing.Size(174, 20);
            this.txtBoxpassword.TabIndex = 8;
            this.txtBoxpassword.UseSystemPasswordChar = true;
            // 
            // gname
            // 
            this.gname.AutoSize = true;
            this.gname.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gname.Location = new System.Drawing.Point(314, 63);
            this.gname.Name = "gname";
            this.gname.Size = new System.Drawing.Size(130, 25);
            this.gname.TabIndex = 10;
            this.gname.Text = "Create Group\r\n";
            // 
            // labelrequest
            // 
            this.labelrequest.AutoSize = true;
            this.labelrequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelrequest.Location = new System.Drawing.Point(159, 109);
            this.labelrequest.Name = "labelrequest";
            this.labelrequest.Size = new System.Drawing.Size(453, 17);
            this.labelrequest.TabIndex = 11;
            this.labelrequest.Text = "Make sure the group name should make sense to members and users.";
            // 
            // labeldistrict
            // 
            this.labeldistrict.AutoSize = true;
            this.labeldistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldistrict.Location = new System.Drawing.Point(188, 250);
            this.labeldistrict.Name = "labeldistrict";
            this.labeldistrict.Size = new System.Drawing.Size(62, 20);
            this.labeldistrict.TabIndex = 12;
            this.labeldistrict.Text = "District:";
            // 
            // district
            // 
            this.district.BackColor = System.Drawing.SystemColors.Menu;
            this.district.FormattingEnabled = true;
            this.district.Location = new System.Drawing.Point(345, 249);
            this.district.Name = "district";
            this.district.Size = new System.Drawing.Size(138, 21);
            this.district.TabIndex = 13;
            // 
            // gID
            // 
            this.gID.AutoSize = true;
            this.gID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gID.Location = new System.Drawing.Point(188, 196);
            this.gID.Name = "gID";
            this.gID.Size = new System.Drawing.Size(79, 20);
            this.gID.TabIndex = 14;
            this.gID.Text = "Group ID:";
            // 
            // txtBoxgID
            // 
            this.txtBoxgID.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBoxgID.Location = new System.Drawing.Point(345, 196);
            this.txtBoxgID.Name = "txtBoxgID";
            this.txtBoxgID.Size = new System.Drawing.Size(138, 20);
            this.txtBoxgID.TabIndex = 15;
            // 
            // checkBoxshow
            // 
            this.checkBoxshow.AutoSize = true;
            this.checkBoxshow.Location = new System.Drawing.Point(525, 330);
            this.checkBoxshow.Name = "checkBoxshow";
            this.checkBoxshow.Size = new System.Drawing.Size(101, 17);
            this.checkBoxshow.TabIndex = 16;
            this.checkBoxshow.Text = "Show password";
            this.checkBoxshow.UseVisualStyleBackColor = true;
            this.checkBoxshow.CheckedChanged += new System.EventHandler(this.checkBoxshow_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "(Contains digits and letters of not less than 7)";
            // 
            // line
            // 
            this.line.AutoSize = true;
            this.line.Location = new System.Drawing.Point(59, 18);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(657, 13);
            this.line.TabIndex = 18;
            this.line.Text = "__________________________________________________Money__________________________" +
    "___________________________";
            // 
            // group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(766, 532);
            this.Controls.Add(this.line);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxshow);
            this.Controls.Add(this.txtBoxgID);
            this.Controls.Add(this.gID);
            this.Controls.Add(this.district);
            this.Controls.Add(this.labeldistrict);
            this.Controls.Add(this.labelrequest);
            this.Controls.Add(this.gname);
            this.Controls.Add(this.txtBoxpassword);
            this.Controls.Add(this.txtBoxadminusername);
            this.Controls.Add(this.txtBoxgroupname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnfinish);
            this.Controls.Add(this.password);
            this.Controls.Add(this.adminusername);
            this.Controls.Add(this.groupname);
            this.Name = "group";
            this.Text = "Create_Group";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label groupname;
        private System.Windows.Forms.Label adminusername;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button btnfinish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxgroupname;
        private System.Windows.Forms.TextBox txtBoxadminusername;
        private System.Windows.Forms.TextBox txtBoxpassword;
        private System.Windows.Forms.Label gname;
        private System.Windows.Forms.Label labelrequest;
        private System.Windows.Forms.Label labeldistrict;
        private System.Windows.Forms.ComboBox district;
        private System.Windows.Forms.Label gID;
        private System.Windows.Forms.TextBox txtBoxgID;
        private System.Windows.Forms.CheckBox checkBoxshow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label line;
    }
}