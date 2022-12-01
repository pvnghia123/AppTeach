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

namespace appTeach_ICTU.Views.login
{
    public partial class dangki : Form
    {
        private UserViewModel _userVM = new UserViewModel();
        private LoginViewModel _loginVM = new LoginViewModel();
        private TeacherViewModel _teacherVM = new TeacherViewModel();
        private StudentViewModel _studentVM = new StudentViewModel();
        public dangki()
        {
            InitializeComponent();
            cbbType_user.SelectedIndex = 0;
            panelTeacher.Hide();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.teachICTUDataSet1);

        }

        private void dangki_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teachICTUDataSet1.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.teachICTUDataSet1.users);
        }

        private void cbbType_user_SelectedIndexChanged(object sender, EventArgs e)
        {
            var select = cbbType_user.SelectedIndex;
            if(select == 0)
            {
                panelStudent.Visible = true;
                panelTeacher.Hide();
            }else
            {
                panelTeacher.Visible = true;
                panelStudent.Hide();
                
            }
        }
        private void btnDangki_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextEdit.Text))
            {
                MessageBox.Show("Họ và tên trống");
            }else if (string.IsNullOrEmpty(emailTextEdit.Text))
            {
                MessageBox.Show("Email trống");
            }
            else if (string.IsNullOrEmpty(birthdayDateEdit.Text))
            {
                MessageBox.Show("ngày sinh trống");
            }
            else if (string.IsNullOrEmpty(cCCD_CMTTextEdit.Text))
            {
                MessageBox.Show("CCCD/CMT trống");
            }
            else if (string.IsNullOrEmpty(txtMk.Text))
            {
                MessageBox.Show("Password trống");
            }
            else if (string.IsNullOrEmpty(txtmk2.Text))
            {
                MessageBox.Show("xác nhận Password trống");
            }

            if(cbbType_user.SelectedIndex == 0)
            {
                if (string.IsNullOrEmpty(txtClassname.Text))
                {
                    MessageBox.Show("Tên lớp trống");
                }else if (string.IsNullOrEmpty(txtHe_dao_tao.Text))
                {
                    MessageBox.Show("hệ đào tạo trống");
                }
                else if (string.IsNullOrEmpty(txtKhoa_hoc.Text))
                {
                    MessageBox.Show("khóa học trống");
                }
            } else
            {
                if (string.IsNullOrEmpty(txtBo_Phan.Text))
                {
                    MessageBox.Show("Bộ phận trống");
                }
                else if (string.IsNullOrEmpty(txtChuyen_nganh.Text))
                {
                    MessageBox.Show("Chuyên ngành trống");
                }
            }
            if(txtMk.Text != txtmk2.Text)
            {
                MessageBox.Show("Mật khẩu khác nhau trống");
                return;
            }
            //dang_ki
            //var login = new Model.model.sql.login
            //{
            //    id = Guid.NewGuid(),
            //    password = txtMk.Text,
            //    user_name = nameTextEdit.Text,
            //    type_user = cbbType_user.SelectedIndex + 2 
            //};
            var loginSave = _loginVM.dang_ki(nameTextEdit.Text, txtMk.Text, cbbType_user.SelectedIndex + 2);
            if(loginSave != null)
            {
                var user = new users
                {
                    id = Guid.NewGuid(),
                    name = nameTextEdit.Text,
                    email = emailTextEdit.Text,
                    birthday = birthdayDateEdit.DateTime,
                    CCCD_CMT = cCCD_CMTTextEdit.Text,
                    phone = phoneTextEdit.Text,
                    place_of_birth = place_of_birthTextEdit.Text,
                    create_by = nameTextEdit.Text,
                    create_time = DateTime.Now,
                    IdLogin = loginSave.id
                };
                var userSave = _userVM.add(user);
                if(userSave != null)
                {
                    if(cbbType_user.SelectedIndex == 0)// sinh vien
                    {
                        var student = new Model.model.sql.student
                        { 
                            id = Guid.NewGuid(),
                            class_name = txtClassname.Text,
                            he_dao_tao = txtHe_dao_tao.Text,
                            khoa_hoc = txtKhoa_hoc.Text,
                            id_user = userSave.id
                        };
                        var studentSave = _studentVM.add(student);
                        
                        if (studentSave == null)
                        {
                            MessageBox.Show("Can't not resgiter");
                            return;
                        }
                    } else
                    {
                        var teacher = new Model.model.sql.teacher {
                            ma_giao_vien = Guid.NewGuid(),
                            bo_phan = txtBo_Phan.Text,
                            id_user = userSave.id,
                            chuyen_nganh = txtChuyen_nganh.Text
                        };
                       var teacherSave = _teacherVM.add(teacher);
                        if(teacherSave == null)
                        {
                            MessageBox.Show("Can't not resgiter");
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Can't not resgiter");
                    return;
                }
            }else
            {
                MessageBox.Show("Can't not resgiter");
                return;
            }

            MessageBox.Show("Đăng kí thành công!!");
            this.Close();
        }
    }
}
