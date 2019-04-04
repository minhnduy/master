namespace QLBH.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_HANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DM_HANG()
        {
            PHIEU_BH_CT = new HashSet<PHIEU_BH_CT>();
            PHIEU_MH_CT = new HashSet<PHIEU_MH_CT>();
        }

        [Key]
        [StringLength(50)]
        public string MA_HANG { get; set; }

        [StringLength(250)]
        public string TEN_HANG { get; set; }

        [StringLength(50)]
        public string DVT { get; set; }

        public decimal? DON_GIA { get; set; }

        public decimal? DON_GIA_BAN { get; set; }

        [StringLength(50)]
        public string MA_ST { get; set; }

        [StringLength(250)]
        public string GHI_CHU { get; set; }

        public virtual DOI_TAC DOI_TAC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEU_BH_CT> PHIEU_BH_CT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEU_MH_CT> PHIEU_MH_CT { get; set; }
    }
}
