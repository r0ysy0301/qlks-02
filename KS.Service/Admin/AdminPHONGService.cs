using System;
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
}
