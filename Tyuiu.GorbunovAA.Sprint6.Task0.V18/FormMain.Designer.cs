
namespace Tyuiu.GorbunovAA.Sprint6.Task0.V18
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
            this.textBoxWinX_GAA = new System.Windows.Forms.TextBox();
            this.buttonDone_GA = new System.Windows.Forms.Button();
            this.textBoxResultOne_GAA = new System.Windows.Forms.TextBox();
            this.groupBoxEnter_GAA = new System.Windows.Forms.GroupBox();
            this.labelX_GAA = new System.Windows.Forms.Label();
            this.groupBoxOut_GAA = new System.Windows.Forms.GroupBox();
            this.labelResult_GAA = new System.Windows.Forms.Label();
            this.groupBoxCon_GAA = new System.Windows.Forms.GroupBox();
            this.labelCondition_GAA = new System.Windows.Forms.Label();
            this.buttonhelp_GAA = new System.Windows.Forms.Button();
            this.groupBoxEnter_GAA.SuspendLayout();
            this.groupBoxOut_GAA.SuspendLayout();
            this.groupBoxCon_GAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxWinX_GAA
            // 
            this.textBoxWinX_GAA.Location = new System.Drawing.Point(6, 48);
            this.textBoxWinX_GAA.Name = "textBoxWinX_GAA";
            this.textBoxWinX_GAA.Size = new System.Drawing.Size(95, 20);
            this.textBoxWinX_GAA.TabIndex = 0;
            this.textBoxWinX_GAA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWinX_GAA_KeyPress);
            // 
            // buttonDone_GA
            // 
            this.buttonDone_GA.Location = new System.Drawing.Point(602, 395);
            this.buttonDone_GA.Name = "buttonDone_GA";
            this.buttonDone_GA.Size = new System.Drawing.Size(124, 44);
            this.buttonDone_GA.TabIndex = 1;
            this.buttonDone_GA.Text = "Выполнить";
            this.buttonDone_GA.UseVisualStyleBackColor = true;
            this.buttonDone_GA.Click += new System.EventHandler(this.buttonDone_GA_Click);
            // 
            // textBoxResultOne_GAA
            // 
            this.textBoxResultOne_GAA.Enabled = false;
            this.textBoxResultOne_GAA.Location = new System.Drawing.Point(6, 48);
            this.textBoxResultOne_GAA.Name = "textBoxResultOne_GAA";
            this.textBoxResultOne_GAA.Size = new System.Drawing.Size(209, 20);
            this.textBoxResultOne_GAA.TabIndex = 2;
            // 
            // groupBoxEnter_GAA
            // 
            this.groupBoxEnter_GAA.Controls.Add(this.labelX_GAA);
            this.groupBoxEnter_GAA.Controls.Add(this.textBoxWinX_GAA);
            this.groupBoxEnter_GAA.Location = new System.Drawing.Point(31, 302);
            this.groupBoxEnter_GAA.Name = "groupBoxEnter_GAA";
            this.groupBoxEnter_GAA.Size = new System.Drawing.Size(435, 75);
            this.groupBoxEnter_GAA.TabIndex = 3;
            this.groupBoxEnter_GAA.TabStop = false;
            this.groupBoxEnter_GAA.Text = "Ввод данных";
            // 
            // labelX_GAA
            // 
            this.labelX_GAA.AutoSize = true;
            this.labelX_GAA.Location = new System.Drawing.Point(6, 32);
            this.labelX_GAA.Name = "labelX_GAA";
            this.labelX_GAA.Size = new System.Drawing.Size(17, 13);
            this.labelX_GAA.TabIndex = 1;
            this.labelX_GAA.Text = "X:";
            // 
            // groupBoxOut_GAA
            // 
            this.groupBoxOut_GAA.Controls.Add(this.labelResult_GAA);
            this.groupBoxOut_GAA.Controls.Add(this.textBoxResultOne_GAA);
            this.groupBoxOut_GAA.Location = new System.Drawing.Point(498, 303);
            this.groupBoxOut_GAA.Name = "groupBoxOut_GAA";
            this.groupBoxOut_GAA.Size = new System.Drawing.Size(236, 74);
            this.groupBoxOut_GAA.TabIndex = 4;
            this.groupBoxOut_GAA.TabStop = false;
            this.groupBoxOut_GAA.Text = "Вывод данных";
            // 
            // labelResult_GAA
            // 
            this.labelResult_GAA.AutoSize = true;
            this.labelResult_GAA.Location = new System.Drawing.Point(3, 32);
            this.labelResult_GAA.Name = "labelResult_GAA";
            this.labelResult_GAA.Size = new System.Drawing.Size(62, 13);
            this.labelResult_GAA.TabIndex = 3;
            this.labelResult_GAA.Text = "Результат:";
            // 
            // groupBoxCon_GAA
            // 
            this.groupBoxCon_GAA.Controls.Add(this.labelCondition_GAA);
            this.groupBoxCon_GAA.Location = new System.Drawing.Point(28, 23);
            this.groupBoxCon_GAA.Name = "groupBoxCon_GAA";
            this.groupBoxCon_GAA.Size = new System.Drawing.Size(684, 253);
            this.groupBoxCon_GAA.TabIndex = 5;
            this.groupBoxCon_GAA.TabStop = false;
            this.groupBoxCon_GAA.Text = "Условие";
            // 
            // labelCondition_GAA
            // 
            this.labelCondition_GAA.AutoSize = true;
            this.labelCondition_GAA.Location = new System.Drawing.Point(9, 33);
            this.labelCondition_GAA.Name = "labelCondition_GAA";
            this.labelCondition_GAA.Size = new System.Drawing.Size(237, 13);
            this.labelCondition_GAA.TabIndex = 0;
            this.labelCondition_GAA.Text = "Вычислить выражение по заданной формуле";
            // 
            // buttonhelp_GAA
            // 
            this.buttonhelp_GAA.Location = new System.Drawing.Point(535, 406);
            this.buttonhelp_GAA.Name = "buttonhelp_GAA";
            this.buttonhelp_GAA.Size = new System.Drawing.Size(48, 23);
            this.buttonhelp_GAA.TabIndex = 6;
            this.buttonhelp_GAA.Text = "?";
            this.buttonhelp_GAA.UseVisualStyleBackColor = true;
            this.buttonhelp_GAA.Click += new System.EventHandler(this.buttonhelp_GAA_Click_1);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 450);
            this.Controls.Add(this.buttonhelp_GAA);
            this.Controls.Add(this.groupBoxCon_GAA);
            this.Controls.Add(this.groupBoxOut_GAA);
            this.Controls.Add(this.groupBoxEnter_GAA);
            this.Controls.Add(this.buttonDone_GA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт #6 │ Выполнил: Горбунов А.А. │ ИИПб-23-2";
            this.groupBoxEnter_GAA.ResumeLayout(false);
            this.groupBoxEnter_GAA.PerformLayout();
            this.groupBoxOut_GAA.ResumeLayout(false);
            this.groupBoxOut_GAA.PerformLayout();
            this.groupBoxCon_GAA.ResumeLayout(false);
            this.groupBoxCon_GAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxWinX_GAA;
        private System.Windows.Forms.Button buttonDone_GA;
        private System.Windows.Forms.TextBox textBoxResultOne_GAA;
        private System.Windows.Forms.GroupBox groupBoxEnter_GAA;
        private System.Windows.Forms.GroupBox groupBoxOut_GAA;
        private System.Windows.Forms.Label labelX_GAA;
        private System.Windows.Forms.Label labelResult_GAA;
        private System.Windows.Forms.GroupBox groupBoxCon_GAA;
        private System.Windows.Forms.Label labelCondition_GAA;
        private System.Windows.Forms.Button buttonhelp_GAA;
    }
}

