using System.ComponentModel;

namespace List.Models
{
    public class Item
    {
        public int id { get; set; }
        public string Brrower { get; set; }
        
        [DisplayName("Item Name")]
        public string ItemName { get; set; }
        public string Lender { get; set; }
    }
}