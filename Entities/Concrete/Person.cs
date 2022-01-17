using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class Person:IEntity
    {
        public int  ID { get; set; }
        public string TC_NO { get; set; }
        public string NAME { get; set; }
        public string SURNAME { get; set; }
        public string PHONE { get; set; }
        public string ADDRESS { get; set; }
        public DateTime DATE_OF_BIRTH { get; set; }
        public string GENDER { get; set; }
    }
}