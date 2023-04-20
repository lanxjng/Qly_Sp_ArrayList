using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace KtraLop2
{
    class Sanpham : Banhang , IComparer
    {
        public string TenSp { get; set; }
        public float DonGia { get; set; }

        public Sanpham() { }
        public Sanpham(string TenSp, float DonGia, string LoaiSp, float SoLg)
            : base(LoaiSp, SoLg)
        {
            this.TenSp = TenSp;
            this.DonGia = DonGia;

        }

        public float ThanhTien() 
        {
            switch (LoaiSp)
            {
                case "Văn Phòng":
                    DonGia = 2000;
                    break;
                case "Xây Dựng":
                    DonGia = 3000;
                    break;
                default:
                    break;
            }

        return DonGia * SoLg;
        }
        public int Compare(object x, object y)
        {
            Sanpham p1 = x as Sanpham;
            Sanpham p2 = y as Sanpham;
            if (p1.ThanhTien() > p2.ThanhTien())
            {
                return 1;
            }
            else if (p1.ThanhTien() == p2.ThanhTien())
            {
                return 0;
            }
            else
                return -1;
        }

        
    }
}
