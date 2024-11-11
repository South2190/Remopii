using RC_of_Computer.FunctionSetup;
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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void setup_Box_Enter(object sender, EventArgs e)
        {

        }

        private void PHP_button_Click(object sender, EventArgs e)
        {
            var PHP = new PHP();
            PHP.Show();
        }
    }
}
