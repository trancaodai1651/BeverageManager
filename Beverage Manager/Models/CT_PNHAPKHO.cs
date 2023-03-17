namespace Beverage_Manager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_PNHAPKHO
    {
        [Key]
        public int IDCTPNK { get; set; }

        public int? IDPNK { get; set; }

        [StringLength(50)]
        public string IDSP { get; set; }

        public int? SL { get; set; }

        public double? THANHTIEN { get; set; }

        public virtual NHAPKHO NHAPKHO { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
