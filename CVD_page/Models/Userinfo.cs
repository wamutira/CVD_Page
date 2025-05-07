using System.ComponentModel.DataAnnotations;

namespace CVD_page.Models
{
    public class Userinfo
    {
        [Key]
        public int Is { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string email { get; set; }
        public string telephone { get; set; }
        [Required]
        public string info { get; set; }

    }
}
