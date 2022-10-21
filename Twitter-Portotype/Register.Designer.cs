namespace Twitter_Portotype
{
    partial class Register
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPword = new System.Windows.Forms.TextBox();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(105, 176);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username";
            // 
            // txtPword
            // 
            this.txtPword.Location = new System.Drawing.Point(92, 140);
            this.txtPword.Name = "txtPword";
            this.txtPword.Size = new System.Drawing.Size(100, 23);
            this.txtPword.TabIndex = 6;
            // 
            // txtUname
            // 
            this.txtUname.Location = new System.Drawing.Point(92, 24);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(100, 23);
            this.txtUname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Location";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(92, 111);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 23);
            this.txtLocation.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Last Name";
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(92, 82);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(100, 23);
            this.txtLname.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "First Name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(92, 53);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(100, 23);
            this.txtFname.TabIndex = 16;
            this.txtFname.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 211);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPword);
            this.Controls.Add(this.txtUname);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRegister;
        private Label label2;
        private Label label1;
        private TextBox txtPword;
        private TextBox txtUname;
        private Label label3;
        private TextBox txtLocation;
        private Label label5;
        private TextBox txtLname;
        private Label label6;
        private TextBox txtFname;
    }
}