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

namespace appTeach_ICTU.Views.monhoc
{
    public partial class AddMonHoc : Form
    {
        public MonHocViewModel _vm = new MonHocViewModel();
        private QliNguoiHoc.Reload reload { get; set; }
        public AddMonHoc()
        {
            InitializeComponent();
        }
        public AddMonHoc(QliNguoiHoc.Reload reload)
        {
            InitializeComponent();
            this.reload = reload;
        }

      
      

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var monhoc = new Model.model.sql.monhoc
            {
               id = Guid.NewGuid(),
               hoc_ki = hoc_kiTextEdit.Text,
               khoa_hoc = khoa_hocTextEdit.Text,
               lop_hoc_phan = lop_hoc_phanTextEdit.Text,
               ma_mon_hoc = ma_mon_hocTextEdit.Text,
               so_tin_chi = (int)so_tin_chiSpinEdit.Value,
               ten_mon_hoc = ten_mon_hocTextEdit.Text,
               thoi_gian_day = thoi_gian_dayDateEdit.DateTime,
               trang_thai    = trang_thaiCheckEdit.Checked,
            };
            _vm.add(monhoc);
            reload(true);
            this.Close();
        }
    }
}
