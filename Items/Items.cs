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
            int rndValue = _Random.Next(0, Objects.Length - 1);
            NameId = rndValue;
            Name = Objects[rndValue];
            Weight = 1;
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