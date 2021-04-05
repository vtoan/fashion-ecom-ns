using System.Collections.Generic;

namespace BUS.Interfaces.DAOs
{
    public interface IGetItem<V> { V Get(int id); }
    public interface IGetListItems<V> { ICollection<V> GetList(); }
    public interface IAddItem<V> { V Add(V newObject); }
    public interface IUpdateItem<V> { bool Update(int id, Dictionary<string, object> newObject); }
    public interface IDeleteItem<V> { bool Delete(int id); }
    public interface IBaseDAO<V> :
        IGetItem<V>,
        IGetListItems<V>,
        IAddItem<V>,
        IUpdateItem<V>,
        IDeleteItem<V>
    { }
}