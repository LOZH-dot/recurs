using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recurs_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int N = 0;

            try
            {
                N = int.Parse(NTextBox.Text);

                if (N <= 0) throw new Exception();
            }
            catch
            {
                MessageBox.Show("Ошибка: ожидается ввод натурального числа");
                return;
            }

            MessageBox.Show($"Результат: {N/f(1, N)}");
        }

        private double f(int a, double N)
        {
            if (a == N)
            {
                return Math.Sqrt(a);
            }

            return Math.Sqrt(a + f(a + 1, N));
        }
    }
}
