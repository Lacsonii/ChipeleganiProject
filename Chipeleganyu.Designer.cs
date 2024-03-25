
namespace ChipeleganiProject
{
    partial class Chipeleganyu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chipeleganyu));
            this.landingwords = new System.Windows.Forms.Label();
            this.btngroup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pin = new System.Windows.Forms.PictureBox();
            this.labelreq = new System.Windows.Forms.Label();
            this.logIn = new System.Windows.Forms.LinkLabel();
            this.log = new System.Windows.Forms.LinkLabel();
            this.signUp = new System.Windows.Forms.LinkLabel();
            this.line = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pin)).BeginInit();
            this.SuspendLayout();
            // 
            // landingwords
            // 
            this.landingwords.AutoSize = true;
            this.landingwords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.landingwords.Location = new System.Drawing.Point(82, 258);
            this.landingwords.Name = "landingwords";
            this.landingwords.Size = new System.Drawing.Size(704, 144);
            this.landingwords.TabIndex = 1;
            this.landingwords.Text = resources.GetString("landingwords.Text");
            // 
            // btngroup
            // 
            this.btngroup.BackColor = System.Drawing.Color.Gold;
            this.btngroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngroup.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btngroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngroup.ForeColor = System.Drawing.Color.Black;
            this.btngroup.Location = new System.Drawing.Point(318, 416);
            this.btngroup.Name = "btngroup";
            this.btngroup.Size = new System.Drawing.Size(136, 31);
            this.btngroup.TabIndex = 3;
            this.btngroup.Text = "Create Group";
            this.btngroup.UseVisualStyleBackColor = false;
            this.btngroup.Click += new System.EventHandler(this.btngroup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Warm welcome";
            // 
            // pin
            // 
            this.pin.BackColor = System.Drawing.Color.White;
            this.pin.Image = ((System.Drawing.Image)(resources.GetObject("pin.Image")));
            this.pin.Location = new System.Drawing.Point(304, 115);
            this.pin.Name = "pin";
            this.pin.Size = new System.Drawing.Size(197, 121);
            this.pin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pin.TabIndex = 0;
            this.pin.TabStop = false;
            // 
            // labelreq
            // 
            this.labelreq.AutoSize = true;
            this.labelreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelreq.Location = new System.Drawing.Point(263, 466);
            this.labelreq.Name = "labelreq";
            this.labelreq.Size = new System.Drawing.Size(200, 20);
            this.labelreq.TabIndex = 5;
            this.labelreq.Text = "Already have an account?  ";
            // 
            // logIn
            // 
            this.logIn.AutoSize = true;
            this.logIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logIn.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.logIn.Location = new System.Drawing.Point(453, 466);
            this.logIn.Name = "logIn";
            this.logIn.Size = new System.Drawing.Size(54, 20);
            this.logIn.TabIndex = 6;
            this.logIn.TabStop = true;
            this.logIn.Text = "Log In";
            this.logIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logIn_LinkClicked);
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.log.Location = new System.Drawing.Point(686, 57);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(47, 17);
            this.log.TabIndex = 7;
            this.log.TabStop = true;
            this.log.Text = "Log In";
            this.log.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.log_LinkClicked);
            // 
            // signUp
            // 
            this.signUp.AutoSize = true;
            this.signUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.signUp.Location = new System.Drawing.Point(739, 57);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(58, 17);
            this.signUp.TabIndex = 8;
            this.signUp.TabStop = true;
            this.signUp.Text = "Sign Up";
            this.signUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signUp_LinkClicked);
            // 
            // line
            // 
            this.line.AutoSize = true;
            this.line.Location = new System.Drawing.Point(94, 26);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(657, 13);
            this.line.TabIndex = 9;
            this.line.Text = "__________________________________________________Money__________________________" +
    "___________________________";
            // 
            // Chipeleganyu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(822, 516);
            this.Controls.Add(this.line);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.log);
            this.Controls.Add(this.logIn);
            this.Controls.Add(this.labelreq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btngroup);
            this.Controls.Add(this.landingwords);
            this.Controls.Add(this.pin);
            this.Name = "Chipeleganyu";
            this.Text = "Chipeleganyu";
            ((System.ComponentModel.ISupportInitialize)(this.pin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pin;
        private System.Windows.Forms.Label landingwords;
        private System.Windows.Forms.Button btngroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelreq;
        private System.Windows.Forms.LinkLabel logIn;
        private System.Windows.Forms.LinkLabel log;
        private System.Windows.Forms.LinkLabel signUp;
        private System.Windows.Forms.Label line;
    }
}