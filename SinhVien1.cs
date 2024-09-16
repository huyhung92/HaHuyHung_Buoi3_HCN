using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaHuyHung_Buoi3_HCN
{
    public partial class SinhVien1 : UserControl
    {
        public SinhVien1()
        {
            InitializeComponent();
        }

        private void btnnhap_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien(txtmssv.Text, txthoten.Text, txtgioitinh.Text, dtpngaysinh.Value, txtdc.Text);

            MessageBox.Show(sv.getHoten());
        }
    }
}
