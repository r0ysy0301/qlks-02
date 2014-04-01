using System;
using KS.Service.Base;
using KS.Core.Model;
using KS.Core.Interface.Data;
using KS.Core.Interface.Service;

namespace KS.Service.Quanli
{
    public partial class QuanliLOAIPHONGService : LOAIPHONGService, IQuanliLOAIPHONGService
    {
           protected new readonly IQuanliRepository<LOAIPHONG> Repository;

           public QuanliLOAIPHONGService(IQuanliRepository<LOAIPHONG> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
            this.Repository = repository;
        }
    }
}
