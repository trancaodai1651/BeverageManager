namespace Beverage_Manager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SANPHAM")]
    public partial class SANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANPHAM()
        {
            CT_DONHANG = new HashSet<CT_DONHANG>();
            CT_PNHAPKHO = new HashSet<CT_PNHAPKHO>();
            TONKHOes = new HashSet<TONKHO>();
        }

        [Key]
        [StringLength(50)]
        public string MASP { get; set; }

        [StringLength(100)]
        public string TENSP { get; set; }

        public double? GIANHAP { get; set; }

        public double? GIABAN { get; set; }

        [StringLength(50)]
        public string IDDV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_DONHANG> CT_DONHANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PNHAPKHO> CT_PNHAPKHO { get; set; }

        public virtual DONVI DONVI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TONKHO> TONKHOes { get; set; }
    }
}
