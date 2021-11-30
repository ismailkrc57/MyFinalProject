using System.Collections.Generic;

namespace Core.CrossCuttingConcerns.Logging
{
    public class LogDetails
    {
        public string MethodName { get; set; }
        public List<LogParameter> LogParameters { get; set; }
    }
}