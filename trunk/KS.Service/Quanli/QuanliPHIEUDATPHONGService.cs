using System;
using KS.Service.Base;
using KS.Core.Model;
using KS.Core.Interface.Data;
using KS.Core.Interface.Service;

namespace KS.Service.Quanli
{
    public partial class QuanliPHIEUDATPHONGService : PHIEUDATPHONGService, IQuanliPHIEUDATPHONGService
    {
           protected new readonly IQuanliRepository<PHIEUDATPHONG> Repository;

           public QuanliPHIEUDATPHONGService(IQuanliRepository<PHIEUDATPHONG> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
            this.Repository = repository;
        }
    }
}
