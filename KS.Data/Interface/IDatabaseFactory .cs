using System;

namespace KS.Data.Interface
{
    public interface IDatabaseFactory : IDisposable
    {
        IDataContext Get();
    }
}
