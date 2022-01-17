using Core.Entities;

namespace Entities.Concrete
{
    public class Patient:IEntity
    {
        public int ID { get; set; }
        public int PERSON_ID { get; set; }
        
    }
}