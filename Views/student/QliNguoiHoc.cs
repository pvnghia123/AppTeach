using appTeach_ICTU.Views.student;
using Model;
using Model.model;
using Model.model.sql;
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
using ViewModels.ViewModel.Interface;

namespace appTeach_ICTU.Views
{
    public partial class QliNguoiHoc : Form
    {
        public delegate void Reload(bool isReload);
        private StudentViewModel _vmstudent = new StudentViewModel();
        public QliNguoiHoc()
        {
            InitializeComponent();
            _vmstudent.userBindingSource = studentResponseBindingSource;
            Load += delegate { _vmstudent.load(); };
            btnupdate.Click += delegate { _vmstudent.update(); _vmstudent.load(); };
            btndelete.Click += delegate { _vmstudent.delete(); };
        }
        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
            new Main().Show();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            new AddNguoiHoc(reload).ShowDialog();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            _vmstudent.load();
        }
        private void reload(bool isReload)
        {
            _vmstudent.load();
        }
    }
}
