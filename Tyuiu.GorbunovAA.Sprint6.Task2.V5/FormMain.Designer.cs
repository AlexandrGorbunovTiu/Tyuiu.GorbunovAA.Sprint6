
namespace Tyuiu.GorbunovAA.Sprint6.Task2.V5
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxCondition_GAA = new System.Windows.Forms.GroupBox();
            this.groupBoxIn_GAA = new System.Windows.Forms.GroupBox();
            this.groupBoxOut_GAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewFunc_GAA = new System.Windows.Forms.DataGridView();
            this.ColumnX_GAA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFx_GAA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDone_GAA = new System.Windows.Forms.Button();
            this.buttonInfo_GAA = new System.Windows.Forms.Button();
            this.labelResult_GAA = new System.Windows.Forms.Label();
            this.textBoxStart_GAA = new System.Windows.Forms.TextBox();
            this.textBoxStop_GAA = new System.Windows.Forms.TextBox();
            this.labelStart_GAA = new System.Windows.Forms.Label();
            this.labelEnd_GAA = new System.Windows.Forms.Label();
            this.labelCondition_GAA = new System.Windows.Forms.Label();
            this.chartFunction_GAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxCondition_GAA.SuspendLayout();
            this.groupBoxIn_GAA.SuspendLayout();
            this.groupBoxOut_GAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunc_GAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_GAA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_GAA
            // 
            this.groupBoxCondition_GAA.Controls.Add(this.labelCondition_GAA);
            this.groupBoxCondition_GAA.Location = new System.Drawing.Point(29, 21);
            this.groupBoxCondition_GAA.Name = "groupBoxCondition_GAA";
            this.groupBoxCondition_GAA.Size = new System.Drawing.Size(480, 319);
            this.groupBoxCondition_GAA.TabIndex = 0;
            this.groupBoxCondition_GAA.TabStop = false;
            this.groupBoxCondition_GAA.Text = "Условие";
            // 
            // groupBoxIn_GAA
            // 
            this.groupBoxIn_GAA.Controls.Add(this.labelEnd_GAA);
            this.groupBoxIn_GAA.Controls.Add(this.labelStart_GAA);
            this.groupBoxIn_GAA.Controls.Add(this.textBoxStop_GAA);
            this.groupBoxIn_GAA.Controls.Add(this.textBoxStart_GAA);
            this.groupBoxIn_GAA.Location = new System.Drawing.Point(26, 346);
            this.groupBoxIn_GAA.Name = "groupBoxIn_GAA";
            this.groupBoxIn_GAA.Size = new System.Drawing.Size(267, 65);
            this.groupBoxIn_GAA.TabIndex = 1;
            this.groupBoxIn_GAA.TabStop = false;
            this.groupBoxIn_GAA.Text = "Ввод данных";
            // 
            // groupBoxOut_GAA
            // 
            this.groupBoxOut_GAA.Controls.Add(this.chartFunction_GAA);
            this.groupBoxOut_GAA.Controls.Add(this.labelResult_GAA);
            this.groupBoxOut_GAA.Controls.Add(this.dataGridViewFunc_GAA);
            this.groupBoxOut_GAA.Location = new System.Drawing.Point(523, 21);
            this.groupBoxOut_GAA.Name = "groupBoxOut_GAA";
            this.groupBoxOut_GAA.Size = new System.Drawing.Size(601, 390);
            this.groupBoxOut_GAA.TabIndex = 2;
            this.groupBoxOut_GAA.TabStop = false;
            this.groupBoxOut_GAA.Text = "Вывод Данных";
            // 
            // dataGridViewFunc_GAA
            // 
            this.dataGridViewFunc_GAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunc_GAA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX_GAA,
            this.ColumnFx_GAA});
            this.dataGridViewFunc_GAA.Location = new System.Drawing.Point(23, 35);
            this.dataGridViewFunc_GAA.Name = "dataGridViewFunc_GAA";
            this.dataGridViewFunc_GAA.RowHeadersVisible = false;
            this.dataGridViewFunc_GAA.Size = new System.Drawing.Size(171, 349);
            this.dataGridViewFunc_GAA.TabIndex = 0;
            // 
            // ColumnX_GAA
            // 
            this.ColumnX_GAA.FillWeight = 50F;
            this.ColumnX_GAA.HeaderText = "X";
            this.ColumnX_GAA.MaxInputLength = 29767;
            this.ColumnX_GAA.Name = "ColumnX_GAA";
            this.ColumnX_GAA.Width = 75;
            // 
            // ColumnFx_GAA
            // 
            this.ColumnFx_GAA.FillWeight = 50F;
            this.ColumnFx_GAA.HeaderText = "F(X)";
            this.ColumnFx_GAA.Name = "ColumnFx_GAA";
            this.ColumnFx_GAA.Width = 75;
            // 
            // buttonDone_GAA
            // 
            this.buttonDone_GAA.Location = new System.Drawing.Point(391, 352);
            this.buttonDone_GAA.Name = "buttonDone_GAA";
            this.buttonDone_GAA.Size = new System.Drawing.Size(118, 46);
            this.buttonDone_GAA.TabIndex = 3;
            this.buttonDone_GAA.Text = "Выполнить";
            this.buttonDone_GAA.UseVisualStyleBackColor = true;
            this.buttonDone_GAA.Click += new System.EventHandler(this.buttonDone_GAA_Click);
            // 
            // buttonInfo_GAA
            // 
            this.buttonInfo_GAA.Location = new System.Drawing.Point(299, 352);
            this.buttonInfo_GAA.Name = "buttonInfo_GAA";
            this.buttonInfo_GAA.Size = new System.Drawing.Size(86, 46);
            this.buttonInfo_GAA.TabIndex = 4;
            this.buttonInfo_GAA.Text = "Справка";
            this.buttonInfo_GAA.UseVisualStyleBackColor = true;
            // 
            // labelResult_GAA
            // 
            this.labelResult_GAA.AutoSize = true;
            this.labelResult_GAA.Location = new System.Drawing.Point(20, 19);
            this.labelResult_GAA.Name = "labelResult_GAA";
            this.labelResult_GAA.Size = new System.Drawing.Size(62, 13);
            this.labelResult_GAA.TabIndex = 1;
            this.labelResult_GAA.Text = "Результат:";
            this.labelResult_GAA.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxStart_GAA
            // 
            this.textBoxStart_GAA.Location = new System.Drawing.Point(16, 32);
            this.textBoxStart_GAA.Name = "textBoxStart_GAA";
            this.textBoxStart_GAA.Size = new System.Drawing.Size(117, 20);
            this.textBoxStart_GAA.TabIndex = 0;
            this.textBoxStart_GAA.Text = "-5";
            // 
            // textBoxStop_GAA
            // 
            this.textBoxStop_GAA.Location = new System.Drawing.Point(139, 32);
            this.textBoxStop_GAA.Name = "textBoxStop_GAA";
            this.textBoxStop_GAA.Size = new System.Drawing.Size(122, 20);
            this.textBoxStop_GAA.TabIndex = 1;
            this.textBoxStop_GAA.Text = "5";
            // 
            // labelStart_GAA
            // 
            this.labelStart_GAA.AutoSize = true;
            this.labelStart_GAA.Location = new System.Drawing.Point(13, 16);
            this.labelStart_GAA.Name = "labelStart_GAA";
            this.labelStart_GAA.Size = new System.Drawing.Size(67, 13);
            this.labelStart_GAA.TabIndex = 2;
            this.labelStart_GAA.Text = "Старт шага:";
            // 
            // labelEnd_GAA
            // 
            this.labelEnd_GAA.AutoSize = true;
            this.labelEnd_GAA.Location = new System.Drawing.Point(136, 16);
            this.labelEnd_GAA.Name = "labelEnd_GAA";
            this.labelEnd_GAA.Size = new System.Drawing.Size(70, 13);
            this.labelEnd_GAA.TabIndex = 3;
            this.labelEnd_GAA.Text = "Конец Шага:";
            // 
            // labelCondition_GAA
            // 
            this.labelCondition_GAA.AutoSize = true;
            this.labelCondition_GAA.Location = new System.Drawing.Point(15, 26);
            this.labelCondition_GAA.Name = "labelCondition_GAA";
            this.labelCondition_GAA.Size = new System.Drawing.Size(344, 13);
            this.labelCondition_GAA.TabIndex = 0;
            this.labelCondition_GAA.Text = "Вывести таблицу значений функции на заданном ниже диапозоне";
            this.labelCondition_GAA.Click += new System.EventHandler(this.labelCondition_GAA_Click);
            // 
            // chartFunction_GAA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction_GAA.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chartFunction_GAA.Legends.Add(legend2);
            this.chartFunction_GAA.Location = new System.Drawing.Point(224, 38);
            this.chartFunction_GAA.Name = "chartFunction_GAA";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction_GAA.Series.Add(series2);
            this.chartFunction_GAA.Size = new System.Drawing.Size(351, 345);
            this.chartFunction_GAA.TabIndex = 2;
            this.chartFunction_GAA.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 419);
            this.Controls.Add(this.buttonInfo_GAA);
            this.Controls.Add(this.buttonDone_GAA);
            this.Controls.Add(this.groupBoxOut_GAA);
            this.Controls.Add(this.groupBoxIn_GAA);
            this.Controls.Add(this.groupBoxCondition_GAA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт #6 │ Выполнил: Горбунов А.А. │ ИИПб-23-2";
            this.groupBoxCondition_GAA.ResumeLayout(false);
            this.groupBoxCondition_GAA.PerformLayout();
            this.groupBoxIn_GAA.ResumeLayout(false);
            this.groupBoxIn_GAA.PerformLayout();
            this.groupBoxOut_GAA.ResumeLayout(false);
            this.groupBoxOut_GAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunc_GAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_GAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_GAA;
        private System.Windows.Forms.GroupBox groupBoxIn_GAA;
        private System.Windows.Forms.GroupBox groupBoxOut_GAA;
        private System.Windows.Forms.Label labelResult_GAA;
        private System.Windows.Forms.DataGridView dataGridViewFunc_GAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX_GAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFx_GAA;
        private System.Windows.Forms.Button buttonDone_GAA;
        private System.Windows.Forms.Button buttonInfo_GAA;
        private System.Windows.Forms.Label labelCondition_GAA;
        private System.Windows.Forms.Label labelEnd_GAA;
        private System.Windows.Forms.Label labelStart_GAA;
        private System.Windows.Forms.TextBox textBoxStop_GAA;
        private System.Windows.Forms.TextBox textBoxStart_GAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_GAA;
    }
}

