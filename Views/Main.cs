using Model;
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
using System.Windows.Forms.VisualStyles;
using ViewModels;

namespace appTeach_ICTU.Views
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            hidenView();
        }
        public void hidenView()  
        {
            txtName.Text = common.current_name;
            if(common.type_user == 2)//student
            {
                btnQliMonHoc.Visible = false;
                btnQliPhongHoc.Visible = false;
                btnQliStudent.Visible = false;
                BtnQliDiem.Visible = false;
                BtnQliTeacher.Visible = false;
            }else if(common.type_user == 3)// teacher
            {
                btnTraCuu.Visible = false;
               //btnQliMonHoc.Visible = false;
                btnQliPhongHoc.Visible = false;
                btnQliStudent.Visible = false;
                BtnQliTeacher.Visible = false;
            }
        }
       
        private void Main_Load(object sender, EventArgs e)
        {

        }

      

        private void tblhoidap_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://220.231.119.171/kcntt/(S(cmwpu5gtyild2zioykbpz1p1))/support/default.aspx");

        }

        private void tbltrogiup_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://220.231.119.171/kcntt/(S(cmwpu5gtyild2zioykbpz1p1))/support/default.aspx");

        }

        private void btnQliStudent_Click(object sender, EventArgs e)
        {
            new QliNguoiHoc().Show();
            this.Close();
        }

        private void BtnQliTeacher_Click(object sender, EventArgs e)
        {
            new QliNguoiday().Show();
            this.Close();
        }

        private void btnQliMonHoc_Click(object sender, EventArgs e)
        {
            new QLiMonHoc().Show();
            this.Close();
        }

        private void btnThamGia_Click(object sender, EventArgs e)
        {
            new thamGiakhoahoc().Show();
        }

        private void btnQliPhongHoc_Click(object sender, EventArgs e)
        {
            new QLiPhongHoc().Show();
            this.Close();
        }

        private void btnQliKhoaHoc_Click(object sender, EventArgs e)
        {
            new QLilKhoaHoc().Show();
            this.Close();

        }

        private void BtnQliDiem_Click(object sender, EventArgs e)
        {
            new QliDiem().Show();
            this.Close();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            new TraCuuDiem().Show();
            this.Close();
        }

        private void btnTk_Click(object sender, EventArgs e)
        {
            new Tkkhoahoc().Show();
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }
    }
}
