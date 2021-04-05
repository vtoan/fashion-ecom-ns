using System.Collections.Generic;

namespace BUS.Interfaces
{

    public interface IGet<T> { T Get(int id); }

    public interface IUpdate<T> { bool Update(int id, T modifiedObject); }

    public interface IAdd<T> { T Add(T newObject); }

    public interface IDelete<T> { bool Delete(int id); }

    public interface IGetList<T> { ICollection<T> GetList(); }

    public interface IBaseService<T> :
        IGet<T>,
        IUpdate<T>,
        IAdd<T>,
        IDelete<T>,
        IGetList<T>
    { }
}