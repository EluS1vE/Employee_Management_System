
namespace BaseLibrary.Entities
{
    public class GeneralDepartment : BaseEntity
    {
        // One to Many relationship with Department
        public List<Department>? Departments { get; set; }
    }
}
