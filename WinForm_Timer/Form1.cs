using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Timer
{    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            stop_button.Enabled = false;
            start_button.Enabled = false;
            timer1.Tick += new EventHandler(Show_timer1);
        }
        private void Show_timer1(object sender, EventArgs e)
        {
            if (t1.Value > 0) t1.Value--;
            else if (t1.Value < 1) 
            {
                timer1.Stop();
                MessageBox.Show("Таймер остановлен", "Таймер", MessageBoxButtons.OK);
            }
            
        }
        private void start_button_Click(object sender, EventArgs e)
        {
            if (t1.Value>0)
            {
                stop_button.Enabled = true;
                start_button.Enabled = false;
                timer1.Start();
            }
            
        }
        private void stop_button_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            DialogResult res = MessageBox.Show($"Остаток времени: {t1.Value} секунд\nВозобновить?", "Таймер", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                stop_button.Enabled = false;
                start_button.Enabled = true;
            }
            else if (res == DialogResult.No)
            {
                t1.Value = 0;
                stop_button.Enabled = false;
            }
           
        }
        private void t1_Click(object sender, EventArgs e)
        {
            if (t1.Value>0)
            {
                start_button.Enabled = true;
            }
        }
    }
}
