using System;
using System.ComponentModel.DataAnnotations;

namespace Alumni_Project.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

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

        public string CurrentJobTitle { get; set; }
        public string Organization { get; set; }

        public string GitHubProfile { get; set; }
        public string LinkedInProfile { get; set; }

        public bool IsMentor { get; set; }

        public DateTime GraduationDate { get; set; }

        public string ProfileImageUrl { get; set; }  // URL for profile image
    }
}
