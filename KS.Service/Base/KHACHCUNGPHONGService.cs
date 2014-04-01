using System;
using KS.Core.Model;
using KS.Core.Interface.Data;
using KS.Core.Interface.Service;


namespace KS.Service.Base
{
    public partial class KHACHCUNGPHONGService : BaseService<KHACHCUNGPHONG> , IKHACHCUNGPHONGService
    {
        public KHACHCUNGPHONGService(IRepository<KHACHCUNGPHONG> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
        }
    }
}
