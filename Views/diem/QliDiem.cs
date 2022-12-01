using appTeach_ICTU.Views.diem;
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
    public partial class QliDiem : Form
    {
        private DiemViewmodel _vm = new DiemViewmodel();
        public QliDiem()
        {
            InitializeComponent();
            _vm.bindingSource = diemResponseBindingSource;
            Load += delegate { _vm.load(); };
            btnupadte.Click += delegate { _vm.Update(); };
            btnxoa.Click += delegate { _vm.Deleted(); };
        }
        private void reload(bool reload) { 
            _vm.load();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            new Adddiem(reload).Show();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Close();
        }
    }
}
