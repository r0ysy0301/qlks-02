using System;
using KS.Service.Base;
using KS.Core.Model;
using KS.Core.Interface.Data;
using KS.Core.Interface.Service;

namespace KS.Service.Admin
{
    public partial class AdminPHIEUDICHVUService : PHIEUDICHVUService , IAdminPHIEUDICHVUService
    {
         protected new readonly IAdminRepository<PHIEUDICHVU> Repository;

         public AdminPHIEUDICHVUService(IAdminRepository<PHIEUDICHVU> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
            this.Repository = repository;
        }
    }
}
