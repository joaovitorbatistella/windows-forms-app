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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.progressBarDash = new System.Windows.Forms.ProgressBar();
            this.todoChecked = new System.Windows.Forms.CheckedListBox();
            this.dashboardChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.userBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            this.tabToDo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
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
            this.panel1.Controls.Add(this.progressBarDash);
            this.panel1.Controls.Add(this.todoChecked);
            this.panel1.Controls.Add(this.dashboardChart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1685, 838);
            this.panel1.TabIndex = 0;
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.White;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Image = ((System.Drawing.Image)(resources.GetObject("logOutButton.Image")));
            this.logOutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutButton.Location = new System.Drawing.Point(391, 57);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(4);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(108, 55);
            this.logOutButton.TabIndex = 6;
            this.logOutButton.Text = "Logout";
            this.logOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logoutBtnClick);
            // 
            // uidlabel
            // 
            this.uidlabel.AutoSize = true;
            this.uidlabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uidlabel.Location = new System.Drawing.Point(184, 98);
            this.uidlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uidlabel.Name = "uidlabel";
            this.uidlabel.Size = new System.Drawing.Size(162, 19);
            this.uidlabel.TabIndex = 5;
            this.uidlabel.Text = "UID: 2020003774";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(184, 75);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(173, 19);
            this.userNameLabel.TabIndex = 4;
            this.userNameLabel.Text = "João Vítor Batistella";
            // 
            // loggedUserLabel
            // 
            this.loggedUserLabel.AutoSize = true;
            this.loggedUserLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedUserLabel.Location = new System.Drawing.Point(172, 42);
            this.loggedUserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loggedUserLabel.Name = "loggedUserLabel";
            this.loggedUserLabel.Size = new System.Drawing.Size(142, 23);
            this.loggedUserLabel.TabIndex = 4;
            this.loggedUserLabel.Text = "Logged User";
            // 
            // userIcon
            // 
            this.userIcon.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.user;
            this.userIcon.Location = new System.Drawing.Point(35, 42);
            this.userIcon.Margin = new System.Windows.Forms.Padding(4);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(133, 123);
            this.userIcon.TabIndex = 4;
            this.userIcon.TabStop = false;
            // 
            // tabToDo
            // 
            this.tabToDo.Controls.Add(this.tabPage1);
            this.tabToDo.Location = new System.Drawing.Point(567, 15);
            this.tabToDo.Margin = new System.Windows.Forms.Padding(4);
            this.tabToDo.Name = "tabToDo";
            this.tabToDo.SelectedIndex = 0;
            this.tabToDo.Size = new System.Drawing.Size(525, 465);
            this.tabToDo.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(517, 436);
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
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(509, 428);
            this.panel2.TabIndex = 0;
            // 
            // addToDoBtn
            // 
            this.addToDoBtn.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToDoBtn.Location = new System.Drawing.Point(195, 286);
            this.addToDoBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addToDoBtn.Name = "addToDoBtn";
            this.addToDoBtn.Size = new System.Drawing.Size(132, 49);
            this.addToDoBtn.TabIndex = 3;
            this.addToDoBtn.Text = "Add";
            this.addToDoBtn.UseVisualStyleBackColor = true;
            this.addToDoBtn.Click += new System.EventHandler(this.addButtonClicked);
            // 
            // todoFormTitleLabel
            // 
            this.todoFormTitleLabel.AutoSize = true;
            this.todoFormTitleLabel.Font = new System.Drawing.Font("Lucida Sans", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoFormTitleLabel.Location = new System.Drawing.Point(145, 30);
            this.todoFormTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.todoFormTitleLabel.Name = "todoFormTitleLabel";
            this.todoFormTitleLabel.Size = new System.Drawing.Size(204, 68);
            this.todoFormTitleLabel.TabIndex = 2;
            this.todoFormTitleLabel.Text = "To Do";
            // 
            // descriptionTextBoxLabel
            // 
            this.descriptionTextBoxLabel.AutoSize = true;
            this.descriptionTextBoxLabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBoxLabel.Location = new System.Drawing.Point(48, 124);
            this.descriptionTextBoxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionTextBoxLabel.Name = "descriptionTextBoxLabel";
            this.descriptionTextBoxLabel.Size = new System.Drawing.Size(107, 19);
            this.descriptionTextBoxLabel.TabIndex = 1;
            this.descriptionTextBoxLabel.Text = "Description\r\n";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.AcceptsTab = true;
            this.textBoxDescription.Location = new System.Drawing.Point(52, 144);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(401, 110);
            this.textBoxDescription.TabIndex = 0;
            // 
            // progressBarDash
            // 
            this.progressBarDash.Location = new System.Drawing.Point(1132, 452);
            this.progressBarDash.Margin = new System.Windows.Forms.Padding(4);
            this.progressBarDash.Name = "progressBarDash";
            this.progressBarDash.Size = new System.Drawing.Size(537, 28);
            this.progressBarDash.TabIndex = 2;
            // 
            // todoChecked
            // 
            this.todoChecked.ForeColor = System.Drawing.Color.Black;
            this.todoChecked.FormattingEnabled = true;
            this.todoChecked.Location = new System.Drawing.Point(1132, 14);
            this.todoChecked.Margin = new System.Windows.Forms.Padding(4);
            this.todoChecked.Name = "todoChecked";
            this.todoChecked.Size = new System.Drawing.Size(536, 429);
            this.todoChecked.TabIndex = 1;
            this.todoChecked.SelectedIndexChanged += new System.EventHandler(this.onCheck);
            // 
            // dashboardChart
            // 
            chartArea1.Name = "ChartArea1";
            this.dashboardChart.ChartAreas.Add(chartArea1);
            this.dashboardChart.Cursor = System.Windows.Forms.Cursors.Default;
            this.dashboardChart.DataSource = this.userBindingSource1;
            this.dashboardChart.ImeMode = System.Windows.Forms.ImeMode.Off;
            legend1.Name = "Legend1";
            this.dashboardChart.Legends.Add(legend1);
            this.dashboardChart.Location = new System.Drawing.Point(0, 517);
            this.dashboardChart.Margin = new System.Windows.Forms.Padding(4);
            this.dashboardChart.Name = "dashboardChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.dashboardChart.Series.Add(series1);
            this.dashboardChart.Size = new System.Drawing.Size(1685, 321);
            this.dashboardChart.TabIndex = 0;
            this.dashboardChart.Text = "Dashboard Chart";
            // 
            // userBindingSource1
            // 
            this.userBindingSource1.DataSource = typeof(WindowsFormsApp1.User);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(WindowsFormsApp1.User);
            // 
            // dashboradForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart dashboardChart;
        private System.Windows.Forms.TabControl tabToDo;
        private System.Windows.Forms.ProgressBar progressBarDash;
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
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource1;
    }
}

