﻿using MotoApp.Entities;

namespace MotoApp.Repositories
{
    public class GenericRepository<TEntity, TKey> 
        where TEntity : IEntity
    {
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
            return _items.Single(item => item.Id == id);
        }
    }
}
