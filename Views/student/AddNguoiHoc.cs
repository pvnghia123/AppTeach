using Model.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewModels.ViewModel.Interface;
using static appTeach_ICTU.Views.QliNguoiHoc;

namespace appTeach_ICTU.Views.student
{
    public partial class AddNguoiHoc : Form
    {
        private StudentViewModel _vmstudent = new StudentViewModel();
        public QliNguoiHoc.Reload reload;
        public AddNguoiHoc()
        {
            InitializeComponent();
            _vmstudent.userBindingSource = studentResponseBindingSource;
            //btnAdd.Click += delegate { add(studentResponseBindingSource); };
        }
        public AddNguoiHoc(Reload reload)
        {
            this.reload = reload;
            InitializeComponent();
            _vmstudent.userBindingSource = studentResponseBindingSource;
            //btnAdd.Click += delegate { add(studentResponseBindingSource); };
        }
        public void add()
        {
            var a =_vmstudent.add();
            if(a!= null)
            {
                this.Close();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var student = new studentResponse
            {
                birthday= birthdayDateEdit.DateTime,
                CCCD_CMT = cCCD_CMTTextEdit.Text,
                class_name = class_nameTextEdit.Text,
                email = emailTextEdit.Text,
                he_dao_tao = he_dao_taoTextEdit.Text,
                khoa = khoaTextEdit.Text,
                name = nameTextEdit.Text,
                phone= phoneTextEdit.Text,
                place_of_birth = place_of_birthTextEdit.Text,
            };
          var result = _vmstudent.add(student);
            if(result!= null )
            {
                this.reload(true);
                this.Close();
                
            }
        }
    }
}
