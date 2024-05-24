using Curlz.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Curlz.Models
{
    public class Feedback
    {
        [Key]
        public int Feedback_Id { get; set; }
        public int Reg_Id { get; set; }
        [ForeignKey("Reg_Id")]
        public Registration? Registration { get; set; }


        //public int Service_Id { get; set; }
        //[ForeignKey("Service_Id")]
        //public Service? Service { get; set; }

        [Required]
        public string? Comment { get; set; }
        public int Rating { get; set; }
        public DateTime Commenting_Date { get; set; }




    }
}

