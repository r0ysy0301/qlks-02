using System;
using KS.Service.Base;
using KS.Core.Model;
using KS.Core.Interface.Data;
using KS.Core.Interface.Service;

namespace KS.Service.Admin
{
    public partial class AdminCHITIETPHIEUDPService : CHITIETPHIEUDPService, IAdminCHITIETPHIEUDPService
    {
        protected new readonly IAdminRepository<CHITIETPHIEUDP> Repository;

        public AdminCHITIETPHIEUDPService(IAdminRepository<CHITIETPHIEUDP> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
            this.Repository = repository;
        }
    }
}
