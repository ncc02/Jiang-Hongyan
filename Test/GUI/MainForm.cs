using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using _102200013_NguyenCongCuong.BLL; 

namespace _102200013_NguyenCongCuong.GUI
{
    public partial class JiangHongyan_MF : Form
    {
        public JiangHongyan_MF()
        {
            InitializeComponent();
            SetComboBox();
        }
        public void Display()
        {
            dgvQLSP.DataSource = bllQLSP.Instance.Sreach(txtSreach.Text, cboMonAn.Text, cboSort.Text);

        }
        public void SetComboBox()
        {
            cboMonAn.Items.AddRange(bllQLSP.Instance.GetAllTenMonAn().ToArray());
            cboSort.Items.AddRange(new string[] { "Tên nguyên liệu", "Số lượng", "Đơn vị tính", "Tình trạng" });
        }

        private void textBox_Sreach_TextChanged(object sender, EventArgs e)
        {
            Display();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            bllQLSP.Instance.Del(dgvQLSP.SelectedRows);
            Display();
        }

        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvQLSP.SelectedRows.Count == 1) {
                var r = dgvQLSP.SelectedRows[0];
                JiangHongyan_DF f = new JiangHongyan_DF(cboMonAn.Text, r.Cells["Ma"].Value.ToString());
                f.d = new JiangHongyan_DF.MyDel(Display);
                f.Show();
            }
            else MessageBox.Show("Error!");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            JiangHongyan_DF f = new JiangHongyan_DF(cboMonAn.Text);
            f.d = new JiangHongyan_DF.MyDel(Display);
            f.Show();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Display();
        }
    }
}
