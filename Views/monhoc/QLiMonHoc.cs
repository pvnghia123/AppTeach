using appTeach_ICTU.Views.monhoc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewModels;
using ViewModels.ViewModel;

namespace appTeach_ICTU.Views
{
    public partial class QLiMonHoc : Form
    {
        private MonHocViewModel _vm = new MonHocViewModel();    
        public QLiMonHoc()
        {
            InitializeComponent();
            _vm.bindingSource = monhocBindingSource;
            Load += delegate { _vm.load(); };
            btnupdate.Click += delegate { _vm.update(); };
            btnXoa.Click += delegate { _vm.delete(); };
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void monhocBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.monhocBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.teachICTUDataSet1);

        }

        private void QLiMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teachICTUDataSet1.monhoc' table. You can move, or remove it, as needed.
            this.monhocTableAdapter.Fill(this.teachICTUDataSet1.monhoc);

        }
        private void reload(bool isreload)
        {
            _vm.load();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddMonHoc(reload).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Close();
        }
    }
}
