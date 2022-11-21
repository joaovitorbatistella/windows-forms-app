namespace WindowsFormsApp1.Forms
{
    partial class loginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dontHaveAccountLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.loginTileLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dontHaveAccountLabel);
            this.panel1.Controls.Add(this.passwordLabel);
            this.panel1.Controls.Add(this.emailLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(this.loginTileLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 394);
            this.panel1.TabIndex = 0;
            // 
            // dontHaveAccountLabel
            // 
            this.dontHaveAccountLabel.AutoSize = true;
            this.dontHaveAccountLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dontHaveAccountLabel.Location = new System.Drawing.Point(68, 335);
            this.dontHaveAccountLabel.Name = "dontHaveAccountLabel";
            this.dontHaveAccountLabel.Size = new System.Drawing.Size(228, 26);
            this.dontHaveAccountLabel.TabIndex = 7;
            this.dontHaveAccountLabel.Text = "Don\'t have an account?\r\nToo bad, it won\'t be today that you\'ll have one!\r\n";
            this.dontHaveAccountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(49, 234);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(49, 180);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 5;
            this.emailLabel.Text = "Email:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(125, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(125, 294);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(110, 38);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.btnLogin);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(52, 250);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(254, 26);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(52, 196);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(254, 26);
            this.emailTextBox.TabIndex = 1;
            // 
            // loginTileLabel
            // 
            this.loginTileLabel.AutoSize = true;
            this.loginTileLabel.Font = new System.Drawing.Font("Lucida Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTileLabel.Location = new System.Drawing.Point(118, 19);
            this.loginTileLabel.Name = "loginTileLabel";
            this.loginTileLabel.Size = new System.Drawing.Size(117, 39);
            this.loginTileLabel.TabIndex = 0;
            this.loginTileLabel.Text = "Login";
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(365, 394);
            this.Controls.Add(this.panel1);
            this.Name = "loginForm";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label loginTileLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label dontHaveAccountLabel;
        private System.Windows.Forms.Label passwordLabel;
    }
}