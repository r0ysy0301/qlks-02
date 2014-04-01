using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KS.Core.Interface.Data
{
    public interface IAdminRepository<T> : IRepository<T> where T : class
    {
    }
}
