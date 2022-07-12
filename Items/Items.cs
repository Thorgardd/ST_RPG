namespace RPG.Items
{
    public class Item
    {
        private string[] Objects = new[] { "Batte cloutée", "Revolver", "Grauffres Eggos", "Boisson énérgisante" };
        public string Name;
        public int Weight = 1;
        public Random _Random = new ();
        private int i;

        public Item()
        {
            for (i = 0; i < Objects.Length; i++)
            {
                Name = Objects[_Random.Next(0, Objects.Length)];
                Weight = 1;
            }
        }

        public void GiveItem(string name)
        {
            
        }
    }
}