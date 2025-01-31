namespace MyApp.Models
{
    public class ItemClient
    {
        public int Itemid { get; set; }
        public Item Item { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
