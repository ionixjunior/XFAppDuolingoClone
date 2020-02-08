using System;
using AppDuolingoClone.Enums;

namespace AppDuolingoClone.Models
{
    public class StoreItem
    {
        public string Icon { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Price { get; set; }
        public StoreItemType Type { get; set; }
        public string GroupName { get; set; }
    }
}
