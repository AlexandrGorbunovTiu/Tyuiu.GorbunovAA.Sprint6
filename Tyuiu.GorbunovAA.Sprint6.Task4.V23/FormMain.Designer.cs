
namespace Tyuiu.GorbunovAA.Sprint6.Task4.V23
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelTop_GAA = new System.Windows.Forms.Panel();
            this.groupBoxInp_GAA = new System.Windows.Forms.GroupBox();
            this.buttonDone_GAA = new System.Windows.Forms.Button();
            this.buttonSave_GAA = new System.Windows.Forms.Button();
            this.buttonInfo_GAA = new System.Windows.Forms.Button();
            this.groupBoxCon_GAA = new System.Windows.Forms.GroupBox();
            this.panelLeft_GAA = new System.Windows.Forms.Panel();
            this.groupBoxOut_GAA = new System.Windows.Forms.GroupBox();
            this.textBoxOut_GAA = new System.Windows.Forms.TextBox();
            this.panelRight_GAA = new System.Windows.Forms.Panel();
            this.chartInfo_GAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitterLeft_GAA = new System.Windows.Forms.Splitter();
            this.textBoxEnd_GAA = new System.Windows.Forms.TextBox();
            this.textBoxStart_GAA = new System.Windows.Forms.TextBox();
            this.labelStart_GAA = new System.Windows.Forms.Label();
            this.labelEnd_GAA = new System.Windows.Forms.Label();
            this.panelTop_GAA.SuspendLayout();
            this.groupBoxInp_GAA.SuspendLayout();
            this.panelLeft_GAA.SuspendLayout();
            this.groupBoxOut_GAA.SuspendLayout();
            this.panelRight_GAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartInfo_GAA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_GAA
            // 
            this.panelTop_GAA.BackColor = System.Drawing.SystemColors.Menu;
            this.panelTop_GAA.Controls.Add(this.groupBoxInp_GAA);
            this.panelTop_GAA.Controls.Add(this.buttonDone_GAA);
            this.panelTop_GAA.Controls.Add(this.buttonSave_GAA);
            this.panelTop_GAA.Controls.Add(this.buttonInfo_GAA);
            this.panelTop_GAA.Controls.Add(this.groupBoxCon_GAA);
            this.panelTop_GAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_GAA.ForeColor = System.Drawing.Color.White;
            this.panelTop_GAA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_GAA.Name = "panelTop_GAA";
            this.panelTop_GAA.Size = new System.Drawing.Size(1034, 100);
            this.panelTop_GAA.TabIndex = 0;
            // 
            // groupBoxInp_GAA
            // 
            this.groupBoxInp_GAA.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBoxInp_GAA.Controls.Add(this.labelEnd_GAA);
            this.groupBoxInp_GAA.Controls.Add(this.labelStart_GAA);
            this.groupBoxInp_GAA.Controls.Add(this.textBoxStart_GAA);
            this.groupBoxInp_GAA.Controls.Add(this.textBoxEnd_GAA);
            this.groupBoxInp_GAA.Location = new System.Drawing.Point(489, 17);
            this.groupBoxInp_GAA.Name = "groupBoxInp_GAA";
            this.groupBoxInp_GAA.Size = new System.Drawing.Size(214, 69);
            this.groupBoxInp_GAA.TabIndex = 0;
            this.groupBoxInp_GAA.TabStop = false;
            this.groupBoxInp_GAA.Text = "Ввод данных";
            // 
            // buttonDone_GAA
            // 
            this.buttonDone_GAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDone_GAA.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonDone_GAA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDone_GAA.Location = new System.Drawing.Point(729, 17);
            this.buttonDone_GAA.Name = "buttonDone_GAA";
            this.buttonDone_GAA.Size = new System.Drawing.Size(116, 69);
            this.buttonDone_GAA.TabIndex = 1;
            this.buttonDone_GAA.Text = "Старт";
            this.buttonDone_GAA.UseVisualStyleBackColor = false;
            this.buttonDone_GAA.Click += new System.EventHandler(this.buttonDone_GAA_Click);
            // 
            // buttonSave_GAA
            // 
            this.buttonSave_GAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave_GAA.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonSave_GAA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSave_GAA.Location = new System.Drawing.Point(944, 17);
            this.buttonSave_GAA.Name = "buttonSave_GAA";
            this.buttonSave_GAA.Size = new System.Drawing.Size(78, 69);
            this.buttonSave_GAA.TabIndex = 1;
            this.buttonSave_GAA.Text = "Сохранить";
            this.buttonSave_GAA.UseVisualStyleBackColor = false;
            this.buttonSave_GAA.Click += new System.EventHandler(this.buttonSave_GAA_Click);
            // 
            // buttonInfo_GAA
            // 
            this.buttonInfo_GAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_GAA.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonInfo_GAA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonInfo_GAA.Location = new System.Drawing.Point(851, 17);
            this.buttonInfo_GAA.Name = "buttonInfo_GAA";
            this.buttonInfo_GAA.Size = new System.Drawing.Size(87, 69);
            this.buttonInfo_GAA.TabIndex = 1;
            this.buttonInfo_GAA.Text = "Справка";
            this.buttonInfo_GAA.UseVisualStyleBackColor = false;
            this.buttonInfo_GAA.Click += new System.EventHandler(this.buttonInfo_GAA_Click);
            // 
            // groupBoxCon_GAA
            // 
            this.groupBoxCon_GAA.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBoxCon_GAA.Location = new System.Drawing.Point(8, 17);
            this.groupBoxCon_GAA.Name = "groupBoxCon_GAA";
            this.groupBoxCon_GAA.Size = new System.Drawing.Size(463, 69);
            this.groupBoxCon_GAA.TabIndex = 0;
            this.groupBoxCon_GAA.TabStop = false;
            this.groupBoxCon_GAA.Text = "Условие";
            // 
            // panelLeft_GAA
            // 
            this.panelLeft_GAA.BackColor = System.Drawing.SystemColors.Control;
            this.panelLeft_GAA.Controls.Add(this.groupBoxOut_GAA);
            this.panelLeft_GAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_GAA.Location = new System.Drawing.Point(0, 100);
            this.panelLeft_GAA.Name = "panelLeft_GAA";
            this.panelLeft_GAA.Padding = new System.Windows.Forms.Padding(5);
            this.panelLeft_GAA.Size = new System.Drawing.Size(200, 411);
            this.panelLeft_GAA.TabIndex = 0;
            // 
            // groupBoxOut_GAA
            // 
            this.groupBoxOut_GAA.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBoxOut_GAA.Controls.Add(this.textBoxOut_GAA);
            this.groupBoxOut_GAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOut_GAA.Location = new System.Drawing.Point(5, 5);
            this.groupBoxOut_GAA.Name = "groupBoxOut_GAA";
            this.groupBoxOut_GAA.Size = new System.Drawing.Size(190, 401);
            this.groupBoxOut_GAA.TabIndex = 0;
            this.groupBoxOut_GAA.TabStop = false;
            this.groupBoxOut_GAA.Text = "groupBox1";
            // 
            // textBoxOut_GAA
            // 
            this.textBoxOut_GAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOut_GAA.Location = new System.Drawing.Point(3, 16);
            this.textBoxOut_GAA.Multiline = true;
            this.textBoxOut_GAA.Name = "textBoxOut_GAA";
            this.textBoxOut_GAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOut_GAA.Size = new System.Drawing.Size(184, 382);
            this.textBoxOut_GAA.TabIndex = 0;
            // 
            // panelRight_GAA
            // 
            this.panelRight_GAA.BackColor = System.Drawing.SystemColors.Control;
            this.panelRight_GAA.Controls.Add(this.chartInfo_GAA);
            this.panelRight_GAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_GAA.Location = new System.Drawing.Point(0, 100);
            this.panelRight_GAA.Name = "panelRight_GAA";
            this.panelRight_GAA.Size = new System.Drawing.Size(1034, 411);
            this.panelRight_GAA.TabIndex = 0;
            // 
            // chartInfo_GAA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartInfo_GAA.ChartAreas.Add(chartArea1);
            this.chartInfo_GAA.Dock = System.Windows.Forms.DockStyle.Right;
            legend1.Name = "Legend1";
            this.chartInfo_GAA.Legends.Add(legend1);
            this.chartInfo_GAA.Location = new System.Drawing.Point(201, 0);
            this.chartInfo_GAA.Name = "chartInfo_GAA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartInfo_GAA.Series.Add(series1);
            this.chartInfo_GAA.Size = new System.Drawing.Size(833, 411);
            this.chartInfo_GAA.TabIndex = 0;
            this.chartInfo_GAA.Text = "chart1";
            title1.ForeColor = System.Drawing.Color.Blue;
            title1.Name = "Title1";
            title1.Text = "График функции";
            this.chartInfo_GAA.Titles.Add(title1);
            // 
            // splitterLeft_GAA
            // 
            this.splitterLeft_GAA.Location = new System.Drawing.Point(200, 100);
            this.splitterLeft_GAA.Name = "splitterLeft_GAA";
            this.splitterLeft_GAA.Size = new System.Drawing.Size(3, 411);
            this.splitterLeft_GAA.TabIndex = 1;
            this.splitterLeft_GAA.TabStop = false;
            // 
            // textBoxEnd_GAA
            // 
            this.textBoxEnd_GAA.Location = new System.Drawing.Point(113, 43);
            this.textBoxEnd_GAA.Name = "textBoxEnd_GAA";
            this.textBoxEnd_GAA.Size = new System.Drawing.Size(95, 20);
            this.textBoxEnd_GAA.TabIndex = 0;
            this.textBoxEnd_GAA.Text = "5";
            // 
            // textBoxStart_GAA
            // 
            this.textBoxStart_GAA.Location = new System.Drawing.Point(6, 43);
            this.textBoxStart_GAA.Name = "textBoxStart_GAA";
            this.textBoxStart_GAA.Size = new System.Drawing.Size(95, 20);
            this.textBoxStart_GAA.TabIndex = 0;
            this.textBoxStart_GAA.Text = "-5";
            // 
            // labelStart_GAA
            // 
            this.labelStart_GAA.AutoSize = true;
            this.labelStart_GAA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelStart_GAA.Location = new System.Drawing.Point(3, 25);
            this.labelStart_GAA.Name = "labelStart_GAA";
            this.labelStart_GAA.Size = new System.Drawing.Size(47, 13);
            this.labelStart_GAA.TabIndex = 1;
            this.labelStart_GAA.Text = "Начало:";
            // 
            // labelEnd_GAA
            // 
            this.labelEnd_GAA.AutoSize = true;
            this.labelEnd_GAA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEnd_GAA.Location = new System.Drawing.Point(110, 25);
            this.labelEnd_GAA.Name = "labelEnd_GAA";
            this.labelEnd_GAA.Size = new System.Drawing.Size(41, 13);
            this.labelEnd_GAA.TabIndex = 1;
            this.labelEnd_GAA.Text = "Конец:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 511);
            this.Controls.Add(this.splitterLeft_GAA);
            this.Controls.Add(this.panelLeft_GAA);
            this.Controls.Add(this.panelRight_GAA);
            this.Controls.Add(this.panelTop_GAA);
            this.MinimumSize = new System.Drawing.Size(1050, 550);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт #6 │ Выполнил: Горбунов А.А. │ ИИПб-23-2";
            this.panelTop_GAA.ResumeLayout(false);
            this.groupBoxInp_GAA.ResumeLayout(false);
            this.groupBoxInp_GAA.PerformLayout();
            this.panelLeft_GAA.ResumeLayout(false);
            this.groupBoxOut_GAA.ResumeLayout(false);
            this.groupBoxOut_GAA.PerformLayout();
            this.panelRight_GAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartInfo_GAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_GAA;
        private System.Windows.Forms.Panel panelLeft_GAA;
        private System.Windows.Forms.Panel panelRight_GAA;
        private System.Windows.Forms.Splitter splitterLeft_GAA;
        private System.Windows.Forms.Button buttonDone_GAA;
        private System.Windows.Forms.GroupBox groupBoxCon_GAA;
        private System.Windows.Forms.GroupBox groupBoxOut_GAA;
        private System.Windows.Forms.TextBox textBoxOut_GAA;
        private System.Windows.Forms.Button buttonSave_GAA;
        private System.Windows.Forms.Button buttonInfo_GAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartInfo_GAA;
        private System.Windows.Forms.GroupBox groupBoxInp_GAA;
        private System.Windows.Forms.Label labelStart_GAA;
        private System.Windows.Forms.TextBox textBoxStart_GAA;
        private System.Windows.Forms.TextBox textBoxEnd_GAA;
        private System.Windows.Forms.Label labelEnd_GAA;
    }
}

