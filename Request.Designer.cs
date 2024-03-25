
namespace ChipeleganiProject
{
    partial class Request
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
            this.btnSend = new System.Windows.Forms.Button();
            this.labelrequest = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.labelphone = new System.Windows.Forms.Label();
            this.labelphone2 = new System.Windows.Forms.Label();
            this.txtBoxphone = new System.Windows.Forms.TextBox();
            this.txtBoxphone2 = new System.Windows.Forms.TextBox();
            this.txtBoxsms = new System.Windows.Forms.TextBox();
            this.labelsms = new System.Windows.Forms.Label();
            this.txtBoxsmsch = new System.Windows.Forms.TextBox();
            this.btnsendch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cbbusername = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.line = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Gold;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(479, 356);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(56, 30);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // labelrequest
            // 
            this.labelrequest.AutoSize = true;
            this.labelrequest.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelrequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelrequest.Location = new System.Drawing.Point(291, 52);
            this.labelrequest.Name = "labelrequest";
            this.labelrequest.Size = new System.Drawing.Size(166, 25);
            this.labelrequest.TabIndex = 1;
            this.labelrequest.Text = "Request Payment";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.Location = new System.Drawing.Point(152, 126);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(87, 20);
            this.labelname.TabIndex = 2;
            this.labelname.Text = "Username:";
            // 
            // labelphone
            // 
            this.labelphone.AutoSize = true;
            this.labelphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelphone.Location = new System.Drawing.Point(152, 168);
            this.labelphone.Name = "labelphone";
            this.labelphone.Size = new System.Drawing.Size(59, 20);
            this.labelphone.TabIndex = 3;
            this.labelphone.Text = "Phone:";
            // 
            // labelphone2
            // 
            this.labelphone2.AutoSize = true;
            this.labelphone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelphone2.Location = new System.Drawing.Point(152, 214);
            this.labelphone2.Name = "labelphone2";
            this.labelphone2.Size = new System.Drawing.Size(72, 20);
            this.labelphone2.TabIndex = 4;
            this.labelphone2.Text = "Phone 2:";
            // 
            // txtBoxphone
            // 
            this.txtBoxphone.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBoxphone.Location = new System.Drawing.Point(296, 170);
            this.txtBoxphone.Name = "txtBoxphone";
            this.txtBoxphone.Size = new System.Drawing.Size(183, 20);
            this.txtBoxphone.TabIndex = 5;
            // 
            // txtBoxphone2
            // 
            this.txtBoxphone2.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBoxphone2.Location = new System.Drawing.Point(296, 214);
            this.txtBoxphone2.Name = "txtBoxphone2";
            this.txtBoxphone2.Size = new System.Drawing.Size(183, 20);
            this.txtBoxphone2.TabIndex = 5;
            // 
            // txtBoxsms
            // 
            this.txtBoxsms.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBoxsms.Location = new System.Drawing.Point(296, 256);
            this.txtBoxsms.Multiline = true;
            this.txtBoxsms.Name = "txtBoxsms";
            this.txtBoxsms.ReadOnly = true;
            this.txtBoxsms.Size = new System.Drawing.Size(239, 94);
            this.txtBoxsms.TabIndex = 5;
            this.txtBoxsms.Text = "Dear esteemed member, you are being reminded\r\nof the chipeleganyu amount which yo" +
    "u have not\r\npaid this month, please settle your balance as soon as possible.\r\n\r\n" +
    "Be happy and stay safe";
            // 
            // labelsms
            // 
            this.labelsms.AutoSize = true;
            this.labelsms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsms.Location = new System.Drawing.Point(152, 256);
            this.labelsms.Name = "labelsms";
            this.labelsms.Size = new System.Drawing.Size(78, 20);
            this.labelsms.TabIndex = 6;
            this.labelsms.Text = "Message:";
            // 
            // txtBoxsmsch
            // 
            this.txtBoxsmsch.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBoxsmsch.Location = new System.Drawing.Point(296, 401);
            this.txtBoxsmsch.Multiline = true;
            this.txtBoxsmsch.Name = "txtBoxsmsch";
            this.txtBoxsmsch.ReadOnly = true;
            this.txtBoxsmsch.Size = new System.Drawing.Size(239, 84);
            this.txtBoxsmsch.TabIndex = 7;
            this.txtBoxsmsch.Text = "Okondedwa membala, muli kukumbutsidwa za \r\nndalama yomwe simunalipire ya chipeleg" +
    "anyu ya\r\nmwezi uno. Chonde pelekani mwachangu.\r\n\r\nKhalani osangalala koma mozisa" +
    "mala";
            // 
            // btnsendch
            // 
            this.btnsendch.BackColor = System.Drawing.Color.Gold;
            this.btnsendch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsendch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnsendch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsendch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsendch.Location = new System.Drawing.Point(479, 491);
            this.btnsendch.Name = "btnsendch";
            this.btnsendch.Size = new System.Drawing.Size(56, 30);
            this.btnsendch.TabIndex = 8;
            this.btnsendch.Text = "Send";
            this.btnsendch.UseVisualStyleBackColor = false;
            this.btnsendch.Click += new System.EventHandler(this.btnsendch_Click);
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(12, 36);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(35, 23);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cbbusername
            // 
            this.cbbusername.BackColor = System.Drawing.SystemColors.Menu;
            this.cbbusername.FormattingEnabled = true;
            this.cbbusername.Location = new System.Drawing.Point(296, 125);
            this.cbbusername.Name = "cbbusername";
            this.cbbusername.Size = new System.Drawing.Size(183, 21);
            this.cbbusername.TabIndex = 12;
            this.cbbusername.SelectedIndexChanged += new System.EventHandler(this.cbbfullname_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(53, 24);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(38, 36);
            this.btnRefresh.TabIndex = 58;
            this.btnRefresh.Text = "⟳";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // line
            // 
            this.line.AutoSize = true;
            this.line.Location = new System.Drawing.Point(23, 9);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(657, 13);
            this.line.TabIndex = 59;
            this.line.Text = "__________________________________________________Money__________________________" +
    "___________________________";
            // 
            // Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(692, 525);
            this.Controls.Add(this.line);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cbbusername);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnsendch);
            this.Controls.Add(this.txtBoxsmsch);
            this.Controls.Add(this.labelsms);
            this.Controls.Add(this.txtBoxsms);
            this.Controls.Add(this.txtBoxphone2);
            this.Controls.Add(this.txtBoxphone);
            this.Controls.Add(this.labelphone2);
            this.Controls.Add(this.labelphone);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.labelrequest);
            this.Controls.Add(this.btnSend);
            this.Name = "Request";
            this.Text = "Request";
            this.Load += new System.EventHandler(this.Request_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label labelrequest;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelphone;
        private System.Windows.Forms.Label labelphone2;
        private System.Windows.Forms.TextBox txtBoxphone;
        private System.Windows.Forms.TextBox txtBoxphone2;
        private System.Windows.Forms.TextBox txtBoxsms;
        private System.Windows.Forms.Label labelsms;
        private System.Windows.Forms.TextBox txtBoxsmsch;
        private System.Windows.Forms.Button btnsendch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cbbusername;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label line;
    }
}