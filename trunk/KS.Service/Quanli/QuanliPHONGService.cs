using System;
using KS.Service.Base;
using KS.Core.Model;
using KS.Core.Interface.Data;
using KS.Core.Interface.Service;

namespace KS.Service.Quanli
{
    public partial class QuanliPHONGService : PHONGSevice, IQuanliPHONGService
    {
        protected new readonly IQuanliRepository<PHONG> Repository;

        public QuanliPHONGService(IQuanliRepository<PHONG> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
            this.Repository = repository;
        }
    }
}
