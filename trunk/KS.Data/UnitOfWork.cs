using System;
using System.Collections.Generic;
using System.Linq;
using KS.Core.Interface.Data;
using KS.Data.Interface;

namespace KS.Data
{
    public class UnitOfWork: IUnitOfWork
    {
        private IDataContext dataContext;
        private readonly IDatabaseks databaseks;
        protected IDataContext DataContext
        {
            get 
            {
                return dataContext ?? (dataContext = databaseks.Get());
            }
        }
        public UnitOfWork(IDatabaseks databaseks)
        {
            this.databaseks = databaseks;
        }
        public int Commit()
        {
            return DataContext.Commit();
        }
    }
}
