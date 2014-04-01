using System;
using KS.Core.Model;
using KS.Core.Interface.Data;
using KS.Core.Interface.Service;

namespace KS.Service.Base
{
    public partial class PHIEUDATPHONGService : BaseService<PHIEUDATPHONG> , IPHIEUDATPHONGService
    {
        public PHIEUDATPHONGService(IRepository<PHIEUDATPHONG> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
        }
    }
}
