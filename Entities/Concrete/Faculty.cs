using Core.Entities;

namespace Entities.Concrete
{
    public class Faculty:IEntity
    {
        public int FacultyId { get; set; }
        public string FacultyName { get; set; }
    }
}
