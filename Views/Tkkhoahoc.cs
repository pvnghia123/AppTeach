using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewModels.ViewModel;

namespace appTeach_ICTU.Views
{
    public partial class Tkkhoahoc : Form
    {
        KhoahocViewModel _vm = new KhoahocViewModel();
        public Tkkhoahoc()
        {
            InitializeComponent();
            _vm.khoahocBindingSource = khoahocResponseBindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _vm.getKhoahoc(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Close();
        }
    }
}
