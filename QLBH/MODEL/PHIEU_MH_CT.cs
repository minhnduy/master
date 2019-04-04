namespace QLBH.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PHIEU_MH_CT
    {
        [Key]
        public int ID_PMH_CT { get; set; }

        public int? ID_PMH { get; set; }

        public int? STT { get; set; }

        [StringLength(50)]
        public string MA_HANG { get; set; }

        [StringLength(250)]
        public string TEN_HANG { get; set; }

        [StringLength(50)]
        public string DVT { get; set; }

        public decimal? SL { get; set; }

        public decimal? DON_GIA { get; set; }

        public decimal? PTKM { get; set; }

        public decimal? TIEN_KM { get; set; }

        public decimal? THANH_TIEN { get; set; }

        public virtual DM_HANG DM_HANG { get; set; }

        public virtual PHIEU_MH PHIEU_MH { get; set; }
    }
}
