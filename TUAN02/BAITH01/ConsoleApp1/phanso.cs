using System;
using System.Collections.Generic;
using System.Text;

namespace Bai1_4
{
    public class phanso
    {
        public int tu { get; set; }
        public int mau { get; set; }

        public phanso(int tu, int mau)
        {
            this.tu = tu;
            this.mau = mau;
        }
        public phanso()
        {
            this.tu = 0;
            this.mau = 1;
        }
        public phanso(int tu)
        {
            this.tu = tu;
            this.mau = 1;
        }
        public override string ToString()
        {
            return $"{tu}/{mau}";
        }

        // mot ngoi
        public static phanso operator +(phanso a)
        {
            return new phanso(a.tu , a.mau );
        }
        public static phanso operator -(phanso a)
        {
            return new phanso(-a.tu, a.mau);
        }
        // hai ngoi
        public static phanso operator +(phanso a, phanso b)
        {
            return new phanso(a.tu * b.mau + b.tu * a.mau, a.mau * b.mau);
        }
        public static phanso operator -(phanso a, phanso b)
        {
            return new phanso(a.tu * b.mau - b.tu * a.mau, a.mau * b.mau);
        }
        public static phanso operator *(phanso a, phanso b)
        {
            return new phanso(a.tu * b.tu, a.mau * b.mau);
        }
        public static phanso operator /(phanso a, phanso b)
        {
            return new phanso(a.tu * b.mau, a.mau * b.tu);
        }
        // so sanh
        public static bool operator >(phanso a, phanso b)
        {
            return a.tu * b.mau > b.tu * a.mau;
        }
        public static bool operator <(phanso a, phanso b)
        {
            return a.tu * b.mau < b.tu * a.mau;
        }
        public static bool operator >=(phanso a, phanso b)
        {
            return a.tu * b.mau >= b.tu * a.mau;
        }
        public static bool operator <=(phanso a, phanso b)
        {
            return a.tu * b.mau <= b.tu * a.mau;
        }
        public static bool operator ==(phanso a, phanso b)
        {
            return a.tu * b.mau == b.tu * a.mau;
        }
        public static bool operator !=(phanso a, phanso b)
        {
            return a.tu * b.mau != b.tu * a.mau;
        }



    }
}
