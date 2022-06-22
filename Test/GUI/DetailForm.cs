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
using _102200013_NguyenCongCuong.DTO;


namespace _102200013_NguyenCongCuong.GUI
{
    public partial class JiangHongyan_DF : Form
    {
        
        private string Ma;
        private string TenMonAn;

        public delegate void MyDel();
        public MyDel d;

        public JiangHongyan_DF(string TenMonAn, string Ma = null)
        {
            this.Ma = Ma;
            this.TenMonAn=TenMonAn;
            InitializeComponent();
            SetComboBox();
            
        }

        public void SetComboBox()
        {
            cboTenNguyenLieu.Items.AddRange(bllQLSP.Instance.GetAllTenNguyenLieu().ToArray());
            cboTinhTrang.Items.AddRange(new string[] { "Đã nhập hàng", "Chưa nhập hàng" });
         
            if (Ma != null) cboTenNguyenLieu.SelectedItem = bllQLSP.Instance.GetTenNguyenLieuByMa(Ma);
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {

                if (Ma != null)
                    bllQLSP.Instance.Edit(Ma, cboTinhTrang.Text, new MANL
                    {
                        Ma = Ma,
                        SoLuong = Convert.ToInt32(txtSoLuong.Text),
                        DonViTinh = cboDonViTinh.Text,
                        MaNguyenLieu= bllQLSP.Instance.GetMaNguyenLieuByTNL(cboTenNguyenLieu.Text),
                        MaMonAn = bllQLSP.Instance.GetMaMonAnByTMA(TenMonAn)
                    });
                else bllQLSP.Instance.Add(cboTinhTrang.Text, new MANL{
                   Ma= bllQLSP.Instance.GetNewIdMANL(),
                    SoLuong = Convert.ToInt32(txtSoLuong.Text),
                    DonViTinh = cboDonViTinh.Text,
                    MaNguyenLieu = bllQLSP.Instance.GetMaNguyenLieuByTNL(cboTenNguyenLieu.Text),
                    MaMonAn = bllQLSP.Instance.GetMaMonAnByTMA(TenMonAn)
                });

                d();
                this.Close();
            }
            catch (Exception ex) {
                MessageBox.Show("Dữ liệu ko hợp lệ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboTenNguyenLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDonViTinh.Items.Clear();
            cboDonViTinh.Items.AddRange(bllQLSP.Instance.GetAllDonViTinhByTNL(cboTenNguyenLieu.Text).ToArray());

        }
    }
}
