using Core.Entities;

namespace Entities.Concrete
{
    public class AcademicDepartment:IEntity
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }
}
