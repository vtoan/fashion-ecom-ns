using System.Collections.Generic;
using System.Linq;
using BUS.Interfaces.DAOs;

namespace DAO.DAOs
{
    public class BaseDAO<V> : IBaseDAO<V> where V : class
    {
        protected AppDbContext _context;

        public BaseDAO(AppDbContext context)
        {
            _context = context;
        }

        public V AddItem(V newObject)
        {
            if (newObject == null) return null;
            _context.Add<V>(newObject);
            _context.SaveChangesAsync().Wait();
            return newObject;
        }

        public bool DeleteItem(int id)
        {
            if (id <= 0) return false;
            var obj = _context.Find<V>(id);
            if (obj == null) return false;
            _context.Remove<V>(obj);
            _context.SaveChangesAsync().Wait();
            return true;
        }

        public V GetItem(int id)
        {
            if (id <= 0) return null;
            return _context.Set<V>().Find(id);
        }

        public ICollection<V> GetListItems()
        {
            return _context.Set<V>().ToList();
        }

        public bool UpdateItem(int id, Dictionary<string, object> newObject)
        {
            if (id <= 0 || newObject.Count <= 0) return false;
            var obj = _context.Find<V>(id);
            if (obj == null) return false;
            this._updateDataFor<V>(obj, newObject);
            _context.SaveChangesAsync().Wait();
            return true;
        }

        //Update with Reflecting 
        protected bool _updateDataFor<K>(K target, Dictionary<string, object> modifiedProps)
        {
            if (modifiedProps.Count == 0 || target == null) return false;
            //Update Prop Modifired to Target;
            var targetProps = target.GetType();
            foreach (var item in modifiedProps)
            {
                var prop = targetProps.GetProperty(item.Key);
                if (prop != null) prop.SetValue(target, item.Value);
            }
            return true;
        }
    }
}