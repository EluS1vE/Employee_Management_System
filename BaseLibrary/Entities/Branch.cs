
namespace BaseLibrary.Entities
{
    public class Branch : BaseEntity
    {
        // Many to One relationship with Department
        public Department? Department { get; set; }
        public int DepartmentId { get; set; }

        // Relationship: One to Many with Employee
        public List<Employee>? Employees { get; set; }
    }
}
