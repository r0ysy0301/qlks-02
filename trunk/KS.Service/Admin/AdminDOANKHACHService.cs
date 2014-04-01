using System;
using KS.Service.Base;
using KS.Core.Model;
using KS.Core.Interface.Data;
using KS.Core.Interface.Service;

namespace KS.Service.Admin
{
    public partial class AdminDOANKHACHService : DOANKHACHService, IAdminDOANKHACHService
    {
         protected new readonly IAdminRepository<DOANKHACH> Repository;

         public AdminDOANKHACHService(IAdminRepository<DOANKHACH> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
            this.Repository = repository;
        }
    }
}
