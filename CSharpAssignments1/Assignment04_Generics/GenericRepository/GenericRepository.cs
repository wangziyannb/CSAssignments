using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment1.GenericRepository
{
    public class GenericRepository<T> : IRepository<T> where T : Entity
    {
        private List<T> _list;
        private Dictionary<int, T> _map;

        public GenericRepository()
        {
            _list = new List<T>();
            _map = new Dictionary<int, T>();
        }

        public void Add(T item)
        {
            _list.Add(item);
            _map[item.Id] = item;
        }

        public IEnumerable<T> GetAll()
        {
            return _list;
        }

        public T GetById(int id)
        {
            if (_map.ContainsKey(id))
            {
                return _map[id];
            }
            else
            {
                throw new KeyNotFoundException();
            }
        }

        public void Remove(T item)
        {
            _map.Remove(item.Id);
            _list.Remove(item);
        }

        public void Save()
        {
            // save this repo to the database
        }
    }
}
