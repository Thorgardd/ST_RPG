namespace RPG.Items
{
    public class Item
    {
        private string[] Objects = new[] { "Batte cloutée", "Revolver", "Grauffres Eggos", "Boisson énérgisante" };
        public string Name { get; set; }
        public int NameId { get; set; }
        public int Weight { get; set; }
        private readonly Random _Random = new ();

        // Initialiseur d'Item
        public Item()
        {
             CreateItem();
        }

        public void CreateItem()
        {
            Item itemCreated = new Item();
            itemCreated.NameId = Objects[_Random.Next(1, Objects.Length)].Length;
            itemCreated.Name = Objects[itemCreated.NameId];
            itemCreated.Weight = 1;
            /*ItemEffect(itemCreated);*/
        }

        /*public void ItemEffect(Item item)
        {
            switch ()
            {
                case
            }
        }*/
        
    }
}