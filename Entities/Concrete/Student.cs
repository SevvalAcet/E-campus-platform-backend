using Core.Entities;

namespace Entities.Concrete
{
    public class Student:IEntity
    {
        public int StudentId { get; set; }
        public string  AcedemicDepartment { get; set; }
    }
}
