using appTeach_ICTU.Views.teacher;
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
    public partial class QliNguoiday : Form
    {
        //public delegate void Reload(bool isReload);
        private readonly TeacherViewModel _vm;
        public QliNguoiday()
        {
            InitializeComponent();
            _vm = new TeacherViewModel();
            _vm.teacherBindingSource = teacherResponseBindingSource;
            Load += delegate { _vm.load(); };
            btnUpdate.Click+= delegate { _vm.update(); };
            btnDelete.Click+= delegate { _vm.delete(); };   
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddTeacher(reload).Show();
        }
        public void reload(bool isreload)
        {
            _vm.load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Close();
        }
    }
}
