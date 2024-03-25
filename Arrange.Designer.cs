
namespace ChipeleganiProject
{
    partial class Arrange
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
            this.labelmont = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.labelguide = new System.Windows.Forms.Label();
            this.labelfullname = new System.Windows.Forms.Label();
            this.labelusername = new System.Windows.Forms.Label();
            this.labelmonth = new System.Windows.Forms.Label();
            this.txtBoxfullname = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.ComboBox();
            this.month = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelmont
            // 
            this.labelmont.AutoSize = true;
            this.labelmont.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelmont.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmont.Location = new System.Drawing.Point(203, 63);
            this.labelmont.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelmont.Name = "labelmont";
            this.labelmont.Size = new System.Drawing.Size(389, 25);
            this.labelmont.TabIndex = 0;
            this.labelmont.Text = "Members and their Money Receiving Month\r\n";
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(15, 49);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 26);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // labelguide
            // 
            this.labelguide.AutoSize = true;
            this.labelguide.BackColor = System.Drawing.Color.Gold;
            this.labelguide.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelguide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelguide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelguide.Location = new System.Drawing.Point(136, 116);
            this.labelguide.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelguide.Name = "labelguide";
            this.labelguide.Size = new System.Drawing.Size(516, 42);
            this.labelguide.TabIndex = 13;
            this.labelguide.Text = "Please admin add  member username and the month they are receiving \r\n            " +
    "        money, it should be based on the group\'s agreement.";
            // 
            // labelfullname
            // 
            this.labelfullname.AutoSize = true;
            this.labelfullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfullname.Location = new System.Drawing.Point(204, 256);
            this.labelfullname.Name = "labelfullname";
            this.labelfullname.Size = new System.Drawing.Size(84, 20);
            this.labelfullname.TabIndex = 14;
            this.labelfullname.Text = "Full Name:";
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusername.Location = new System.Drawing.Point(204, 206);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(87, 20);
            this.labelusername.TabIndex = 15;
            this.labelusername.Text = "Username:";
            // 
            // labelmonth
            // 
            this.labelmonth.AutoSize = true;
            this.labelmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmonth.Location = new System.Drawing.Point(204, 306);
            this.labelmonth.Name = "labelmonth";
            this.labelmonth.Size = new System.Drawing.Size(58, 20);
            this.labelmonth.TabIndex = 16;
            this.labelmonth.Text = "Month:";
            // 
            // txtBoxfullname
            // 
            this.txtBoxfullname.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBoxfullname.Location = new System.Drawing.Point(330, 255);
            this.txtBoxfullname.Name = "txtBoxfullname";
            this.txtBoxfullname.ReadOnly = true;
            this.txtBoxfullname.Size = new System.Drawing.Size(197, 21);
            this.txtBoxfullname.TabIndex = 17;
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.SystemColors.Menu;
            this.username.FormattingEnabled = true;
            this.username.Location = new System.Drawing.Point(330, 203);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(167, 23);
            this.username.TabIndex = 18;
            this.username.SelectedIndexChanged += new System.EventHandler(this.username_SelectedIndexChanged);
            // 
            // month
            // 
            this.month.BackColor = System.Drawing.SystemColors.Menu;
            this.month.FormattingEnabled = true;
            this.month.Location = new System.Drawing.Point(330, 303);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(135, 23);
            this.month.TabIndex = 19;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Menu;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(420, 368);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 31);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add Member";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(120, 433);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Admin must not add member details in their favour, failure to cooperate rules may" +
    " be applied.";
            // 
            // line
            // 
            this.line.AutoSize = true;
            this.line.Location = new System.Drawing.Point(12, 18);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(765, 15);
            this.line.TabIndex = 22;
            this.line.Text = "__________________________________________________Money__________________________" +
    "___________________________";
            // 
            // Arrange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(795, 465);
            this.Controls.Add(this.line);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.month);
            this.Controls.Add(this.username);
            this.Controls.Add(this.txtBoxfullname);
            this.Controls.Add(this.labelmonth);
            this.Controls.Add(this.labelusername);
            this.Controls.Add(this.labelfullname);
            this.Controls.Add(this.labelguide);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.labelmont);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Arrange";
            this.Text = "Arrange";
            this.Load += new System.EventHandler(this.Arrange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelmont;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label labelguide;
        private System.Windows.Forms.Label labelfullname;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.Label labelmonth;
        private System.Windows.Forms.TextBox txtBoxfullname;
        private System.Windows.Forms.ComboBox username;
        private System.Windows.Forms.ComboBox month;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label line;
    }
}