using System;
using KS.Service.Base;
using KS.Core.Model;
using KS.Core.Interface.Data;
using KS.Core.Interface.Service;

namespace KS.Service.Quanli
{
    public partial class QuanliKHACHService : KHACHService, IQuanliKHACHService
    {
         protected new readonly IQuanliRepository<KHACH> Repository;

         public QuanliKHACHService(IQuanliRepository<KHACH> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
            this.Repository = repository;
        }
    }
}
