
namespace BaseLibrary.Entities
{
    public class Department : BaseEntity
    {
        // Many to One relationship with General Department
        public GeneralDepartment? GeneralDepartment { get; set; }
        public int GeneralDepartmentId { get; set; }

        // One to Many relationship with Branch
        public List<Branch>? Branches { get; set; }


    }
}
