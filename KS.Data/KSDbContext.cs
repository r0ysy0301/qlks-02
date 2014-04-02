using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using KS.Core.Model;
using KS.Data.Interface;
namespace KS.Data
{
    public class KSDbContext: DbContext, IDataContext
    {
        public KSDbContext()
            : base("name=DefaultConnection")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    
        public DbSet<CHITIETPHIEUDP> CHITIETPHIEUDPs { get; set; }
        public DbSet<DICHVU> DICHVUs { get; set; }
        public DbSet<DOANKHACH> DOANKHACHes { get; set; }
        public DbSet<KHACH> KHACHes { get; set; }
        public DbSet<KHACHCUNGPHONG> KHACHCUNGPHONGs { get; set; }
        public DbSet<LOAIPHONG> LOAIPHONGs { get; set; }
        public DbSet<NHANVIEN> NHANVIENs { get; set; }
        public DbSet<PHIEUDATPHONG> PHIEUDATPHONGs { get; set; }
        public DbSet<PHIEUDICHVU> PHIEUDICHVUs { get; set; }
        public DbSet<PHIEUTHUETRA> PHIEUTHUETRAs { get; set; }
        public DbSet<PHONG> PHONGs { get; set; }


        public IDbSet<T> DbSet<T>() where T : PersistentEntity
        {
            return this.Set<T>();
        }

        public DbEntityEntry<T> EntryGet<T>(T entity) where T : PersistentEntity
        {
            return this.Entry<T>(entity);
        }

        public virtual int Commit()
        {
            return this.SaveChanges();
        }
    }
}
