using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaHuyHung_Buoi3_HCN
{
    internal class SinhVien
    {
        public string MSSV;
        public DateTime Ngaysinh;
        public string Hoten;
        public string Gioitinh;
        public string Diachi;

        public void setMSSV (string MSSV)
        {
            this.MSSV = MSSV;
        }
        public string getMSSV()
        {
            return this.MSSV;
        }
       
        public void setNgaysinh (DateTime Ngaysinh)
        {
            this.Ngaysinh = Ngaysinh;
        }
        public DateTime getNgaysinh()
        {
            return this.Ngaysinh;
        }
       
        public void setHoten (string Hoten)
        {
            this.Hoten = Hoten;
        }
        public string getHoten()
        {
            return Hoten;
        }
        
        public void setGioitinh (string Gioitinh)
        {
            this.Gioitinh = Gioitinh;
        }
        public string getGioitinh()
        {
            return Gioitinh;
        }
        public void setDiachi (string Diachi)
        {
            this.Diachi = Diachi;
        }
        public string getDiachi()
        {
            return Diachi;
        }

        public SinhVien() { }

        public SinhVien(string MSSV, string Hoten, string Gioitinh, DateTime Ngaysinh, string diachi)
        {
            this.MSSV = MSSV;
            this.Hoten = Hoten;
            this.Ngaysinh= Ngaysinh;
            this.Diachi = diachi;
            this.Gioitinh= Gioitinh;
        }


    }


}
