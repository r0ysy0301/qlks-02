using System;
using KS.Service.Base;
using KS.Core.Model;
using KS.Core.Interface.Data;
using KS.Core.Interface.Service;

namespace KS.Service.Quanli
{
    public partial class QuanliDICHVUService : DICHVUService, IQuanliDICHVUService
    {
         protected new readonly IQuanliRepository<DICHVU> Repository;

         public QuanliDICHVUService(IQuanliRepository<DICHVU> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
            this.Repository = repository;
        }
    }
}
