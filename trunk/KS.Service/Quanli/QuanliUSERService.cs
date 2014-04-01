using System;
using KS.Service.Base;
using KS.Core.Model;
using KS.Core.Interface.Data;
using KS.Core.Interface.Service;

namespace KS.Service.Quanli
{
    public partial class QuanliUSERService : USERService, IQuanliUSERService
    {
           protected new readonly IQuanliRepository<USER> Repository;

           public QuanliUSERService(IQuanliRepository<USER> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
            this.Repository = repository;
        }
    }
}
