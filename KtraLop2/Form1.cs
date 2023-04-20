using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace KtraLop2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList sp = new ArrayList();
        int index;

        private void cbbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbLoai.SelectedIndex)
            {
                case 0:
                    txtDonGia.Text = "2000";
                    break;
                case 1:
                    txtDonGia.Text = "3000";
                    break;
                default :
                    break;
            }
        }

        private void Chon_Sp(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var sp = e.Item;
            txtTen.Text = sp.SubItems[0].Text;
            txtSoLg.Text = sp.SubItems[1].Text;
            cbbLoai.Text = sp.SubItems[2].Text;
            txtDonGia.Text = sp.SubItems[3].Text;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Sanpham ob = new Sanpham(txtTen.Text,float.Parse(txtDonGia.Text),cbbLoai.Text, float.Parse(txtSoLg.Text));
            sp.Add(ob);
            txtTen.Clear();
            txtSoLg.Clear();
            txtDonGia.Clear();
            cbbLoai.Text = "";

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Sanpham ob = new Sanpham(txtTen.Text, float.Parse(txtDonGia.Text), cbbLoai.Text, float.Parse(txtSoLg.Text));
            sp.RemoveAt(index);
            sp.Insert(index,ob);
            txtTen.Clear();
            txtSoLg.Clear();
            txtDonGia.Clear();
            cbbLoai.Text = "";


        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string[] arr = new string[6];
            ListViewItem lvitem;
            foreach (Sanpham item in sp)
            {
                arr[0] = item.TenSp;
                arr[1] = item.SoLg.ToString();
                arr[2] = item.LoaiSp;
                arr[3] = item.DonGia.ToString();
                arr[4] = item.ThanhTien().ToString();
                lvitem = new ListViewItem(arr);
                listView1.Items.Add(lvitem);

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            sp.RemoveAt(index);
            txtTen.Clear();
            txtSoLg.Clear();
            txtDonGia.Clear();
            cbbLoai.Text = "";

        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            //nv.Sort(new Sort_Luong());
            sp.Sort(new Sanpham());
        }


    }
}
