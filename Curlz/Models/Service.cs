using System.ComponentModel.DataAnnotations;

namespace Curlz.Models
{
    public class Service
    {
        [Key]
        public int Service_Id { get; set; }
        [Required]
        public string Service_Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
