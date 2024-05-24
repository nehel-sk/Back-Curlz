using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Curlz.Models
{
    public class Slot
    {
        [Key]
        public int Slot_Id { get; set; }


        [Required]
        public string Time { get; set; }


     

    }
}
