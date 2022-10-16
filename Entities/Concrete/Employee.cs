using Core.Entities;

namespace Entities.Concrete
{
    public class Employee:IEntity
    {
        public int EmployeeId { get; set; }
        public EmployeeDepartment EmployeeDepartment { get; set; }
    }
}
