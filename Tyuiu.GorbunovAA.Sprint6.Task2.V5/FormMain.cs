using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GorbunovAA.Sprint6.Task2.V5.Lib;

namespace Tyuiu.GorbunovAA.Sprint6.Task2.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelCondition_GAA_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_GAA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_GAA.Text);
                int stopStep = Convert.ToInt32(textBoxStop_GAA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_GAA.Titles.Add("График функции F(X)");

                this.chartFunction_GAA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_GAA.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len -1; i++ )
                {
                    this.dataGridViewFunc_GAA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_GAA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
