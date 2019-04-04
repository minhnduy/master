namespace QLBH.MODEL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CONG_NO
    {
        [Key]
        public int ID_CN { get; set; }

        public int? ID_SOHD { get; set; }

        public DateTime? NGAY_HD { get; set; }

        public int? TONGTIEN { get; set; }

        public int? TRATRUOC { get; set; }

        public int? NO { get; set; }

        public DateTime? NGAYTRA { get; set; }

        [StringLength(250)]
        public string GHICHU { get; set; }

        [StringLength(10)]
        public string XORN { get; set; }

        public bool? STATUS { get; set; }
    }
}
