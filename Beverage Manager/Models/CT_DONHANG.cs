namespace Beverage_Manager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_DONHANG
    {
        [Key]
        public int IDCTDH { get; set; }

        public int? MADH { get; set; }

        [StringLength(50)]
        public string MASP { get; set; }

        public int? SL { get; set; }

        public double? THANHTIEN { get; set; }

        public virtual DONHANG DONHANG { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
