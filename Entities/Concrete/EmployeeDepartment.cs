using Core.Entities;

namespace Entities.Concrete
{
    public class EmployeeDepartment:IEntity
    {
        public int EmployeeDepartmentId { get; set; }
        public string EmployeeDepartmentName { get; set; }
    }
}
