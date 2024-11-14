using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RC_of_Computer
{
    public partial class keyconfigWindow : Form
    {
        public keyconfigWindow()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            keyconfigSet();
        }

        private void arrow_buttonGroup_Enter(object sender, EventArgs e)
        {
            keyconfigSet();
        }

        private void ahead_button_Click(object sender, EventArgs e)
        {
            keyconfigSet();
        }

        private void sub_button1_Click(object sender, EventArgs e)
        {
            keyconfigSet();
        }

        private void sub_button2_Click(object sender, EventArgs e)
        {
            keyconfigSet();
        }

        private void sub_button3_Click(object sender, EventArgs e)
        {
            keyconfigSet();
        }

        private void sub_button4_Click(object sender, EventArgs e)
        {
            keyconfigSet();
        }

        private void sub_button5_Click(object sender, EventArgs e)
        {
            keyconfigSet();
        }

        private void sub_button6_Click(object sender, EventArgs e)
        {
            keyconfigSet();
        }

        private void sub_button7_Click(object sender, EventArgs e)
        {
            keyconfigSet();
        }

        private void sub_button8_Click(object sender, EventArgs e)
        {
            keyconfigSet();
        }

        private void sub_button9_Click(object sender, EventArgs e)
        {
            keyconfigSet();
        }

        private void keyconfigSet()
        {
            MessageBox.Show("キーを入力してください");

        }

        
    }
}
