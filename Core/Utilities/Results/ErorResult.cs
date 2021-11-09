namespace Core.Utilities.Results
{
    public class ErorResult:Result
    {
        public ErorResult( string message) : base(false, message)
        {
        }

        public ErorResult() : base(false)
        {
        }
    }
}
