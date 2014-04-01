using System;

namespace KS.Core.Model
{
    public abstract class PersistentEntity
    {
        public bool Deleted { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
    }
}
