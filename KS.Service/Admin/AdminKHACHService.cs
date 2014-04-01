using System;
using KS.Service.Base;
using KS.Core.Model;
using KS.Core.Interface.Data;
using KS.Core.Interface.Service;

namespace KS.Service.Admin
{
    public partial class AdminKHACHService : KHACHService,IAdminKHACHService
    {
         protected new readonly IAdminRepository<KHACH> Repository;

         public AdminKHACHService(IAdminRepository<KHACH> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
            this.Repository = repository;
        }
    }
}
