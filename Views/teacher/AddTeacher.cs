using Microsoft.Extensions.Configuration;
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
using ViewModels.ViewModel;
using static appTeach_ICTU.Views.QliNguoiHoc;

namespace appTeach_ICTU.Views.teacher
{
    public partial class AddTeacher : Form
    {
        private Reload reload;
        private TeacherViewModel _vm = new TeacherViewModel();
        public AddTeacher()
        {
            InitializeComponent();
        }
        public AddTeacher(Reload reload)
        {
            InitializeComponent();
            this.reload = reload;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var teacherReponse = new TeacherResponse
            {
                birthday = birthdayDateEdit.DateTime,
                bo_phan = bo_phanTextEdit.Text,
                CCCD_CMT = cCCD_CMTTextEdit.Text,
                chuyenh_nganh = chuyenh_nganhTextEdit.Text,
                email = emailTextEdit.Text,
                name = nameTextEdit.Text,
                phone = phoneTextEdit.Text,
                place_of_birth = chuyenh_nganhTextEdit.Text
            };
            _vm.add(teacherReponse);

            this.reload(true);
        }
    }
}
