
namespace Tyuiu.GorbunovAA.Sprint6.Task5.V5
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelUp_GAA = new System.Windows.Forms.Panel();
            this.panelLeft_GAA = new System.Windows.Forms.Panel();
            this.panelRight_GAA = new System.Windows.Forms.Panel();
            this.groupBoxCon_GAA = new System.Windows.Forms.GroupBox();
            this.labelCon_GAA = new System.Windows.Forms.Label();
            this.splitterMain_GAA = new System.Windows.Forms.Splitter();
            this.groupBoxOut_GAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewOut_GAA = new System.Windows.Forms.DataGridView();
            this.buttonDone_GAA = new System.Windows.Forms.Button();
            this.buttonOpen_GAA = new System.Windows.Forms.Button();
            this.buttonInfo_GAA = new System.Windows.Forms.Button();
            this.chartInfo_GAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelUp_GAA.SuspendLayout();
            this.panelLeft_GAA.SuspendLayout();
            this.panelRight_GAA.SuspendLayout();
            this.groupBoxCon_GAA.SuspendLayout();
            this.groupBoxOut_GAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_GAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartInfo_GAA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUp_GAA
            // 
            this.panelUp_GAA.Controls.Add(this.buttonInfo_GAA);
            this.panelUp_GAA.Controls.Add(this.buttonOpen_GAA);
            this.panelUp_GAA.Controls.Add(this.buttonDone_GAA);
            this.panelUp_GAA.Controls.Add(this.groupBoxCon_GAA);
            this.panelUp_GAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp_GAA.Location = new System.Drawing.Point(0, 0);
            this.panelUp_GAA.Name = "panelUp_GAA";
            this.panelUp_GAA.Size = new System.Drawing.Size(794, 88);
            this.panelUp_GAA.TabIndex = 0;
            // 
            // panelLeft_GAA
            // 
            this.panelLeft_GAA.Controls.Add(this.groupBoxOut_GAA);
            this.panelLeft_GAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_GAA.Location = new System.Drawing.Point(0, 88);
            this.panelLeft_GAA.Name = "panelLeft_GAA";
            this.panelLeft_GAA.Size = new System.Drawing.Size(147, 363);
            this.panelLeft_GAA.TabIndex = 0;
            // 
            // panelRight_GAA
            // 
            this.panelRight_GAA.Controls.Add(this.chartInfo_GAA);
            this.panelRight_GAA.Controls.Add(this.splitterMain_GAA);
            this.panelRight_GAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_GAA.Location = new System.Drawing.Point(147, 88);
            this.panelRight_GAA.Name = "panelRight_GAA";
            this.panelRight_GAA.Size = new System.Drawing.Size(647, 363);
            this.panelRight_GAA.TabIndex = 0;
            // 
            // groupBoxCon_GAA
            // 
            this.groupBoxCon_GAA.Controls.Add(this.labelCon_GAA);
            this.groupBoxCon_GAA.Location = new System.Drawing.Point(3, 3);
            this.groupBoxCon_GAA.Name = "groupBoxCon_GAA";
            this.groupBoxCon_GAA.Size = new System.Drawing.Size(462, 79);
            this.groupBoxCon_GAA.TabIndex = 0;
            this.groupBoxCon_GAA.TabStop = false;
            this.groupBoxCon_GAA.Text = "Условие:";
            // 
            // labelCon_GAA
            // 
            this.labelCon_GAA.AutoSize = true;
            this.labelCon_GAA.Location = new System.Drawing.Point(12, 21);
            this.labelCon_GAA.Name = "labelCon_GAA";
            this.labelCon_GAA.Size = new System.Drawing.Size(383, 26);
            this.labelCon_GAA.TabIndex = 0;
            this.labelCon_GAA.Text = "Прочитать данные из файла InPutFileTask5V5.txt. Вывести в dataGridView. \r\nВывести" +
    " все числа, кратные 2. Построить диаграмму по этим значениям";
            // 
            // splitterMain_GAA
            // 
            this.splitterMain_GAA.Location = new System.Drawing.Point(0, 0);
            this.splitterMain_GAA.Name = "splitterMain_GAA";
            this.splitterMain_GAA.Size = new System.Drawing.Size(3, 363);
            this.splitterMain_GAA.TabIndex = 0;
            this.splitterMain_GAA.TabStop = false;
            // 
            // groupBoxOut_GAA
            // 
            this.groupBoxOut_GAA.Controls.Add(this.dataGridViewOut_GAA);
            this.groupBoxOut_GAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOut_GAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOut_GAA.Name = "groupBoxOut_GAA";
            this.groupBoxOut_GAA.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxOut_GAA.Size = new System.Drawing.Size(147, 363);
            this.groupBoxOut_GAA.TabIndex = 0;
            this.groupBoxOut_GAA.TabStop = false;
            this.groupBoxOut_GAA.Text = "Вывод данных:";
            // 
            // dataGridViewOut_GAA
            // 
            this.dataGridViewOut_GAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_GAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOut_GAA.Location = new System.Drawing.Point(5, 18);
            this.dataGridViewOut_GAA.Name = "dataGridViewOut_GAA";
            this.dataGridViewOut_GAA.Size = new System.Drawing.Size(137, 340);
            this.dataGridViewOut_GAA.TabIndex = 0;
            // 
            // buttonDone_GAA
            // 
            this.buttonDone_GAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDone_GAA.Location = new System.Drawing.Point(471, 12);
            this.buttonDone_GAA.Name = "buttonDone_GAA";
            this.buttonDone_GAA.Size = new System.Drawing.Size(101, 70);
            this.buttonDone_GAA.TabIndex = 1;
            this.buttonDone_GAA.Text = "Выполнить";
            this.buttonDone_GAA.UseVisualStyleBackColor = true;
            this.buttonDone_GAA.Click += new System.EventHandler(this.buttonDone_GAA_Click);
            // 
            // buttonOpen_GAA
            // 
            this.buttonOpen_GAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpen_GAA.Location = new System.Drawing.Point(578, 12);
            this.buttonOpen_GAA.Name = "buttonOpen_GAA";
            this.buttonOpen_GAA.Size = new System.Drawing.Size(101, 70);
            this.buttonOpen_GAA.TabIndex = 1;
            this.buttonOpen_GAA.Text = "Открыть\r\n файл";
            this.buttonOpen_GAA.UseVisualStyleBackColor = true;
            this.buttonOpen_GAA.Click += new System.EventHandler(this.buttonOpen_GAA_Click);
            // 
            // buttonInfo_GAA
            // 
            this.buttonInfo_GAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_GAA.Location = new System.Drawing.Point(685, 12);
            this.buttonInfo_GAA.Name = "buttonInfo_GAA";
            this.buttonInfo_GAA.Size = new System.Drawing.Size(101, 70);
            this.buttonInfo_GAA.TabIndex = 1;
            this.buttonInfo_GAA.Text = "Справка";
            this.buttonInfo_GAA.UseVisualStyleBackColor = true;
            this.buttonInfo_GAA.Click += new System.EventHandler(this.buttonInfo_GAA_Click);
            // 
            // chartInfo_GAA
            // 
            chartArea6.Name = "ChartArea1";
            this.chartInfo_GAA.ChartAreas.Add(chartArea6);
            this.chartInfo_GAA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.Name = "Legend1";
            this.chartInfo_GAA.Legends.Add(legend6);
            this.chartInfo_GAA.Location = new System.Drawing.Point(3, 0);
            this.chartInfo_GAA.Name = "chartInfo_GAA";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartInfo_GAA.Series.Add(series6);
            this.chartInfo_GAA.Size = new System.Drawing.Size(644, 363);
            this.chartInfo_GAA.TabIndex = 1;
            this.chartInfo_GAA.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 451);
            this.Controls.Add(this.panelRight_GAA);
            this.Controls.Add(this.panelLeft_GAA);
            this.Controls.Add(this.panelUp_GAA);
            this.MinimumSize = new System.Drawing.Size(810, 490);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт #6 │ Выполнил: Горбунов А.А. │ ИИПб-23-2";
            this.panelUp_GAA.ResumeLayout(false);
            this.panelLeft_GAA.ResumeLayout(false);
            this.panelRight_GAA.ResumeLayout(false);
            this.groupBoxCon_GAA.ResumeLayout(false);
            this.groupBoxCon_GAA.PerformLayout();
            this.groupBoxOut_GAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_GAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartInfo_GAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUp_GAA;
        private System.Windows.Forms.GroupBox groupBoxCon_GAA;
        private System.Windows.Forms.Panel panelLeft_GAA;
        private System.Windows.Forms.Panel panelRight_GAA;
        private System.Windows.Forms.Button buttonInfo_GAA;
        private System.Windows.Forms.Button buttonOpen_GAA;
        private System.Windows.Forms.Button buttonDone_GAA;
        private System.Windows.Forms.Label labelCon_GAA;
        private System.Windows.Forms.GroupBox groupBoxOut_GAA;
        private System.Windows.Forms.DataGridView dataGridViewOut_GAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartInfo_GAA;
        private System.Windows.Forms.Splitter splitterMain_GAA;
    }
}

