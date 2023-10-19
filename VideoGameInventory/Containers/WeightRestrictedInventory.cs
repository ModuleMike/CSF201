

using System;
using VideoGameInventory.Item;

namespace VideoGameInventory.Containers
{
    public class WeightRestrictedInventory : InventoryBase
    {

        protected double _currentWeight;
        protected double _maxWeight;
        
        public  WeightRestrictedInventory(int capacity, double maxWeight) : base(capacity)
        {
            _maxWeight = maxWeight;

        }

        public override AddResult AddItem(ItemBase item)
        {
            if (_currentWeight + item.Weight > _maxWeight)
            {
                return AddResult.OverWeight;
            }
            if (base.AddItem(item) == AddResult.Success)
            {
                _currentWeight += item.Weight;
            }
            return AddResult.Success;
        }

        public override ItemBase RemoveItem(int index)
        {
            var item = base.RemoveItem(index);
            if (item != null)
            {
                _currentWeight -= item.Weight;
            }
            return item;
        }
    }

    
}
