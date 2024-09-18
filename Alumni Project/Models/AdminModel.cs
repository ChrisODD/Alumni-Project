using System.ComponentModel.DataAnnotations;

namespace Alumni_Project.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        // Additional properties specific to Admin
        public bool CanManageUsers { get; set; }
    }
}
