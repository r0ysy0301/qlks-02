using System;
using System.Linq;
using KS.Core.Model;

namespace KS.Core.Interface.Service
{
    public partial interface IAdminPHONGService: IPHONGService
    {
    }
    public partial interface IAdminPHONGService
    {
        IQueryable<PHONG> GetAll(int quantity);
    }
}
