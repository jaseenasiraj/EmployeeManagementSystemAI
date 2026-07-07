namespace EmployeeManagementSystemAI.Models.DTO
{
    public class EmployeeDTO
    {
      
        public string EmployeeCode { get; set; }
        public string Name { get; set; }

        // Personal Information
        public DateOnly DateOfBirth { get; set; }
        public string Nationality { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        // Emergency Contact
        public string EmergencyContactName { get; set; }
        public string EmergencyContactRelation { get; set; }
        public string EmergencyContactPhone { get; set; }

        // Employment Information
        public string Department { get; set; }
        public string Designation { get; set; }
        public string EmployeeType { get; set; }
        public string WorkLocation { get; set; }

        public DateTime JoiningDate { get; set; }

        // Salary Information
        public decimal Salary { get; set; }

        // Status
        public bool IsActive { get; set; }
    }
}
