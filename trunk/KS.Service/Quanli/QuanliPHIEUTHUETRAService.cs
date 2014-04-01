using System;
using KS.Service.Base;
using KS.Core.Model;
using KS.Core.Interface.Data;
using KS.Core.Interface.Service;

namespace KS.Service.Quanli
{
    public partial class QuanliPHIEUTHUETRAService : PHIEUTHUETRAService, IQuanliPHIEUTHUETRAService
    {
           protected new readonly IQuanliRepository<PHIEUTHUETRA> Repository;

           public QuanliPHIEUTHUETRAService(IQuanliRepository<PHIEUTHUETRA> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
            this.Repository = repository;
        }
    }
}
