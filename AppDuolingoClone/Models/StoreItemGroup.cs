using System;
using System.Collections.Generic;

namespace AppDuolingoClone.Models
{
    public class StoreItemGroup : List<StoreItem>
    {
        public string Name { get; private set; }

        public StoreItemGroup(string name, List<StoreItem> storeItems)
        {
            Name = name;
            AddRange(storeItems);
        }
    }
}
