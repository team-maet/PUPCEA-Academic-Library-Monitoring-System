namespace Academic_Library_Monitoring_System
{
    partial class Borrow
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBorrow_Submit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBorrow_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(50, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search the title of the book here:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 142);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "(e.g.) Software Engineering by Sommerville";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(314, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 60);
            this.label2.TabIndex = 3;
            this.label2.Text = "After you click the submit button,\r\nplease go to the admin or library staff\r\nto l" +
    "eave your ID and get the book.\r\n";
            // 
            // buttonBorrow_Submit
            // 
            this.buttonBorrow_Submit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonBorrow_Submit.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrow_Submit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBorrow_Submit.Location = new System.Drawing.Point(98, 186);
            this.buttonBorrow_Submit.Name = "buttonBorrow_Submit";
            this.buttonBorrow_Submit.Size = new System.Drawing.Size(101, 48);
            this.buttonBorrow_Submit.TabIndex = 20;
            this.buttonBorrow_Submit.Text = "Submit";
            this.buttonBorrow_Submit.UseVisualStyleBackColor = false;
            this.buttonBorrow_Submit.Click += new System.EventHandler(this.buttonBorrow_Submit_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(372, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 37);
            this.label3.TabIndex = 21;
            this.label3.Text = "NOTE:";
            // 
            // buttonBorrow_Back
            // 
            this.buttonBorrow_Back.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonBorrow_Back.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrow_Back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBorrow_Back.Location = new System.Drawing.Point(497, 293);
            this.buttonBorrow_Back.Name = "buttonBorrow_Back";
            this.buttonBorrow_Back.Size = new System.Drawing.Size(68, 30);
            this.buttonBorrow_Back.TabIndex = 24;
            this.buttonBorrow_Back.Text = "Back";
            this.buttonBorrow_Back.UseVisualStyleBackColor = false;
            this.buttonBorrow_Back.Click += new System.EventHandler(this.buttonBorrow_Back_Click);
            // 
            // Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(577, 335);
            this.Controls.Add(this.buttonBorrow_Back);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonBorrow_Submit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Borrow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Academic Library Monitoring System | BORROW";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBorrow_Submit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBorrow_Back;
    }
}