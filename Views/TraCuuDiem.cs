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
    public partial class TraCuuDiem : Form
    {
        private DiemViewmodel _vm = new DiemViewmodel();
        public TraCuuDiem()
        {
            InitializeComponent();
            _vm.bindingSource = diemResponseBindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var text = txtName.Text;
            _vm.getAllDiem(text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Close();
        }
    }
}
