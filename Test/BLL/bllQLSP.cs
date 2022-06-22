using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _102200013_NguyenCongCuong.DAL;
using _102200013_NguyenCongCuong.DTO;


namespace _102200013_NguyenCongCuong.BLL
{
    internal class bllQLSP
    {
        QLSP db;
        private static bllQLSP _Instance;
        public static bllQLSP Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new bllQLSP();
                }
                return _Instance;
            }
            private set { }
        }

        public List<string> GetAllTenNguyenLieu()
        {
            return db.NguyenLieus.Select(x=>x.TenNguyenLieu).ToList();
        }

        public List<string>  GetAllDonViTinhByTNL(string TNL)
        {
             return db.MANLs.Where(x => x.NguyenLieu.TenNguyenLieu == TNL).Select(x => x.DonViTinh).Distinct().ToList();
          
        }

        public string GetTenNguyenLieuByMa(string Ma)
        {
            return db.MANLs.Find(Ma).NguyenLieu.TenNguyenLieu;
        }

        public bllQLSP()
        {
            db = new QLSP();
        }

        public List<string> GetAllTenMonAn()
        {
            return db.MonAns.Select(x=>x.TenMonAn).ToList();
        }

        public void Edit(string ma, string text, MANL y)
        {
            if (y.DonViTinh == "") throw new Exception();
            var x = db.MANLs.Find(ma);
            x.NguyenLieu.TinhTrang = (text == "Đã nhập hàng" ? true : false);
            x.SoLuong = y.SoLuong;
            x.DonViTinh = y.DonViTinh;
            x.MaNguyenLieu = y.MaNguyenLieu;
            db.SaveChanges();
        }

        public int GetMaNguyenLieuByTNL(string text)
        {
            return db.NguyenLieus.Where(x => x.TenNguyenLieu == text).Select(x=>x.MaNguyenLieu).First();
        }

        public int GetMaMonAnByTMA(string text)
        {
            return db.MonAns.Where(x => x.TenMonAn == text).Select(x => x.MaMonAn).First();

        }

        public void Add(string TinhTrang, MANL mANL)
        {
            if (mANL.DonViTinh == "") throw new Exception();
            db.MANLs.Add(mANL);
            db.SaveChanges();
            var x = db.MANLs.Find(mANL.Ma);
            x.NguyenLieu.TinhTrang = (TinhTrang == "Đã nhập hàng" ? true : false); 
            db.SaveChanges();
        }

        public string GetNewIdMANL()
        {
            int n=0;
            foreach (string x in db.MANLs.Select(x => x.Ma))
                if (Convert.ToInt32(x) > n) n = Convert.ToInt32(x);
            return (n+1).ToString();
        }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public MANLView GetMANLViewByMANL(MANL x, int stt)
        {
            return new MANLView()
            {
                Ma = x.Ma,
                STT = stt,
                TenNguyenLieu = x.NguyenLieu.TenNguyenLieu,
                SoLuong = x.SoLuong,
                DonViTinh = x.DonViTinh,
                TinhTrang = x.NguyenLieu.TinhTrang
            };
        }

   

        public void Del(DataGridViewSelectedRowCollection selectedRows)
        {
            bool error = false;
            foreach(DataGridViewRow r in selectedRows)
                if (Convert.ToBoolean(r.Cells["TinhTrang"].Value.ToString()) == false)
                {
                    db.MANLs.Remove(db.MANLs.Find(r.Cells["Ma"].Value.ToString()));
                    db.SaveChanges();
                }
                else error= true;
            if (error == true) MessageBox.Show("Một số nguyên liệu không được xóa vì đã nhập", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public List<MANLView> Sreach(string TK, string TenMonAn, string SX)
        {
            List<MANLView> data = new List<MANLView>();
            int stt = 0;
            foreach (MANL x in db.MANLs.Where(x => x.MonAn.TenMonAn == TenMonAn && (x.NguyenLieu.TenNguyenLieu.Contains(TK) || x.DonViTinh.Contains(TK) || x.SoLuong.ToString().Contains(TK))))
                data.Add(GetMANLViewByMANL(x, ++stt));
            if (SX == "Tên nguyên liệu") data = data.OrderBy(x => x.TenNguyenLieu).ToList();
            if (SX == "Số lượng") data = data.OrderBy(x => x.SoLuong).ToList();
            if (SX == "Đơn vị tính") data = data.OrderBy(x => x.DonViTinh).ToList();
            if (SX == "Tình trạng") data = data.OrderBy(x => x.TinhTrang).ToList();

            return data;
        }
    }
}
