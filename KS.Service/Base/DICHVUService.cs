using System;
using KS.Core.Model;
using KS.Core.Interface.Data;
using KS.Core.Interface.Service;

namespace KS.Service.Base
{
    public partial class DICHVUService : BaseService<DICHVU>, IDICHVUService
    {
        public DICHVUService(IRepository<DICHVU> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
        }
    }
}
