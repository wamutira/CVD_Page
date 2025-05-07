using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CVD_page.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Item Name")]
        public string ItemName { get; set; }
        [Required]
        [DisplayName("Order Number")]
        public int OrderNo { get; set; }
        [DisplayName("Unit Price")]
        [Required]
        public double price { get; set; }
        [DisplayName("Item Description")]
        public string Desc { get; set; }
        [DisplayName("Unit Packaging")]
        public string unit { get; set; }



    }
}
