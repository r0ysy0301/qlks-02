using System;
using KS.Service.Base;
using KS.Core.Model;
using KS.Core.Interface.Data;
using KS.Core.Interface.Service;

namespace KS.Service.Quanli
{
    public partial class QuanliDOANKHACHService : DOANKHACHService, IQuanliDOANKHACHService
    {
         protected new readonly IQuanliRepository<DOANKHACH> Repository;

         public QuanliDOANKHACHService(IQuanliRepository<DOANKHACH> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
            this.Repository = repository;
        }
    }
}
