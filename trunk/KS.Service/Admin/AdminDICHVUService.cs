using System;
using KS.Service.Base;
using KS.Core.Model;
using KS.Core.Interface.Data;
using KS.Core.Interface.Service;

namespace KS.Service.Admin
{
    public partial class AdminDICHVUService : DICHVUService, IAdminDICHVUService
    {
         protected new readonly IAdminRepository<DICHVU> Repository;

         public AdminDICHVUService(IAdminRepository<DICHVU> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
            this.Repository = repository;
        }
    }
}
