using System;
using System.Linq;
using KS.Core.Model;
using KS.Core.Interface.Data;
using KS.Core.Interface.Service;

namespace KS.Service.Base
{
    public partial class PHONGSevice : BaseService<PHONG>, IPHONGService
    {
        public PHONGSevice(IRepository<PHONG> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
        }
    }
    public partial class PHONGSevice
    {
        public IQueryable<PHONG> GetThuong(int quantity)
        {
            return this.GetAll()
                .OrderBy(p=>p.MaPhong)
                .Take(quantity);
        }
    //    public IQueryable<PHONG> GetVip(int quantity)
    //    {
    //        return this.GetAll()
    //            .OrderByDescending(p => p.MaPhong)
    //            .Take(quantity);
    //    }
    //    public IQueryable<PHONG> GetDon(int quantity)
    //    {
    //        return this.GetAll()
    //            .OrderByDescending(p => p.SDTPhong)
    //            .Take(quantity);
    //    }
    //    public IQueryable<PHONG> GetDoi(int quantity)
    //    {
    //        return this.GetAll()
    //            .OrderByDescending(p => p.TinhTrang)
    //            .Take(quantity);
    //    }
    }
}
