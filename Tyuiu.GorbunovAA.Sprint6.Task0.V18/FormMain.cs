﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GorbunovAA.Sprint6.Task0.V18.Lib;

namespace Tyuiu.GorbunovAA.Sprint6.Task0.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_GA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResultOne_GAA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxWinX_GAA.Text)));

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", " Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        private void buttonhelp_GAA_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИИПб-23-2 Горбунов Александр Александрович ", "Сообщение", MessageBoxButtons.OK);
        }

        private void textBoxWinX_GAA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}
