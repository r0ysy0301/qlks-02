using System;
using KS.Core.Model;
using KS.Core.Interface.Data;
using KS.Core.Interface.Service;

namespace KS.Service.Base
{
    public partial class DOANKHACHService : BaseService<DOANKHACH> , IDOANKHACHService
    {
        public DOANKHACHService(IRepository<DOANKHACH> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
        }
    }
}
