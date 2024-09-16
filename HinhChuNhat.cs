using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaHuyHung_Buoi3_HCN
{
    internal class HinhChuNhat
    {
        private int cd;
        private int cr;

        public void setcd (int cd)
        {
            this.cd = cd;
        }
        public int getcd() 
        {
            return this.cd;
        }

        public void setcr (int cr)
        {
            this.cr = cr;
        }
        public int getcr()
        {
            return this.cr;
        }

        private void nhapHcn(int cd, int cr)
        {
            setcd(cd);
            setcr(cr);
        }
    }
}
