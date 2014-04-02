using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using KS.Core.Model;


namespace KS.Data.Interface
{
    public interface IDataContext: IDisposable
    {
        IDbSet<T> DbSet<T>() where T : PersistentEntity;
        DbEntityEntry<T> EntryGet<T>(T entity) where T : PersistentEntity;
        int Commit();
    }
}
