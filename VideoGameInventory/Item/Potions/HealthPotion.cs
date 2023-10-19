using System.Security.Cryptography.X509Certificates;

namespace VideoGameInventory.Item.Potions
{
    internal class HealthPotion : PotionBase 
    {

        public HealthPotion()
        {

            Type = ItemType.Potion;
            Name = "Health Potion";
            Description = "Restores a small amount of health.";
            Weight = 1.0;
            Value = 25m;
        }

            public override void Drink()
            {
                Console.WriteLine("Glug, glug, glug! You feel better!");
            }

        }

}

