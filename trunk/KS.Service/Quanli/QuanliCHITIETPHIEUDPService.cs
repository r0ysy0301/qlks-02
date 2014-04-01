using System;
using KS.Service.Base;
using KS.Core.Model;
using KS.Core.Interface.Data;
using KS.Core.Interface.Service;

namespace KS.Service.Quanli
{
    public partial class QuanliCHITIETPHIEUDPService : CHITIETPHIEUDPService, IQuanliCHITIETPHIEUDICHVUService
    {
         protected new readonly IQuanliRepository<CHITIETPHIEUDP> Repository;

         public QuanliCHITIETPHIEUDPService(IQuanliRepository<CHITIETPHIEUDP> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
            this.Repository = repository;
        }
    }
}
