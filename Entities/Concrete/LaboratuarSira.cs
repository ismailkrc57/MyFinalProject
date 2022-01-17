using Core.Entities;

namespace Entities.Concrete
{
    public class LaboratuarSira:IEntity
    {
        public int ID { get; set; }
        public int SIRA_NO { get; set; }
        public int DOCTOR_ID { get; set; }
        public int PATIENT_ID { get; set; }
    }
}