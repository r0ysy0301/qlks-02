using System;
using System.Linq;
using KS.Core.Model;

namespace KS.Core.Interface.Service
{
    public partial interface ICHITIETPHIEUDPService : IService<CHITIETPHIEUDP>
    {

    }
    public partial interface ICHITIETPHIEUDPService
    {
        IQueryable<CHITIETPHIEUDP> GetAll(bool asceding);
    }
}
