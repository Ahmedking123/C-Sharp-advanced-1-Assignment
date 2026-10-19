using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_advanced__1_Assignment
{
    internal class CacheItem<T>
    {
        public CacheItem(T item, DateTime expirationDate)
        {
            this.item = item;
            ExpirationDate = expirationDate;
        }

        public T item { get; set; }
        public DateTime ExpirationDate { get; set; }

        
    }
}

