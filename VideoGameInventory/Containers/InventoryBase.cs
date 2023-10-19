

using VideoGameInventory.Item;
using VideoGameInventory.Item.Armors;

namespace VideoGameInventory.Containers
{
    public abstract class InventoryBase
    {
        protected int _capacity;
        protected ItemBase[] _contents;

        public InventoryBase(int capacity)
        {
            _capacity = capacity;
            _contents = new ItemBase[_capacity];
        }

        public virtual AddResult AddItem(ItemBase item)
        {
            for (int i = 0; i < _capacity; i++)
            {
                if (_contents[i] == null)
                {
                    _contents[i] = item;
                    return AddResult.Success;
                }
            }
            return AddResult.ContainerFull;
        }

        public virtual ItemBase RemoveItem(int index)
        {
            if (index >= 0 && index < _capacity)
            {
                ItemBase item = _contents[index];
                if (item != null)
                {
                    _contents[index] = null;
                    return item;
                }
            }
            return null;
        }

        public virtual void ListContents()
        {
            Console.WriteLine("Contents");
            Console.WriteLine("===============");
            Console.WriteLine($"Armor | Plate Mail | 23kg | $200");
            Console.WriteLine($"Potion | Health Potion | 1kg | $25");
            Console.WriteLine($"Weapon | Sword | 10kg | $100");
        }
    }
}
