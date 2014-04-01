using System;
using KS.Service.Base;
using KS.Core.Model;
using KS.Core.Interface.Data;
using KS.Core.Interface.Service;

namespace KS.Service.Quanli
{
    public partial class QuanliPHIEUDICHVUService : PHIEUDICHVUService , IQuanliPHIEUDICHVUService
    {
           protected new readonly IQuanliRepository<PHIEUDICHVU> Repository;

           public QuanliPHIEUDICHVUService(IQuanliRepository<PHIEUDICHVU> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
            this.Repository = repository;
        }
    }
}
