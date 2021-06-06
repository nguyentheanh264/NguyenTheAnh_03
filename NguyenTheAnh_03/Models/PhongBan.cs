using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NguyenTheAnh_03.Models
{
    [Table("PhongBans")]
    public class PhongBan
    {
        [Key]
        public int MaPhongBan { get; set; }
        public string TenPhongBan { get; set; }

    }
}