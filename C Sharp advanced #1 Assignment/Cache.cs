using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace C_Sharp_advanced__1_Assignment
{
    internal class Cache<TKey,TValue>
    {
        Dictionary<TKey, CacheItem<TValue>> _Items = new();

        public void Add(TKey key,TValue Item,DateTime Duration) 
        {
            _Items.Add(key, new CacheItem<TValue>(Item, Duration));
        }

        public CacheItem<TValue> Get(TKey key)
        {
            return _Items[key];
        }
        public void Remove(TKey key)
        {
            _Items.Remove(key);
        }
        public bool Contain(TKey key)
        {
            return _Items.ContainsKey(key);
        }
    }
}
