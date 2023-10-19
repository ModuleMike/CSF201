using VideoGameInventory.Containers;
using VideoGameInventory.Item;
using VideoGameInventory.Item.Armors;
using VideoGameInventory.Item.Potions;
using VideoGameInventory.Item.Weapons;

Chest inv = new Chest(3);

inv.AddItem(new Helm());
inv.AddItem(new HealthPotion());
inv.AddItem(new Sword());

if (inv.AddItem(new HealthPotion()) == AddResult.Success)
{
    Console.WriteLine("Capacity is Working");

}

var item = inv.RemoveItem(1);
if (item is HealthPotion && inv.RemoveItem(1) == null)
{
    Console.WriteLine("Removed Potion");
}