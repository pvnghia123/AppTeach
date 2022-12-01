using Model;
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

namespace appTeach_ICTU.Views.khoahoc
{
    public partial class AddKhoaHoc : Form
    {
        private QliNguoiHoc.Reload reload;
        private KhoahocViewModel _vm = new KhoahocViewModel();
        public AddKhoaHoc()
        {
            InitializeComponent();
            //ccbmonhoc.Items = _vm.getAllMonHoc();
            foreach(var a in _vm.getAllMonHoc())
            {
                ccbmonhoc.Items.Add(new { a });
            }
        }
        public AddKhoaHoc(QliNguoiHoc.Reload reload)
        {
            InitializeComponent();
            this.reload = reload;
            ccbmonhoc.DataSource = _vm.getAllMonHoc();
        }
        private void AddKhoaHoc_Load(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var khoahocresponse = new khoahocResponse
            {
                giao_vien = giao_vienTextEdit.Text,
                link_hoc = link_hocTextEdit.Text,
                monhoc = ccbmonhoc.SelectedValue.ToString(),
                nguoi_tao = common.current_name,
                phan_mem_hoc = phan_mem_hocTextEdit.Text,
                ten_khoa_hoc = ten_khoa_hocTextEdit.Text,
                thoi_gian_bat_dau = thoi_gian_bat_dauDateEdit.DateTime,
                thoi_gian_ket_thuc = thoi_gian_ket_thucDateEdit.DateTime,
                trang_thai = trang_thaiCheckEdit.Checked,
            };
            _vm.add(khoahocresponse);

            reload(true);
        }
    }
}
