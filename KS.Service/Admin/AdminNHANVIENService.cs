using System;
using KS.Service.Base;
using KS.Core.Model;
using KS.Core.Interface.Data;
using KS.Core.Interface.Service;

namespace KS.Service.Admin
{
    public partial class AdminNHANVIENService : NHANVIENService , IAdminNHANVIENService
    {
         protected new readonly IAdminRepository<NHANVIEN> Repository;

         public AdminNHANVIENService(IAdminRepository<NHANVIEN> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
            this.Repository = repository;
        }
    }
}
