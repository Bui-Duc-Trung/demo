using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class Form1 : Form
    {
        QLThuCung QLTC = new QLThuCung();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("STT");
            listView1.Columns.Add("Tên");
            listView1.Columns.Add("Tên loài");
            listView1.Columns.Add("Giống");
            listView1.Columns.Add("Màu sắc");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text;
            string tenloai = txtTenLoai.Text;
            bool giong;
            if (rdoDuc.Checked == true)
            {
                giong = true;
            }
            else
            {
                giong = false;

            }
            string mausac = txtMauSac.Text;
            int stt = listView1.Items.Count + 1;
            ListViewItem item = new ListViewItem(stt.ToString());
            item.SubItems.Add(ten);
            item.SubItems.Add(tenloai);
            item.SubItems.Add(giong == true ? "Đực":"Cái");
            item.SubItems.Add(mausac);

            listView1.Items.Add(item);

            MessageBox.Show("Thêm thú cưng thành công !", "Thông báo !");
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            }
        }

        private void cboLuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboLuaChon.Text == "Chó")
            {
                picAnhDongVat.Image = imgCho.Images[cboLuaChon.SelectedIndex];
            }
            else
            {
                picAnhDongVat.Image = imgMeo.Images[cboLuaChon.SelectedIndex];
            }
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSau_Click(object sender, EventArgs e)
        {

        }
    }
}
