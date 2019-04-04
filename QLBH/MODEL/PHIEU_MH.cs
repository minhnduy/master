namespace QLBH.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PHIEU_MH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEU_MH()
        {
            PHIEU_MH_CT = new HashSet<PHIEU_MH_CT>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_PMH { get; set; }

        public DateTime? NGAY_MUA { get; set; }

        [StringLength(50)]
        public string MA_ST { get; set; }

        [StringLength(250)]
        public string TEN_CTY { get; set; }

        [StringLength(250)]
        public string DIA_CHI { get; set; }

        [StringLength(50)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        public int? TONG_TIEN_HANG { get; set; }

        [StringLength(350)]
        public string SO_TIEN_VND { get; set; }

        public virtual DOI_TAC DOI_TAC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEU_MH_CT> PHIEU_MH_CT { get; set; }
    }
}
