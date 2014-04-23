using System;
using System.Linq;
using KS.Core.Model;

namespace KS.Core.Interface.Service
{
    public partial interface ILOAIPHONGService : IService<LOAIPHONG>
    {
        IQueryable<LOAIPHONG> GetAll(bool ascending);
    }
}
