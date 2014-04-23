using System;
using System.Linq;
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
    public partial class LOAIPHONGService
    {

         public IQueryable<LOAIPHONG> GetAll(bool ascending)
        {
            return ascending ? GetAll().OrderBy(m => m.DonGia)
                : GetAll().OrderByDescending(m => m.DonGia);
        }
    }
}
