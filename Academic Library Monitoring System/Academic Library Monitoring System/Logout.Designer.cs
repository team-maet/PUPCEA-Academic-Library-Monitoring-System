namespace Academic_Library_Monitoring_System
{
    partial class Logout
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
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLogout_Submit = new System.Windows.Forms.Button();
            this.buttonLogout_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textPassword
            // 
            this.textPassword.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textPassword.Location = new System.Drawing.Point(220, 172);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(136, 20);
            this.textPassword.TabIndex = 21;
            this.textPassword.Text = "********";
            this.textPassword.Enter += new System.EventHandler(this.textPassword_Enter);
            this.textPassword.Leave += new System.EventHandler(this.textPassword_Leave);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(111, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "Password";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(111, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Username";
            // 
            // textUsername
            // 
            this.textUsername.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textUsername.Location = new System.Drawing.Point(220, 130);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(136, 20);
            this.textUsername.TabIndex = 17;
            this.textUsername.Text = "(e.g.) juandelacruz09";
            this.textUsername.Enter += new System.EventHandler(this.textUsername_Enter);
            this.textUsername.Leave += new System.EventHandler(this.textUsername_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(242, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Logout";
            // 
            // buttonLogout_Submit
            // 
            this.buttonLogout_Submit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLogout_Submit.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout_Submit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLogout_Submit.Location = new System.Drawing.Point(238, 221);
            this.buttonLogout_Submit.Name = "buttonLogout_Submit";
            this.buttonLogout_Submit.Size = new System.Drawing.Size(101, 48);
            this.buttonLogout_Submit.TabIndex = 22;
            this.buttonLogout_Submit.Text = "Logout";
            this.buttonLogout_Submit.UseVisualStyleBackColor = false;
            this.buttonLogout_Submit.Click += new System.EventHandler(this.buttonLogout_Submit_Click_1);
            // 
            // buttonLogout_Back
            // 
            this.buttonLogout_Back.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLogout_Back.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout_Back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLogout_Back.Location = new System.Drawing.Point(497, 293);
            this.buttonLogout_Back.Name = "buttonLogout_Back";
            this.buttonLogout_Back.Size = new System.Drawing.Size(68, 30);
            this.buttonLogout_Back.TabIndex = 23;
            this.buttonLogout_Back.Text = "Back";
            this.buttonLogout_Back.UseVisualStyleBackColor = false;
            this.buttonLogout_Back.Click += new System.EventHandler(this.buttonLogout_Back_Click);
            // 
            // Logout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(577, 335);
            this.Controls.Add(this.buttonLogout_Back);
            this.Controls.Add(this.buttonLogout_Submit);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.label2);
            this.Name = "Logout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Academic Library Monitoring System | LOGOUT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLogout_Submit;
        private System.Windows.Forms.Button buttonLogout_Back;
    }
}