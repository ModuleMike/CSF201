namespace VideoGameInventory.Item.Armors
{
    public class Helm : ArmorBase
    {
        public Helm()
        {

            Type = ItemType.Armor;
            Name = "Steel Helmet";
            Description = "Protective metal armor.";
            Weight = 30.0;
            Value = 200m;
            Defense = 71;

        }

    }
}
