using System;
using KS.Core.Model;
using KS.Core.Interface.Data;
using KS.Core.Interface.Service;

namespace KS.Service.Base
{
    public partial class LOAIPHONGService : BaseService<LOAIPHONG> , ILOAIPHONGService
    {
        public LOAIPHONGService(IRepository<LOAIPHONG> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
        }
    }
}
