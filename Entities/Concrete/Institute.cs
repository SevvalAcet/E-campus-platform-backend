using Core.Entities;

namespace Entities.Concrete
{
    public class Institute:IEntity
    {
        public int InstituteId { get; set; }
        public string InstituteName { get; set; }

    }
}
