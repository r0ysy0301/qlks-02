using System;
using System.Linq;
using KS.Service.Base;
using KS.Core.Model;
using KS.Core.Interface.Data;
using KS.Core.Interface.Service;

namespace KS.Service.Admin
{
    public partial class AdminPHONGService : PHONGSevice , IAdminPHONGService
    {
        protected new readonly IAdminRepository<PHONG> Repository;

        public AdminPHONGService(IAdminRepository<PHONG> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
            this.Repository = repository;
        }
    }
    public partial class AdminPHONGService
    {
        public IQueryable<PHONG> GetAll(int quantity)
        {
            return this.GetAll()
                .OrderBy(p=>p.MaPhong)
                .Take(quantity);
        }
    }
}
