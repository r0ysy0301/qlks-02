using System;
using System.Collections.Generic;
using System.Linq;
using KS.Core.Interface.Data;
using KS.Core.Model;
using KS.Common.Paging;
using KS.Data.Interface;


namespace KS.Data
{
    public class AdminRepository<T> : Repository<T> , IAdminRepository<T> where T : PersistentEntity
    {
        public override bool AllowDeletedItem
        {
            get
            {
                return true;
            }
        }
        public AdminRepository(IDatabaseks databaseks)
            : base(databaseks)
        { }
    }
}
