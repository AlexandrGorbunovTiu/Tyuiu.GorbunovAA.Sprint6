using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GorbunovAA.Sprint6.Task5.V5.Lib;

namespace Tyuiu.GorbunovAA.Sprint6.Task5.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\Users\shura\source\repos\Tyuiu.GorbunovAA.Sprint6\Tyuiu.GorbunovAA.Sprint6.Task5.V5\bin\Debug\InPutFileTask5V5.txt";

        private void buttonDone_GAA_Click(object sender, EventArgs e)
        {
            dataGridViewOut_GAA.ColumnCount = 2;
            dataGridViewOut_GAA.Columns[0].Width = 20;
            dataGridViewOut_GAA.Columns[1].Width = 50;

            this.chartInfo_GAA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartInfo_GAA.ChartAreas[0].AxisY.Title = "Ось Y";

            chartInfo_GAA.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewOut_GAA.Rows.Add(Convert.ToString(i+1), Convert.ToString(numsMass[i]));
                chartInfo_GAA.Series[0].Points.AddXY(i+1, numsMass[i]);
            }
        }

        private void buttonInfo_GAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПб-23-2 Горбунов Александр      Александрович ", "Сообщение", MessageBoxButtons.OK);
        }

        private void buttonOpen_GAA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
