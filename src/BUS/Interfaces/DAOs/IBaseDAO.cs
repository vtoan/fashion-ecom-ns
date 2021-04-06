using System.Collections.Generic;

namespace BUS.Interfaces.DAOs
{
    public interface IGetItem<V> { V GetItem(int id); }
    public interface IGetListItems<V> { ICollection<V> GetListItems(); }
    public interface IAddItem<V> { V AddItem(V newObject); }
    public interface IUpdateItem<V> { bool UpdateItem(int id, Dictionary<string, object> newObject); }
    public interface IDeleteItem<V> { bool DeleteItem(int id); }
    public interface IBaseDAO<V> :
        IGetItem<V>,
        IGetListItems<V>,
        IAddItem<V>,
        IUpdateItem<V>,
        IDeleteItem<V>
    { }
}