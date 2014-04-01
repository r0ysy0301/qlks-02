using System;
using KS.Core.Model;
using KS.Core.Interface.Data;
using KS.Core.Interface.Service;

namespace KS.Service.Base
{
    public partial class PHIEUTHUETRAService : BaseService<PHIEUTHUETRA> , IPHIEUTHUETRAService
    {
        public PHIEUTHUETRAService(IRepository<PHIEUTHUETRA> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
        }
    }
}
