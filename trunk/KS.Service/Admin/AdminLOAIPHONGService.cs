using System;
using KS.Service.Base;
using KS.Core.Model;
using KS.Core.Interface.Data;
using KS.Core.Interface.Service;

namespace KS.Service.Admin
{
    public partial class AdminLOAIPHONGService : LOAIPHONGService , IAdminLOAIPHONGService
    {
         protected new readonly IAdminRepository<LOAIPHONG> Repository;

         public AdminLOAIPHONGService(IAdminRepository<LOAIPHONG> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
            this.Repository = repository;
        }
    }
}
