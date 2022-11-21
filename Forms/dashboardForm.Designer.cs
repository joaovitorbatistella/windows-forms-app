namespace WindowsFormsApp1
{
    partial class dashboradForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboradForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logOutButton = new System.Windows.Forms.Button();
            this.uidlabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.loggedUserLabel = new System.Windows.Forms.Label();
            this.userIcon = new System.Windows.Forms.PictureBox();
            this.tabToDo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addToDoBtn = new System.Windows.Forms.Button();
            this.todoFormTitleLabel = new System.Windows.Forms.Label();
            this.descriptionTextBoxLabel = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.todoChecked = new System.Windows.Forms.CheckedListBox();
            this.dashboardChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            this.tabToDo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardChart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.logOutButton);
            this.panel1.Controls.Add(this.uidlabel);
            this.panel1.Controls.Add(this.userNameLabel);
            this.panel1.Controls.Add(this.loggedUserLabel);
            this.panel1.Controls.Add(this.userIcon);
            this.panel1.Controls.Add(this.tabToDo);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.todoChecked);
            this.panel1.Controls.Add(this.dashboardChart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 681);
            this.panel1.TabIndex = 0;
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.White;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Image = ((System.Drawing.Image)(resources.GetObject("logOutButton.Image")));
            this.logOutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutButton.Location = new System.Drawing.Point(293, 46);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(81, 45);
            this.logOutButton.TabIndex = 6;
            this.logOutButton.Text = "Logout";
            this.logOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logOutButton.UseVisualStyleBackColor = false;
            // 
            // uidlabel
            // 
            this.uidlabel.AutoSize = true;
            this.uidlabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uidlabel.Location = new System.Drawing.Point(138, 80);
            this.uidlabel.Name = "uidlabel";
            this.uidlabel.Size = new System.Drawing.Size(117, 15);
            this.uidlabel.TabIndex = 5;
            this.uidlabel.Text = "UID: 2020003774";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(138, 61);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(131, 15);
            this.userNameLabel.TabIndex = 4;
            this.userNameLabel.Text = "João Vítor Batistella";
            // 
            // loggedUserLabel
            // 
            this.loggedUserLabel.AutoSize = true;
            this.loggedUserLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedUserLabel.Location = new System.Drawing.Point(129, 34);
            this.loggedUserLabel.Name = "loggedUserLabel";
            this.loggedUserLabel.Size = new System.Drawing.Size(112, 18);
            this.loggedUserLabel.TabIndex = 4;
            this.loggedUserLabel.Text = "Logged User";
            // 
            // userIcon
            // 
            this.userIcon.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.user;
            this.userIcon.Location = new System.Drawing.Point(26, 34);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(100, 100);
            this.userIcon.TabIndex = 4;
            this.userIcon.TabStop = false;
            // 
            // tabToDo
            // 
            this.tabToDo.Controls.Add(this.tabPage1);
            this.tabToDo.Location = new System.Drawing.Point(425, 12);
            this.tabToDo.Name = "tabToDo";
            this.tabToDo.SelectedIndex = 0;
            this.tabToDo.Size = new System.Drawing.Size(394, 378);
            this.tabToDo.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(386, 352);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "To Do";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.addToDoBtn);
            this.panel2.Controls.Add(this.todoFormTitleLabel);
            this.panel2.Controls.Add(this.descriptionTextBoxLabel);
            this.panel2.Controls.Add(this.textBoxDescription);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 346);
            this.panel2.TabIndex = 0;
            // 
            // addToDoBtn
            // 
            this.addToDoBtn.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToDoBtn.Location = new System.Drawing.Point(146, 232);
            this.addToDoBtn.Name = "addToDoBtn";
            this.addToDoBtn.Size = new System.Drawing.Size(99, 40);
            this.addToDoBtn.TabIndex = 3;
            this.addToDoBtn.Text = "Add";
            this.addToDoBtn.UseVisualStyleBackColor = true;
            this.addToDoBtn.Click += new System.EventHandler(this.addButtonClicked);
            // 
            // todoFormTitleLabel
            // 
            this.todoFormTitleLabel.AutoSize = true;
            this.todoFormTitleLabel.Font = new System.Drawing.Font("Lucida Sans", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoFormTitleLabel.Location = new System.Drawing.Point(109, 24);
            this.todoFormTitleLabel.Name = "todoFormTitleLabel";
            this.todoFormTitleLabel.Size = new System.Drawing.Size(165, 55);
            this.todoFormTitleLabel.TabIndex = 2;
            this.todoFormTitleLabel.Text = "To Do";
            // 
            // descriptionTextBoxLabel
            // 
            this.descriptionTextBoxLabel.AutoSize = true;
            this.descriptionTextBoxLabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBoxLabel.Location = new System.Drawing.Point(36, 101);
            this.descriptionTextBoxLabel.Name = "descriptionTextBoxLabel";
            this.descriptionTextBoxLabel.Size = new System.Drawing.Size(80, 15);
            this.descriptionTextBoxLabel.TabIndex = 1;
            this.descriptionTextBoxLabel.Text = "Description\r\n";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.AcceptsTab = true;
            this.textBoxDescription.Location = new System.Drawing.Point(39, 117);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(302, 90);
            this.textBoxDescription.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(849, 367);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(403, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // todoChecked
            // 
            this.todoChecked.ForeColor = System.Drawing.Color.Black;
            this.todoChecked.FormattingEnabled = true;
            this.todoChecked.Location = new System.Drawing.Point(849, 12);
            this.todoChecked.Name = "todoChecked";
            this.todoChecked.Size = new System.Drawing.Size(403, 349);
            this.todoChecked.TabIndex = 1;
            this.todoChecked.SelectedIndexChanged += new System.EventHandler(this.todoIndexChecked);
            // 
            // dashboardChart
            // 
            chartArea2.Name = "ChartArea1";
            this.dashboardChart.ChartAreas.Add(chartArea2);
            this.dashboardChart.Cursor = System.Windows.Forms.Cursors.Default;
            this.dashboardChart.ImeMode = System.Windows.Forms.ImeMode.Off;
            legend2.Name = "Legend1";
            this.dashboardChart.Legends.Add(legend2);
            this.dashboardChart.Location = new System.Drawing.Point(0, 420);
            this.dashboardChart.Name = "dashboardChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.dashboardChart.Series.Add(series2);
            this.dashboardChart.Size = new System.Drawing.Size(1264, 261);
            this.dashboardChart.TabIndex = 0;
            this.dashboardChart.Text = "Dashboard Chart";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dashboradForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Name = "dashboradForm";
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            this.tabToDo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart dashboardChart;
        private System.Windows.Forms.TabControl tabToDo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckedListBox todoChecked;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label todoFormTitleLabel;
        private System.Windows.Forms.Label descriptionTextBoxLabel;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button addToDoBtn;
        private System.Windows.Forms.Label loggedUserLabel;
        private System.Windows.Forms.PictureBox userIcon;
        private System.Windows.Forms.Label uidlabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Button logOutButton;
    }
}

