using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _102200013_NguyenCongCuong.DTO;

namespace _102200013_NguyenCongCuong.DAL
{
    public class CreateDB : CreateDatabaseIfNotExists<QLSP>
    {
        protected override void Seed(QLSP context)
        {
            context.MonAns.AddRange(new MonAn[]
            {
                new MonAn{MaMonAn= 1, TenMonAn= "Cơm sườn"},
                new MonAn{MaMonAn= 2, TenMonAn= "Cơm gà"},
                new MonAn{MaMonAn= 3, TenMonAn= "Bún giò"}
            });

            context.MANLs.AddRange(new MANL[]
            {
                new MANL{Ma= "1", DonViTinh="g", SoLuong=10, MaMonAn= 1, MaNguyenLieu= 1},
                new MANL{Ma= "2", DonViTinh="kg", SoLuong=15, MaMonAn= 1, MaNguyenLieu= 2},

                new MANL{Ma= "3", DonViTinh="g", SoLuong=12, MaMonAn= 2, MaNguyenLieu= 1},
                new MANL{Ma= "4", DonViTinh="kg", SoLuong=15, MaMonAn= 2, MaNguyenLieu= 3},

                new MANL{Ma= "5", DonViTinh="g", SoLuong=14, MaMonAn= 3, MaNguyenLieu= 4},
                new MANL{Ma= "6", DonViTinh="kg", SoLuong=13, MaMonAn= 3, MaNguyenLieu= 5},

                new MANL{Ma= "7", DonViTinh="kg", SoLuong=21, MaMonAn= 1, MaNguyenLieu= 6},
                new MANL{Ma= "8", DonViTinh="kg", SoLuong=19, MaMonAn= 1, MaNguyenLieu= 7},

                new MANL{Ma= "9", DonViTinh="kg", SoLuong=21, MaMonAn= 2, MaNguyenLieu= 6},
                new MANL{Ma= "10", DonViTinh="kg", SoLuong=19, MaMonAn= 2, MaNguyenLieu= 7},


            });

            context.NguyenLieus.AddRange(new NguyenLieu[]
            {
                new NguyenLieu{MaNguyenLieu= 1, TenNguyenLieu= "Cơm", TinhTrang=true},
                 new NguyenLieu{MaNguyenLieu= 2, TenNguyenLieu= "Sườn", TinhTrang=true},
                new NguyenLieu{MaNguyenLieu= 3, TenNguyenLieu= "Gà", TinhTrang=true},
                 new NguyenLieu{MaNguyenLieu= 4, TenNguyenLieu= "Bún", TinhTrang=true},
                new NguyenLieu{MaNguyenLieu= 5, TenNguyenLieu= "Giò", TinhTrang=false},
                new NguyenLieu{MaNguyenLieu= 6, TenNguyenLieu= "Trứng", TinhTrang=false},
                new NguyenLieu{MaNguyenLieu= 7, TenNguyenLieu= "Tôm", TinhTrang=false},
            });

        }
    }
}
