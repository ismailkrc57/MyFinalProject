namespace Core.CrossCuttingConcerns.Logging
{
    public class LogDetailsWithException : LogDetails
    {
        public string ExceptionMessage { get; set; }
    }
}