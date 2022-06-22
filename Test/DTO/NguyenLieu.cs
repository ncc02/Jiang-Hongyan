using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102200013_NguyenCongCuong.DTO
{
    public class NguyenLieu
    {
   
        [Key]
        public int MaNguyenLieu { get; set; }

        public string TenNguyenLieu { set; get; }

        public bool TinhTrang { get; set; }

        public virtual ICollection<MANL> MANLs { get; set; }
        public NguyenLieu()
        {
            this.MANLs = new HashSet<MANL>();
        }

    }
}
