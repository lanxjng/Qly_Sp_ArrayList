using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KtraLop2
{
    class Banhang
    {
        public string LoaiSp { get; set; }
        public float SoLg { get; set; }

        public Banhang() { }
        public Banhang(string LoaiSp, float SoLg)
        {
            this.LoaiSp = LoaiSp;
            this.SoLg = SoLg;
        }
    }
}
