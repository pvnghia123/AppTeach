using appTeach_ICTU.Views.login;
using Model;
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
    public partial class Login : Form
    {
        private LoginViewModel _vm = new LoginViewModel();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // dang nhap
            var username = txtUsername.Text;
            var password = txtMK.Text;
            if(string.IsNullOrEmpty(username))
            {
                MessageBox.Show("username không được để trống");
                return;
            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("password không được để trống");
                return;
            }
            var result  = _vm.login(username, password);
            if (result != null)
            {
                common.current_name = username;
                common.type_user = result.type_user;
                this.Hide();
                new Main().Show();
            }
            else
            {
                MessageBox.Show("sai username or password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //dang ki
            new dangki().Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new QuenMK().Show();
        }
    }
}
