using Bridge.Foundation;

namespace System 
{
	[Ignore]
	[Namespace("Bridge")]
	public class InvalidOperationException : Exception 
    {
		public InvalidOperationException() 
        {
		}

		public InvalidOperationException(string message) 
        {
		}

		public InvalidOperationException(string message, Exception innerException) 
        {
		}
	}
}