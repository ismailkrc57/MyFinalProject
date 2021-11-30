using Serilog;

namespace Core.CrossCuttingConcerns.Logging.Serilog.Logers
{
    public class ConsoleLogger : SerilogManager
    {
        public ConsoleLogger() : base(new LoggerConfiguration().WriteTo.Console().CreateLogger())
        {
        }
    }
}