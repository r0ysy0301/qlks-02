using System;

namespace KS.Data.Interface
{
    public interface IDatabaseks:IDisposable
    {
        IDataContext Get();
    }
}
