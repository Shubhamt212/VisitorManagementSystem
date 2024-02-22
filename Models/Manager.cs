using System.ComponentModel.DataAnnotations;

namespace VisitorManagementSystem.Models
{
    public class Manager
    {
       
        public int ManagerId { get; set; } //primary key
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        public string FullName { get { return FirstName + "" + LastName; } }
        [Required]
        [StringLength(50)]
        public string Address { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public int Number { get; set; }

        public string Gender { get; set; }

        public ICollection<Visitor>? Visitors { get; set;}
    }
}
