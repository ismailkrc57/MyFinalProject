using Core.Entities;

namespace Entities.Concrete
{
    public class Treatment:IEntity
    {
        public int  ID { get; set; }
        public int DOCTOR_ID { get; set; }
        public int PATIENT_ID { get; set; }
        public string TEDAVI { get; set; }
        public string TESHIS { get; set; }
        public string MEDICENES { get; set; }
    }
}