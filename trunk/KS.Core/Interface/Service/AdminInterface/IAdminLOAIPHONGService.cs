using System;
using System.Linq;
using KS.Core.Model;

namespace KS.Core.Interface.Service
{
    public partial interface IAdminLOAIPHONGService : ILOAIPHONGService
    {
    }
    public partial interface IAdminLOAIPHONGService
    {
        IQueryable<LOAIPHONG> GetAll(int quantity);
    }
}
