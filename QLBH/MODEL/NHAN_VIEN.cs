namespace QLBH.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NHAN_VIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHAN_VIEN()
        {
            NGHI_PHEP = new HashSet<NGHI_PHEP>();
        }

        [Key]
        [StringLength(50)]
        public string MA_NV { get; set; }

        [StringLength(50)]
        public string TEN_NV { get; set; }

        public bool? GIOI_TINH { get; set; }

        [StringLength(250)]
        public string DIA_CHI { get; set; }

        [StringLength(50)]
        public string SDT { get; set; }

        [StringLength(250)]
        public string GHI_CHU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NGHI_PHEP> NGHI_PHEP { get; set; }
    }
}
