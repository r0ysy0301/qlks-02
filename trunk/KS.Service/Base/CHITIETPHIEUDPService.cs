using System;
using System.Linq;
using KS.Core.Model;
using KS.Core.Interface.Data;
using KS.Core.Interface.Service;

namespace KS.Service.Base
{
    public partial class CHITIETPHIEUDPService : BaseService<CHITIETPHIEUDP>, ICHITIETPHIEUDPService
    {
        public CHITIETPHIEUDPService(IRepository<CHITIETPHIEUDP> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
        }
    }
    public partial class CHITIETPHIEUDPService
    {
        public IQueryable<CHITIETPHIEUDP> GetAll(bool asceding)
        {
            return asceding ? GetAll().OrderBy(m => m.MaKhach)
                : GetAll().OrderByDescending(m => m.MaKhach);
        }
    }
}
