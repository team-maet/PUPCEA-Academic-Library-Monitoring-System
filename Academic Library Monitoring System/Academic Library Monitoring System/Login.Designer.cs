namespace Academic_Library_Monitoring_System
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin_Submit = new System.Windows.Forms.Button();
            this.buttonLogin_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(248, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login";
            // 
            // textUsername
            // 
            this.textUsername.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textUsername.Location = new System.Drawing.Point(221, 123);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(136, 20);
            this.textUsername.TabIndex = 3;
            this.textUsername.Text = "(e.g.) juandelacruz09";
            this.textUsername.Enter += new System.EventHandler(this.textUsername_Enter);
            this.textUsername.Leave += new System.EventHandler(this.textUsername_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(112, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Username";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(112, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Password";
            // 
            // textPassword
            // 
            this.textPassword.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textPassword.Location = new System.Drawing.Point(221, 165);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(136, 20);
            this.textPassword.TabIndex = 15;
            this.textPassword.Text = "aaaaaaaa";
            this.textPassword.Enter += new System.EventHandler(this.textPassword_Enter);
            this.textPassword.Leave += new System.EventHandler(this.textPassword_Leave);
            // 
            // buttonLogin_Submit
            // 
            this.buttonLogin_Submit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLogin_Submit.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin_Submit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLogin_Submit.Location = new System.Drawing.Point(238, 211);
            this.buttonLogin_Submit.Name = "buttonLogin_Submit";
            this.buttonLogin_Submit.Size = new System.Drawing.Size(101, 48);
            this.buttonLogin_Submit.TabIndex = 19;
            this.buttonLogin_Submit.Text = "Login";
            this.buttonLogin_Submit.UseVisualStyleBackColor = false;
            this.buttonLogin_Submit.Click += new System.EventHandler(this.buttonLogin_Submit_Click);
            // 
            // buttonLogin_Back
            // 
            this.buttonLogin_Back.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLogin_Back.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin_Back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLogin_Back.Location = new System.Drawing.Point(497, 293);
            this.buttonLogin_Back.Name = "buttonLogin_Back";
            this.buttonLogin_Back.Size = new System.Drawing.Size(68, 30);
            this.buttonLogin_Back.TabIndex = 24;
            this.buttonLogin_Back.Text = "Back";
            this.buttonLogin_Back.UseVisualStyleBackColor = false;
            this.buttonLogin_Back.Click += new System.EventHandler(this.buttonLogin_Back_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(577, 335);
            this.ControlBox = false;
            this.Controls.Add(this.buttonLogin_Back);
            this.Controls.Add(this.buttonLogin_Submit);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.label2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Academic Library Monitoring System | LOGIN";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button buttonLogin_Submit;
        private System.Windows.Forms.Button buttonLogin_Back;
    }
}