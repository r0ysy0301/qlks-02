using System;
using KS.Service.Base;
using KS.Core.Model;
using KS.Core.Interface.Data;
using KS.Core.Interface.Service;

namespace KS.Service.Admin
{
    public partial class AdminPHIEUDATPHONGService : PHIEUDATPHONGService, IAdminPHIEUDATPHONGService
    {
         protected new readonly IAdminRepository<PHIEUDATPHONG> Repository;

         public AdminPHIEUDATPHONGService(IAdminRepository<PHIEUDATPHONG> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
            this.Repository = repository;
        }
    }
}
