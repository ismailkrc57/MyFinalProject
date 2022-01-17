using Core.Entities;

namespace Entities.Concrete
{
    public class Doctor:IEntity
    {
        public int  ID { get; set; }
        public int  BOLUM_ID { get; set; }
        public int  PERSON_ID { get; set; }
        
    }
}