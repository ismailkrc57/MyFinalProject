using Serilog;

namespace Core.CrossCuttingConcerns.Logging.Serilog.Logers
{
    public class FileLogger : SerilogManager
    {
        public FileLogger() : base(new LoggerConfiguration().WriteTo.File("./logs/myapp.json").CreateLogger())
        {
        }
    }
}