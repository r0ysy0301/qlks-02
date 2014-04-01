using System;
using KS.Service.Base;
using KS.Core.Model;
using KS.Core.Interface.Data;
using KS.Core.Interface.Service;

namespace KS.Service.Admin
{
    public partial class AdminUSERService : USERService , IAdminUSERSevice
    {
         protected new readonly IAdminRepository<USER> Repository;

         public AdminUSERService(IAdminRepository<USER> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
            this.Repository = repository;
        }
    }
}
