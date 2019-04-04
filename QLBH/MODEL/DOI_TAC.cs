namespace QLBH.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DOI_TAC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DOI_TAC()
        {
            DM_HANG = new HashSet<DM_HANG>();
            PHIEU_BH = new HashSet<PHIEU_BH>();
            PHIEU_MH = new HashSet<PHIEU_MH>();
        }

        [Key]
        [StringLength(50)]
        public string MA_ST { get; set; }

        [StringLength(250)]
        public string TEN_DT { get; set; }

        [StringLength(250)]
        public string DIA_CHI { get; set; }

        [StringLength(250)]
        public string NGUOI_LH { get; set; }

        [StringLength(50)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        [StringLength(50)]
        public string WECHAT { get; set; }

        [StringLength(50)]
        public string TAI_KHOAN { get; set; }

        [StringLength(250)]
        public string GHI_CHU { get; set; }

        public bool? STATUS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_HANG> DM_HANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEU_BH> PHIEU_BH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEU_MH> PHIEU_MH { get; set; }
    }
}
