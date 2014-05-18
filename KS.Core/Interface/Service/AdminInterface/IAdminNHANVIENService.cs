using System;
using System.Linq;
using KS.Core.Model;

namespace KS.Core.Interface.Service
{
    public partial interface IAdminNHANVIENService : INHANVIENService
    {

    }
    public partial interface IAdminNHANVIENService
    {
        IQueryable<NHANVIEN> GetAll(int quantity);
    }
}
