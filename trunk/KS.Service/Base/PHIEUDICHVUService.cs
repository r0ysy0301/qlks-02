using System;
using KS.Core.Model;
using KS.Core.Interface.Data;
using KS.Core.Interface.Service;

namespace KS.Service.Base
{
    public partial class PHIEUDICHVUService : BaseService<PHIEUDICHVU> , IPHIEUDICHVUService
    {
        public PHIEUDICHVUService(IRepository<PHIEUDICHVU> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
        }
    }
}
