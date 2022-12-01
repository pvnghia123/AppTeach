using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appTeach_ICTU.Views
{
    public partial class thamGiakhoahoc : Form
    {
        public thamGiakhoahoc()
        {
            InitializeComponent();
        }

        private void btnThamgia_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(txtlink.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Close();
        }
    }
}
