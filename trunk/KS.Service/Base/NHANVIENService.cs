using System;
using KS.Core.Model;
using KS.Core.Interface.Data;
using KS.Core.Interface.Service;

namespace KS.Service.Base
{
    public partial class NHANVIENService : BaseService<NHANVIEN> , INHANVIENService
    {
        public NHANVIENService(IRepository<NHANVIEN> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
        }
    }
}
