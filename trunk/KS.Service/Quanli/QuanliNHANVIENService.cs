using System;
using KS.Service.Base;
using KS.Core.Model;
using KS.Core.Interface.Data;
using KS.Core.Interface.Service;

namespace KS.Service.Quanli
{
    public partial class QuanliNHANVIENService : NHANVIENService, IQuanliNHANVIENService
    {
           protected new readonly IQuanliRepository<NHANVIEN> Repository;

           public QuanliNHANVIENService(IQuanliRepository<NHANVIEN> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
            this.Repository = repository;
        }
    }
}
