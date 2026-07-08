using System.ComponentModel.DataAnnotations;
namespace EmployeeManagementSystemAI.Models.DTO
{
    public class CreateEmployeeRequestDto
    {
        [Required]
        [StringLength(20)]
        public string EmployeeCode { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        // Personal Information
        [Required]
        public DateOnly DateOfBirth { get; set; }
        [Required]
        [StringLength(50)]
        public string Nationality { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
        [Required]
        [StringLength(250)]
        public string Address { get; set; }

        // Emergency Contact
        [Required]
        [StringLength(100)]
        public string EmergencyContactName { get; set; }
        [Required]
        [StringLength(50)]
        public string EmergencyContactRelation { get; set; }
        [Required]
        [Phone]
        public string EmergencyContactPhone { get; set; }

        // Employment Information
        [Required]
        public string Department { get; set; }
        [Required]
        public string Designation { get; set; }
        [Required]
        public string EmployeeType { get; set; }
        [Required]
        public string WorkLocation { get; set; }
        [Required]

        public DateTime JoiningDate { get; set; }

        // Salary Information
        [Range(0, 1000000)]
        public decimal Salary { get; set; }

        // Status
        
    }
}
