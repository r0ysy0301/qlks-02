using System;
using KS.Service.Base;
using KS.Core.Model;
using KS.Core.Interface.Data;
using KS.Core.Interface.Service;

namespace KS.Service.Admin
{
    public partial class AdminKHACHCUNGPHONGService : KHACHCUNGPHONGService, IAdminKHACHCUNGPHONGService
    {
         protected new readonly IAdminRepository<KHACHCUNGPHONG> Repository;

         public AdminKHACHCUNGPHONGService(IAdminRepository<KHACHCUNGPHONG> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
            this.Repository = repository;
        }
    }
}
