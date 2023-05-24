using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LumiaProject.Models
{
    public class Team
    {
        public int Id { get; set; }
        [Required]
        
        public string Image { get; set; }
        [Required]
        [MaxLength(50)]
        public string Fullname { get; set; }
        [Required]
        public string Description { get; set; }
        public int ProfessionId { get; set; }
        public Profession Profession { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }


    }
}
