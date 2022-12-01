using appTeach_ICTU.Views.phonghoc;
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

namespace appTeach_ICTU.Views
{
    public partial class QLiPhongHoc : Form
    {
        private ViewModels.PhongHocViewModel _vm = new PhongHocViewModel();
        public QLiPhongHoc()
        {
            InitializeComponent();
            _vm.phonghocBindingSource = phong_hocBindingSource;
            Load += delegate { _vm.getAll(); };
            btnUpdate.Click  += delegate { _vm.update(); };
            btnDelete.Click  += delegate { _vm.delete(); };
        }

        private void QLiPhongHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teachICTUDataSet1.phong_hoc' table. You can move, or remove it, as needed.
            this.phong_hocTableAdapter.Fill(this.teachICTUDataSet1.phong_hoc);
            // TODO: This line of code loads data into the 'teachICTUDataSet.phong_hoc' table. You can move, or remove it, as needed.
            //this.phong_hocTableAdapter.Fill(this.teachICTUDataSet.phong_hoc);

        }
        public void reload(bool isReload)
        {
            _vm.getAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddPhongHoc(reload).Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Close();
        }
    }
}
