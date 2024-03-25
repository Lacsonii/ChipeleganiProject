
namespace ChipeleganiProject
{
    partial class paymentForm
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
            this.btnaddpayment = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.labelapf = new System.Windows.Forms.Label();
            this.labelusername = new System.Windows.Forms.Label();
            this.labelamntpaid = new System.Windows.Forms.Label();
            this.labelreference = new System.Windows.Forms.Label();
            this.labelbalance = new System.Windows.Forms.Label();
            this.txtBoxpaidAmount = new System.Windows.Forms.TextBox();
            this.txtBoxReference = new System.Windows.Forms.TextBox();
            this.txtBoxBalance = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.memberUsername = new System.Windows.Forms.ComboBox();
            this.labelmwk = new System.Windows.Forms.Label();
            this.labelmk = new System.Windows.Forms.Label();
            this.labelfullname = new System.Windows.Forms.Label();
            this.txtBoxfullname = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.mwk = new System.Windows.Forms.Label();
            this.txtBoxchA = new System.Windows.Forms.TextBox();
            this.labelchA = new System.Windows.Forms.Label();
            this.btnRiminder = new System.Windows.Forms.Button();
            this.line = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnaddpayment
            // 
            this.btnaddpayment.BackColor = System.Drawing.Color.Gold;
            this.btnaddpayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddpayment.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnaddpayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddpayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddpayment.Location = new System.Drawing.Point(465, 424);
            this.btnaddpayment.Name = "btnaddpayment";
            this.btnaddpayment.Size = new System.Drawing.Size(100, 27);
            this.btnaddpayment.TabIndex = 0;
            this.btnaddpayment.Text = "Add Payment";
            this.btnaddpayment.UseVisualStyleBackColor = false;
            this.btnaddpayment.Click += new System.EventHandler(this.btnaddpayment_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Gold;
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(571, 424);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(63, 27);
            this.btnupdate.TabIndex = 0;
            this.btnupdate.Text = "Update\r\n";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // labelapf
            // 
            this.labelapf.AutoSize = true;
            this.labelapf.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelapf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelapf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelapf.Location = new System.Drawing.Point(230, 64);
            this.labelapf.Name = "labelapf";
            this.labelapf.Size = new System.Drawing.Size(323, 25);
            this.labelapf.TabIndex = 1;
            this.labelapf.Text = "Add and Update Member Payments";
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusername.Location = new System.Drawing.Point(162, 146);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(87, 20);
            this.labelusername.TabIndex = 2;
            this.labelusername.Text = "Username:";
            // 
            // labelamntpaid
            // 
            this.labelamntpaid.AutoSize = true;
            this.labelamntpaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelamntpaid.Location = new System.Drawing.Point(162, 272);
            this.labelamntpaid.Name = "labelamntpaid";
            this.labelamntpaid.Size = new System.Drawing.Size(103, 20);
            this.labelamntpaid.TabIndex = 2;
            this.labelamntpaid.Text = "Amount paid:";
            // 
            // labelreference
            // 
            this.labelreference.AutoSize = true;
            this.labelreference.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelreference.Location = new System.Drawing.Point(162, 314);
            this.labelreference.Name = "labelreference";
            this.labelreference.Size = new System.Drawing.Size(88, 20);
            this.labelreference.TabIndex = 2;
            this.labelreference.Text = "Reference:";
            // 
            // labelbalance
            // 
            this.labelbalance.AutoSize = true;
            this.labelbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbalance.Location = new System.Drawing.Point(162, 356);
            this.labelbalance.Name = "labelbalance";
            this.labelbalance.Size = new System.Drawing.Size(71, 20);
            this.labelbalance.TabIndex = 2;
            this.labelbalance.Text = "Balance:";
            // 
            // txtBoxpaidAmount
            // 
            this.txtBoxpaidAmount.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBoxpaidAmount.Location = new System.Drawing.Point(362, 272);
            this.txtBoxpaidAmount.Name = "txtBoxpaidAmount";
            this.txtBoxpaidAmount.Size = new System.Drawing.Size(126, 20);
            this.txtBoxpaidAmount.TabIndex = 3;
            // 
            // txtBoxReference
            // 
            this.txtBoxReference.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBoxReference.Location = new System.Drawing.Point(362, 314);
            this.txtBoxReference.Name = "txtBoxReference";
            this.txtBoxReference.Size = new System.Drawing.Size(177, 20);
            this.txtBoxReference.TabIndex = 3;
            // 
            // txtBoxBalance
            // 
            this.txtBoxBalance.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBoxBalance.Location = new System.Drawing.Point(362, 356);
            this.txtBoxBalance.Name = "txtBoxBalance";
            this.txtBoxBalance.Size = new System.Drawing.Size(126, 20);
            this.txtBoxBalance.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(12, 38);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(35, 23);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // memberUsername
            // 
            this.memberUsername.BackColor = System.Drawing.SystemColors.Menu;
            this.memberUsername.FormattingEnabled = true;
            this.memberUsername.Location = new System.Drawing.Point(362, 146);
            this.memberUsername.Name = "memberUsername";
            this.memberUsername.Size = new System.Drawing.Size(262, 21);
            this.memberUsername.TabIndex = 23;
            this.memberUsername.SelectedIndexChanged += new System.EventHandler(this.memberUsername_SelectedIndexChanged_1);
            // 
            // labelmwk
            // 
            this.labelmwk.AutoSize = true;
            this.labelmwk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmwk.Location = new System.Drawing.Point(494, 273);
            this.labelmwk.Name = "labelmwk";
            this.labelmwk.Size = new System.Drawing.Size(45, 17);
            this.labelmwk.TabIndex = 29;
            this.labelmwk.Text = "(mwk)";
            // 
            // labelmk
            // 
            this.labelmk.AutoSize = true;
            this.labelmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmk.Location = new System.Drawing.Point(494, 359);
            this.labelmk.Name = "labelmk";
            this.labelmk.Size = new System.Drawing.Size(45, 17);
            this.labelmk.TabIndex = 30;
            this.labelmk.Text = "(mwk)";
            // 
            // labelfullname
            // 
            this.labelfullname.AutoSize = true;
            this.labelfullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfullname.Location = new System.Drawing.Point(162, 188);
            this.labelfullname.Name = "labelfullname";
            this.labelfullname.Size = new System.Drawing.Size(84, 20);
            this.labelfullname.TabIndex = 32;
            this.labelfullname.Text = "Full Name:";
            // 
            // txtBoxfullname
            // 
            this.txtBoxfullname.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBoxfullname.Location = new System.Drawing.Point(362, 188);
            this.txtBoxfullname.Name = "txtBoxfullname";
            this.txtBoxfullname.Size = new System.Drawing.Size(229, 20);
            this.txtBoxfullname.TabIndex = 33;
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
            this.btnRefresh.Location = new System.Drawing.Point(53, 26);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(39, 46);
            this.btnRefresh.TabIndex = 59;
            this.btnRefresh.Text = "⟳";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // mwk
            // 
            this.mwk.AutoSize = true;
            this.mwk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mwk.Location = new System.Drawing.Point(494, 231);
            this.mwk.Name = "mwk";
            this.mwk.Size = new System.Drawing.Size(45, 17);
            this.mwk.TabIndex = 61;
            this.mwk.Text = "(mwk)";
            // 
            // txtBoxchA
            // 
            this.txtBoxchA.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBoxchA.Location = new System.Drawing.Point(362, 230);
            this.txtBoxchA.Name = "txtBoxchA";
            this.txtBoxchA.Size = new System.Drawing.Size(126, 20);
            this.txtBoxchA.TabIndex = 60;
            // 
            // labelchA
            // 
            this.labelchA.AutoSize = true;
            this.labelchA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelchA.Location = new System.Drawing.Point(162, 230);
            this.labelchA.Name = "labelchA";
            this.labelchA.Size = new System.Drawing.Size(169, 20);
            this.labelchA.TabIndex = 62;
            this.labelchA.Text = "Chipeleganyu Amount:";
            // 
            // btnRiminder
            // 
            this.btnRiminder.BackColor = System.Drawing.Color.Gold;
            this.btnRiminder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRiminder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRiminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRiminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRiminder.Location = new System.Drawing.Point(166, 424);
            this.btnRiminder.Name = "btnRiminder";
            this.btnRiminder.Size = new System.Drawing.Size(161, 27);
            this.btnRiminder.TabIndex = 63;
            this.btnRiminder.Text = "Arrange Recievers";
            this.btnRiminder.UseVisualStyleBackColor = false;
            this.btnRiminder.Click += new System.EventHandler(this.btnRiminder_Click);
            // 
            // line
            // 
            this.line.AutoSize = true;
            this.line.Location = new System.Drawing.Point(50, 9);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(657, 13);
            this.line.TabIndex = 64;
            this.line.Text = "__________________________________________________Money__________________________" +
    "___________________________";
            // 
            // paymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.line);
            this.Controls.Add(this.btnRiminder);
            this.Controls.Add(this.labelchA);
            this.Controls.Add(this.mwk);
            this.Controls.Add(this.txtBoxchA);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtBoxfullname);
            this.Controls.Add(this.labelfullname);
            this.Controls.Add(this.labelmk);
            this.Controls.Add(this.labelmwk);
            this.Controls.Add(this.memberUsername);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtBoxBalance);
            this.Controls.Add(this.txtBoxReference);
            this.Controls.Add(this.txtBoxpaidAmount);
            this.Controls.Add(this.labelbalance);
            this.Controls.Add(this.labelreference);
            this.Controls.Add(this.labelamntpaid);
            this.Controls.Add(this.labelusername);
            this.Controls.Add(this.labelapf);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnaddpayment);
            this.Name = "paymentForm";
            this.Load += new System.EventHandler(this.paymentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaddpayment;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label labelapf;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.Label labelamntpaid;
        private System.Windows.Forms.Label labelreference;
        private System.Windows.Forms.Label labelbalance;
        private System.Windows.Forms.TextBox txtBoxpaidAmount;
        private System.Windows.Forms.TextBox txtBoxReference;
        private System.Windows.Forms.TextBox txtBoxBalance;
        private System.Windows.Forms.ComboBox memberUsername;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label labelmwk;
        private System.Windows.Forms.Label labelmk;
        private System.Windows.Forms.Label labelfullname;
        private System.Windows.Forms.TextBox txtBoxfullname;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label mwk;
        private System.Windows.Forms.TextBox txtBoxchA;
        private System.Windows.Forms.Label labelchA;
        private System.Windows.Forms.Button btnRiminder;
        private System.Windows.Forms.Label line;
    }
}