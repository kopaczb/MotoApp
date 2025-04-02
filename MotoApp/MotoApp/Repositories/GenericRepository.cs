using MotoApp.Entities;

namespace MotoApp.Repositories
{
    public class GenericRepository<TEntity, TKey> 
        //where TEntity : class, IEntity // : klasa, która dziedziczy po IEntity
        where TEntity : class, IEntity, new() // :klasa, która dziedziczy po IEntity, klasa dziedziczaca IEntity musi miec bezparametrowy konstruktor, my testowalismy na klasi Employee
        where TKey : struct
    {
        public TEntity CreateNewItem()
        {
            return new TEntity();
        }
        public TKey? Key { get; set; }
        protected readonly List<TEntity> _items = new();
        public void Add(TEntity item)
        { 
            item.Id = _items.Count + 1;
            _items.Add(item);
        }
        public void Save()
        {
            foreach (var item in _items)
            { 
                Console.WriteLine(item);
            }
        }
        public TEntity GetById(int id) 
        {
            return default(TEntity);
            //return _items.Single(item => item.Id == id);
        }
    }
}
