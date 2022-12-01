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
using ViewModels;

namespace appTeach_ICTU.Views.phonghoc
{
    public partial class AddPhongHoc : Form
    {
        private readonly PhongHocViewModel _vm = new PhongHocViewModel();
        private QliNguoiHoc.Reload reload;
        public AddPhongHoc()
        {
            InitializeComponent();
            
        }
        public AddPhongHoc(QliNguoiHoc.Reload reload)
        {
            InitializeComponent();
            this.reload = reload;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var p = new Model.model.sql.phonghoc
            {
                id = Guid.NewGuid(),
                nguoi_tao = common.current_name,
                ten_phong_hoc = txtName.Text,
                trang_thai = cbIsActive.Checked
            }; 
            _vm.add(p);
            reload(true);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}
