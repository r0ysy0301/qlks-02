using System;
using KS.Service.Base;
using KS.Core.Model;
using KS.Core.Interface.Data;
using KS.Core.Interface.Service;
namespace KS.Service.Admin
{
    public partial class AdminPHIEUTHUETRAService : PHIEUTHUETRAService , IAdminPHIEUTHUETRAService
    {
         protected new readonly IAdminRepository<PHIEUTHUETRA> Repository;

         public AdminPHIEUTHUETRAService(IAdminRepository<PHIEUTHUETRA> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
            this.Repository = repository;
        }
    }
}
