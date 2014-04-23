using System;
using System.Linq;
using KS.Core.Model;

namespace KS.Core.Interface.Service
{
    public partial interface IPHONGService: IService<PHONG>
    {
    }
    public partial interface IPHONGService
    {
        IQueryable<PHONG> GetThuong(int quantity);
        //IQueryable<PHONG> GetVip(int quantity);
        //IQueryable<PHONG> GetDon(int quantity);
        //IQueryable<PHONG> GetDoi(int quantity);
    }
}
