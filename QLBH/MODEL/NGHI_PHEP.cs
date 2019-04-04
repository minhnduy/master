namespace QLBH.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NGHI_PHEP
    {
        [Key]
        public int ID_NGHIPHEP { get; set; }

        [StringLength(50)]
        public string MA_NV { get; set; }

        [StringLength(50)]
        public string TEN_NV { get; set; }

        public DateTime? NGAY_BD { get; set; }

        public DateTime? NGAY_KT { get; set; }

        public double? SO_NGAY { get; set; }

        [StringLength(250)]
        public string LY_DO { get; set; }

        public virtual NHAN_VIEN NHAN_VIEN { get; set; }
    }
}
