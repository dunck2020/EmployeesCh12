

namespace EmployeesCh12.Models
{
    public class DepartmentLocation
    {
        // Composite Primary key and foreign key for Department
        public int DepartmentID { get; set; }

        // Composite Primary key and foreign key for Location
        public int LocationID { get; set; }

        // Nav properties
        public Department Department { get; set; }
        public Location Location { get; set; }

    }
}
