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

namespace appTeach_ICTU.Views.diem
{
    public partial class Adddiem : Form
    {
        private QliNguoiHoc.Reload reload;
        private DiemViewmodel _vm = new DiemViewmodel();
        public Adddiem()
        {
            InitializeComponent();
        }
        public Adddiem( QliNguoiHoc.Reload r)
        {
            InitializeComponent();
            this.reload = r;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var diem = new diemResponse {
                diemheso1 = (float)diemheso1SpinEdit.Value,
                diemheso2 = (float)diemheso2SpinEdit.Value,
                diemTb = ((float)diemheso1SpinEdit.Value + (float)diemheso2SpinEdit.Value)/2,
                id = Guid.NewGuid(),
                khoahoc = khoahocTextEdit.Text ,
                monhoc= monhocTextEdit.Text ,
                name = nameTextEdit.Text 

            };

            _vm.Add(diem);
            reload(true);
        }
    }
}
