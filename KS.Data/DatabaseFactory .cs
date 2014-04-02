using System;
using System.Collections.Generic;
using System.Linq;
using KS.Core.Model;
using KS.Data.Interface;
using KS.Common.Disposable;

namespace KS.Data
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {

        private IDataContext dataContext;

        public IDataContext Get()
        {
            return dataContext ?? (dataContext = new KSDbContext());
        }

        protected override void DisposeCore()
        {
            if (dataContext != null) dataContext.Dispose();
        }
    }
}
