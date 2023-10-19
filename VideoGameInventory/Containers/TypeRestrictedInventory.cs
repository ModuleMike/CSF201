

using VideoGameInventory.Item;

namespace VideoGameInventory.Containers
{
    public abstract class TypeRestrictedInventory : InventoryBase
    {

        protected ItemType _requiredType;
      

        public TypeRestrictedInventory (int capacity, ItemType _requiredType) : base(capacity)
        {
            _requiredType = _requiredType;
        }

        public override AddResult AddItem(ItemBase item)
        {
            if (_requiredType == item.Type)
            {
                return base.AddItem(item);
            }
            return AddResult.WrongType;
        }
    }
}
