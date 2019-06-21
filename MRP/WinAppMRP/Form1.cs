using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppMRP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void cmdSort_Click(object sender, EventArgs e)
        {
            var array = txtInput.Text.Where(s => char.IsNumber(s)).Select(i => Convert.ToInt32(Convert.ToString(i))).ToArray();
            int max = 0;

            //Конвертируем строку в числа и ищем среди них максимум
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
            }

            int[] amount = new int[max + 1];
            int k = 0;

            //Сортировка подсчетом

            for (int i = 0; i < array.Length; i++)
                amount[array[i]]++;

            // [2, 1, 2, 9]
            // [0, 1, 2, 0, 0, 0, 0, 0, 1]

            for (int i = 0; i <= max; i++)
            {
                // Перезапись изначально заданного массива
                for (int j = 0; j < amount[i]; j++)
                {
                    array[k] = i;
                    k++;
                }
            }


            //Вывод отсортированной последовательности
            foreach (var item in array)
            {
                txtOutput.Text += item + " ";
            }
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtOutput.Clear();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
