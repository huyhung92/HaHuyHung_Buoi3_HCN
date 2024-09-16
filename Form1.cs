namespace HaHuyHung_Buoi3_HCN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnnhap_Click(object sender, EventArgs e)
        {
            HinhChuNhat hinhChuNhat = new HinhChuNhat();
            hinhChuNhat.setcd(int.Parse(txtcd.Text));
            hinhChuNhat.setcr(int.Parse(txtcr.Text));

            MessageBox.Show("Chiều dài: " + hinhChuNhat.getcd() + "\n Chiều rộng: " + hinhChuNhat.getcr());
        }
    }
}
