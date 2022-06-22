using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102200013_NguyenCongCuong.DTO
{
    public class MonAn
    {
     
        [Key]
        public int MaMonAn { get; set; }
        
        public string TenMonAn { get; set;}

        public virtual ICollection<MANL> MANLs { get; set; }
        public MonAn()
        {
            this.MANLs = new HashSet<MANL>();
        }


    }
}
