using System;
using KS.Service.Base;
using KS.Core.Model;
using KS.Core.Interface.Data;
using KS.Core.Interface.Service;

namespace KS.Service.Quanli
{
    public partial class QuanliKHACHCUNGPHONGService : KHACHCUNGPHONGService, IQuanliKHACHCUNGPHONGService
    {
         protected new readonly IQuanliRepository<KHACHCUNGPHONG> Repository;

         public QuanliKHACHCUNGPHONGService(IQuanliRepository<KHACHCUNGPHONG> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
            this.Repository = repository;
        }
    }
}
