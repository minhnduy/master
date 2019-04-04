namespace QLBH.MODEL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLBHDbContext : DbContext
    {
        public QLBHDbContext()
            : base("name=QLBH_Database")
        {
        }
        public virtual DbSet<CONG_NO> CONG_NO { get; set; }
        public virtual DbSet<DM_HANG> DM_HANG { get; set; }
        public virtual DbSet<DOI_TAC> DOI_TAC { get; set; }
        public virtual DbSet<NGHI_PHEP> NGHI_PHEP { get; set; }
        public virtual DbSet<NHAN_VIEN> NHAN_VIEN { get; set; }
        public virtual DbSet<PHIEU_BH> PHIEU_BH { get; set; }
        public virtual DbSet<PHIEU_BH_CT> PHIEU_BH_CT { get; set; }
        public virtual DbSet<PHIEU_MH> PHIEU_MH { get; set; }
        public virtual DbSet<PHIEU_MH_CT> PHIEU_MH_CT { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CONG_NO>()
                .Property(e => e.XORN)
                .IsFixedLength();
        }
    }
}
