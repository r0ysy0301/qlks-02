using System;
using KS.Core.Interface.Data;
using KS.Core.Model;
using KS.Common.Paging;
using KS.Data.Interface;

namespace KS.Data
{
    public class QuanliRepository<T> : Repository<T>, IQuanliRepository<T> where T:PersistentEntity
    {
        public override bool AllowDeletedItem
        {
            get
            {
                return true;
            }
        }
        public QuanliRepository(IDatabaseks databaseks)
            : base(databaseks)
        { }
    }
}
