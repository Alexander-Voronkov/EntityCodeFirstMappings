namespace CodeFirstMappings
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CompetitionsPage = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CityTextBoxCompet = new System.Windows.Forms.TextBox();
            this.DateCompetPicker = new System.Windows.Forms.DateTimePicker();
            this.NameTextBoxCompet = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ParticipantsPage = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.HeightPicker = new System.Windows.Forms.NumericUpDown();
            this.WeightPicker = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CountryTextBoxPart = new System.Windows.Forms.TextBox();
            this.BirthPicker = new System.Windows.Forms.DateTimePicker();
            this.NameTextBoxPart = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ResultsPage = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CompetitionIdPicker = new System.Windows.Forms.NumericUpDown();
            this.PartIdPicker = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.PlacePicker = new System.Windows.Forms.NumericUpDown();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AddCompetBtn = new System.Windows.Forms.Button();
            this.ActionsCombo = new System.Windows.Forms.ComboBox();
            this.ExecuteBtn = new System.Windows.Forms.Button();
            this.ExecutionPage = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.CompetitionsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ParticipantsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeightPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.ResultsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompetitionIdPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartIdPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlacePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.ExecutionPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CompetitionsPage);
            this.tabControl1.Controls.Add(this.ParticipantsPage);
            this.tabControl1.Controls.Add(this.ResultsPage);
            this.tabControl1.Controls.Add(this.ExecutionPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 367);
            this.tabControl1.TabIndex = 0;
            // 
            // CompetitionsPage
            // 
            this.CompetitionsPage.Controls.Add(this.label3);
            this.CompetitionsPage.Controls.Add(this.label2);
            this.CompetitionsPage.Controls.Add(this.label1);
            this.CompetitionsPage.Controls.Add(this.CityTextBoxCompet);
            this.CompetitionsPage.Controls.Add(this.DateCompetPicker);
            this.CompetitionsPage.Controls.Add(this.NameTextBoxCompet);
            this.CompetitionsPage.Controls.Add(this.dataGridView1);
            this.CompetitionsPage.Location = new System.Drawing.Point(4, 22);
            this.CompetitionsPage.Name = "CompetitionsPage";
            this.CompetitionsPage.Padding = new System.Windows.Forms.Padding(3);
            this.CompetitionsPage.Size = new System.Drawing.Size(768, 341);
            this.CompetitionsPage.TabIndex = 0;
            this.CompetitionsPage.Text = "Competitions";
            this.CompetitionsPage.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(576, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // CityTextBoxCompet
            // 
            this.CityTextBoxCompet.Location = new System.Drawing.Point(517, 293);
            this.CityTextBoxCompet.Name = "CityTextBoxCompet";
            this.CityTextBoxCompet.Size = new System.Drawing.Size(137, 20);
            this.CityTextBoxCompet.TabIndex = 3;
            // 
            // DateCompetPicker
            // 
            this.DateCompetPicker.Location = new System.Drawing.Point(290, 293);
            this.DateCompetPicker.Name = "DateCompetPicker";
            this.DateCompetPicker.Size = new System.Drawing.Size(200, 20);
            this.DateCompetPicker.TabIndex = 2;
            // 
            // NameTextBoxCompet
            // 
            this.NameTextBoxCompet.Location = new System.Drawing.Point(93, 293);
            this.NameTextBoxCompet.Name = "NameTextBoxCompet";
            this.NameTextBoxCompet.Size = new System.Drawing.Size(163, 20);
            this.NameTextBoxCompet.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(756, 265);
            this.dataGridView1.TabIndex = 0;
            // 
            // ParticipantsPage
            // 
            this.ParticipantsPage.Controls.Add(this.label8);
            this.ParticipantsPage.Controls.Add(this.label7);
            this.ParticipantsPage.Controls.Add(this.HeightPicker);
            this.ParticipantsPage.Controls.Add(this.WeightPicker);
            this.ParticipantsPage.Controls.Add(this.label4);
            this.ParticipantsPage.Controls.Add(this.label5);
            this.ParticipantsPage.Controls.Add(this.label6);
            this.ParticipantsPage.Controls.Add(this.CountryTextBoxPart);
            this.ParticipantsPage.Controls.Add(this.BirthPicker);
            this.ParticipantsPage.Controls.Add(this.NameTextBoxPart);
            this.ParticipantsPage.Controls.Add(this.dataGridView2);
            this.ParticipantsPage.Location = new System.Drawing.Point(4, 22);
            this.ParticipantsPage.Name = "ParticipantsPage";
            this.ParticipantsPage.Padding = new System.Windows.Forms.Padding(3);
            this.ParticipantsPage.Size = new System.Drawing.Size(768, 341);
            this.ParticipantsPage.TabIndex = 1;
            this.ParticipantsPage.Text = "Participants";
            this.ParticipantsPage.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(709, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Height";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(624, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Weight";
            // 
            // HeightPicker
            // 
            this.HeightPicker.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.HeightPicker.Location = new System.Drawing.Point(707, 295);
            this.HeightPicker.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.HeightPicker.Name = "HeightPicker";
            this.HeightPicker.Size = new System.Drawing.Size(40, 20);
            this.HeightPicker.TabIndex = 15;
            // 
            // WeightPicker
            // 
            this.WeightPicker.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.WeightPicker.Location = new System.Drawing.Point(621, 295);
            this.WeightPicker.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.WeightPicker.Name = "WeightPicker";
            this.WeightPicker.Size = new System.Drawing.Size(44, 20);
            this.WeightPicker.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(501, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Name";
            // 
            // CountryTextBoxPart
            // 
            this.CountryTextBoxPart.Location = new System.Drawing.Point(442, 295);
            this.CountryTextBoxPart.Name = "CountryTextBoxPart";
            this.CountryTextBoxPart.Size = new System.Drawing.Size(137, 20);
            this.CountryTextBoxPart.TabIndex = 10;
            // 
            // BirthPicker
            // 
            this.BirthPicker.Location = new System.Drawing.Point(215, 295);
            this.BirthPicker.Name = "BirthPicker";
            this.BirthPicker.Size = new System.Drawing.Size(200, 20);
            this.BirthPicker.TabIndex = 9;
            // 
            // NameTextBoxPart
            // 
            this.NameTextBoxPart.Location = new System.Drawing.Point(18, 295);
            this.NameTextBoxPart.Name = "NameTextBoxPart";
            this.NameTextBoxPart.Size = new System.Drawing.Size(163, 20);
            this.NameTextBoxPart.TabIndex = 8;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(756, 270);
            this.dataGridView2.TabIndex = 1;
            // 
            // ResultsPage
            // 
            this.ResultsPage.Controls.Add(this.label11);
            this.ResultsPage.Controls.Add(this.label10);
            this.ResultsPage.Controls.Add(this.CompetitionIdPicker);
            this.ResultsPage.Controls.Add(this.PartIdPicker);
            this.ResultsPage.Controls.Add(this.label9);
            this.ResultsPage.Controls.Add(this.PlacePicker);
            this.ResultsPage.Controls.Add(this.dataGridView3);
            this.ResultsPage.Location = new System.Drawing.Point(4, 22);
            this.ResultsPage.Name = "ResultsPage";
            this.ResultsPage.Size = new System.Drawing.Size(768, 341);
            this.ResultsPage.TabIndex = 2;
            this.ResultsPage.Text = "Results";
            this.ResultsPage.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(469, 310);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "CompetitionId";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(289, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "ParticipantId";
            // 
            // CompetitionIdPicker
            // 
            this.CompetitionIdPicker.Location = new System.Drawing.Point(546, 308);
            this.CompetitionIdPicker.Name = "CompetitionIdPicker";
            this.CompetitionIdPicker.Size = new System.Drawing.Size(62, 20);
            this.CompetitionIdPicker.TabIndex = 5;
            // 
            // PartIdPicker
            // 
            this.PartIdPicker.Location = new System.Drawing.Point(361, 308);
            this.PartIdPicker.Name = "PartIdPicker";
            this.PartIdPicker.Size = new System.Drawing.Size(62, 20);
            this.PartIdPicker.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(126, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Place";
            // 
            // PlacePicker
            // 
            this.PlacePicker.Location = new System.Drawing.Point(166, 308);
            this.PlacePicker.Name = "PlacePicker";
            this.PlacePicker.Size = new System.Drawing.Size(62, 20);
            this.PlacePicker.TabIndex = 2;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(756, 281);
            this.dataGridView3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(79, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddCompetBtn
            // 
            this.AddCompetBtn.Location = new System.Drawing.Point(334, 400);
            this.AddCompetBtn.Name = "AddCompetBtn";
            this.AddCompetBtn.Size = new System.Drawing.Size(87, 38);
            this.AddCompetBtn.TabIndex = 4;
            this.AddCompetBtn.Text = "Add";
            this.AddCompetBtn.UseVisualStyleBackColor = true;
            this.AddCompetBtn.Click += new System.EventHandler(this.AddCompetBtn_Click);
            // 
            // ActionsCombo
            // 
            this.ActionsCombo.FormattingEnabled = true;
            this.ActionsCombo.Location = new System.Drawing.Point(638, 388);
            this.ActionsCombo.Name = "ActionsCombo";
            this.ActionsCombo.Size = new System.Drawing.Size(141, 21);
            this.ActionsCombo.TabIndex = 5;
            this.ActionsCombo.SelectedIndexChanged += new System.EventHandler(this.ActionsCombo_SelectedIndexChanged);
            // 
            // ExecuteBtn
            // 
            this.ExecuteBtn.Location = new System.Drawing.Point(674, 415);
            this.ExecuteBtn.Name = "ExecuteBtn";
            this.ExecuteBtn.Size = new System.Drawing.Size(75, 23);
            this.ExecuteBtn.TabIndex = 6;
            this.ExecuteBtn.Text = "Execute";
            this.ExecuteBtn.UseVisualStyleBackColor = true;
            this.ExecuteBtn.Click += new System.EventHandler(this.ExecuteBtn_Click);
            // 
            // ExecutionPage
            // 
            this.ExecutionPage.Controls.Add(this.dataGridView4);
            this.ExecutionPage.Location = new System.Drawing.Point(4, 22);
            this.ExecutionPage.Name = "ExecutionPage";
            this.ExecutionPage.Size = new System.Drawing.Size(768, 341);
            this.ExecutionPage.TabIndex = 3;
            this.ExecutionPage.Text = "ExecutionResult";
            this.ExecutionPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(9, 6);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(756, 335);
            this.dataGridView4.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(549, 418);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ExecuteBtn);
            this.Controls.Add(this.ActionsCombo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.AddCompetBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.CompetitionsPage.ResumeLayout(false);
            this.CompetitionsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ParticipantsPage.ResumeLayout(false);
            this.ParticipantsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeightPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResultsPage.ResumeLayout(false);
            this.ResultsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompetitionIdPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartIdPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlacePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ExecutionPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CompetitionsPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CityTextBoxCompet;
        private System.Windows.Forms.DateTimePicker DateCompetPicker;
        private System.Windows.Forms.TextBox NameTextBoxCompet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage ParticipantsPage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown HeightPicker;
        private System.Windows.Forms.NumericUpDown WeightPicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CountryTextBoxPart;
        private System.Windows.Forms.DateTimePicker BirthPicker;
        private System.Windows.Forms.TextBox NameTextBoxPart;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage ResultsPage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown CompetitionIdPicker;
        private System.Windows.Forms.NumericUpDown PartIdPicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown PlacePicker;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddCompetBtn;
        private System.Windows.Forms.ComboBox ActionsCombo;
        private System.Windows.Forms.Button ExecuteBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage ExecutionPage;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TextBox textBox1;
    }
}

