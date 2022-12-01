using appTeach_ICTU.Views.khoahoc;
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
    public partial class QLilKhoaHoc : Form
    {
        private KhoahocViewModel _vm = new KhoahocViewModel();
        public QLilKhoaHoc()
        {
            InitializeComponent();
            _vm.khoahocBindingSource = khoahocResponseBindingSource;
            Load += delegate { _vm.getAll(); };
            //btnAdd.Click += delegate { _vm.add(); };
            btnUpdate.Click += delegate { _vm.update(); };
            btnDelete.Click += delegate { _vm.delete(); };
        }

        private void QLilKhoaHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teachICTUDataSet1.khoa_hoc' table. You can move, or remove it, as needed.
           // this.khoa_hocTableAdapter.Fill(this.teachICTUDataSet1.khoa_hoc);
            // TODO: This line of code loads data into the 'teachICTUDataSet1.khoa_hoc' table. You can move, or remove it, as needed.
           // this.khoa_hocTableAdapter.Fill(this.teachICTUDataSet1.khoa_hoc);
            // TODO: This line of code loads data into the 'teachICTUDataSet.khoa_hoc' table. You can move, or remove it, as needed.
           // this.khoa_hocTableAdapter.Fill(this.teachICTUDataSet1.khoa_hoc);

        }
        public void reload(bool isReload)
        {
            _vm.getAll();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddKhoaHoc(reload).ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Close();
        }
    }
}
