namespace Beverage_Manager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TONKHO")]
    public partial class TONKHO
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string IDSP { get; set; }

        public int? SLTON { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
