using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BUS.Interfaces.DAOs;
using BUS.Interfaces.Services;

namespace BUS.Services
{
    public abstract class BaseService<T, V> : IBaseService<T>
    {
        protected IBaseDAO<V> _dao;
        protected IMapper _mapper;

        public BaseService(IBaseDAO<V> dao, IMapper mapper)
        {
            _dao = dao;
            _mapper = mapper;
        }

        public T Add(T newObject)
        {
            if (newObject == null) return default(T);
            V obj = _mapper.Map<V>(newObject);
            var result = _dao.AddItem(obj);
            return _mapper.Map<T>(result);
        }

        public bool Delete(int id)
        {
            if (id <= 0) return false;
            return _dao.DeleteItem(id);
        }

        public T Get(int id)
        {
            if (id <= 0) return default(T);
            var result = _dao.GetItem(id);
            if (result == null) return default(T);
            return _mapper.Map<T>(result);
        }

        public ICollection<T> GetList()
        {
            var result = _dao.GetListItems();
            return _mapList<T, V>(result);
        }

        public bool Update(int id, T modifiedObject)
        {
            if (id <= 0 || modifiedObject == null) return false;
            var obj = _mapper.Map<V>(modifiedObject);
            var modifiedProps = _getPropChangedOf(obj);
            return _dao.UpdateItem(id, modifiedProps);
        }


        //Mapper for List Object
        protected List<K> _mapList<K, S>(ICollection<S> source)
        {
            List<K> des = new List<K>();
            if (source == null || source.Count == 0) return des;
            foreach (var item in source)
                des.Add(_mapper.Map<K>(item));
            return des;
        }

        //Reflection Proprety
        protected Dictionary<string, object> _getPropChangedOf(object target, string[] ignore = null)
        {
            Dictionary<string, object> modifiedProps = new Dictionary<string, object>();
            if (target == null) return modifiedProps;
            var srcProps = target.GetType().GetProperties();
            foreach (var p in srcProps)
            {
                //Check ignore prop
                string propName = p.Name;
                if (propName == "Id") continue;
                if (ignore == null || ignore?.Length > 0 && ignore.Contains(propName)) continue;
                //Add val
                if (p.GetValue(target) != null)
                    modifiedProps.Add(p.Name, p.GetValue(target));
            }
            return modifiedProps;
        }
    }
}